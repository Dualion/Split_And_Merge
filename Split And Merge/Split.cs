using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Split_And_Merge
{
    public partial class Split : Form
    {

        #region Variables

        private const int PARTS = 10;
        ListView lstParts = new System.Windows.Forms.ListView();
        private System.Windows.Forms.ColumnHeader itmFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        private System.Windows.Forms.ColumnHeader itmPartSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        private System.Windows.Forms.ColumnHeader itmStartByte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        private System.Windows.Forms.ColumnHeader itmEndByte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

        string[] FileLocationArr;
        long[] FileSizeArr;
        long[] StartByteArr;
        long[] EndByteArr;

        byte[] SourceByte;


        //FileStream Reader;
        FileStream Writer;
        BinaryReader fileReader;

        bool Canceled = false;
        bool StartedSpliting = false;

        // Total size of file in bytes
        long TotalSize;

        // Total Size Used while adding.
        long RemainingSize;

        // Size of the buffer selected by user
        long BufferSize;

        // Total no of files to be splited
        int TotalFile;

        // Index Number of current file in progress
        int CurrentFileIndex;

        long LastEstimation = 0;

        // Buffer for transferring data
        byte[] Data;

        #endregion

		public Split()
		{
			this.lstParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itmFileName,
            this.itmPartSize,
            this.itmStartByte,
            this.itmEndByte});

            InitializeComponent();

		}

        private void Exit_Click(object sender, EventArgs e)
        {
            if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then try again."); return; }
            DialogResult DR = MessageBox.Show("Are you sure to Exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (DR == DialogResult.No) return;
            this.Close();
        }

        void BrowseSource_Click(object sender, EventArgs e)
        {
            if (StartedSpliting) { MessageBox.Show("You cannot perform this action after started to split the file. Stop the process if running and then Click Restart Spliting option from the file menu to do this action."); return; }
            if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then try again."); }
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.CheckFileExists = true;
            if (OFD.ShowDialog() == DialogResult.Cancel) return;
            //ClearAll();
            AssignSourceFile(OFD.FileName);
        }

        void BrowsePart_Click(object sender, EventArgs e)
        {
            if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then proceed."); return; }
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.CheckPathExists = true;
            if (SFD.ShowDialog() == DialogResult.Cancel) return;
            txtPartName.Text = SFD.FileName;
        }

        void AssignSourceFile(string Path)
        {
            try
            {
                using (fileReader = new BinaryReader(File.Open(Path, FileMode.Open, FileAccess.Read, FileShare.None)))
                {
                    SourceByte = new byte[30];
                    fileReader.Read(SourceByte, 0, 10);

                    fileReader.BaseStream.Position = (fileReader.BaseStream.Length / 2) - 5;
                    fileReader.Read(SourceByte, 10, 10);
                    fileReader.BaseStream.Position = fileReader.BaseStream.Length - 10;
                    fileReader.Read(SourceByte, 20, 10);
                    fileReader.BaseStream.Position = 0;
                    txtSourceFile.Text = Path;
                    txtTotalSize.Text = fileReader.BaseStream.Length.ToString();
                    TotalSize = RemainingSize = fileReader.BaseStream.Length;
                    txtNumParts.Value = PARTS;
                    txtPartSize.Maximum = fileReader.BaseStream.Length / 2;
                    txtPartSize.Minimum = fileReader.BaseStream.Length / 100;
                    panelButtons.Visible = true;
                    fileReader.BaseStream.Close();
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("The specified source file to split was not found. Please select an existing file.", "File Not Found"); }
            catch { MessageBox.Show("The selected source file could not be accessed. It might be either blocked by some other process. Stop all the process using the file and then try again.", "Error"); }
        }

        private void rButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            if (rButtonNParts.Checked)
            {
                txtNumParts.Enabled = true;
                txtPartSize.Enabled = false;
            }
            else if (rButtonSParts.Checked)
            {
                txtNumParts.Enabled = false;
                txtPartSize.Enabled = true;
            }
        }

        private void txtNumParts_ValueChanged(object sender, EventArgs e)
        {
            txtPartSize.Value = Math.Ceiling(TotalSize / txtNumParts.Value);

        }

        private void txtPartSize_ValueChanged(object sender, EventArgs e)
        {
            txtNumParts.Value = Math.Ceiling(TotalSize / txtPartSize.Value);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RemainingSize = TotalSize;
            if (txtPartName.Text.Length == 0 || txtPartSize.Text.Length == 0)
            {
                MessageBox.Show("Enter the filename and the size of the part to be added and then try again.");
                return;
            }
            long tempInt;
            try
            {
                tempInt = Convert.ToInt64(txtPartSize.Text.Trim());
            }
            catch { MessageBox.Show("Only numbers can be entered in the size column provided. No alphabets or special characters can be entered."); return; }

            lstParts.Items.Clear();

            if (RemainingSize < tempInt) { MessageBox.Show("Size mentioned is greater than the size remaining Remaining size."); return; }

            generatePart(0, tempInt);
            Start();
        }

        private void generatePart(int numPart, long tempInt)
        {
            tempInt = (RemainingSize - tempInt < 0 ? RemainingSize : tempInt);
            RemainingSize = RemainingSize - tempInt;

            string StartByte = "1", EndByte = tempInt.ToString();

            if (lstParts.Items.Count != 0)
            {
                long tmpStart = Convert.ToInt64(lstParts.Items[lstParts.Items.Count - 1].SubItems[3].Text);
                long tmpEnd = tmpStart + Convert.ToInt64(tempInt.ToString());
                tmpStart++;
                StartByte = tmpStart.ToString();
                EndByte = tmpEnd.ToString();
            }

            lstParts.Items.Add(new ListViewItem(new string[] { txtPartName.Text + "." + numPart.ToString(), tempInt.ToString(), StartByte, EndByte }));

            if (RemainingSize > 0) { generatePart(numPart + 1, tempInt); }

        }

        private void Start()
        {
            if (lstParts.Items.Count == 0) { MessageBox.Show("Add the name and size of each part to split.", "No Parts Found"); return; }
            if (lstParts.Items.Count == 1) { MessageBox.Show("The file must be atleast splited into two parts.", "Requirement Failed"); return; }
            try
            {
                fileReader = new BinaryReader(File.Open(txtSourceFile.Text, FileMode.Open, FileAccess.Read, FileShare.None));
            }
            catch (FileNotFoundException) { MessageBox.Show("The specified source file to split was not found. Please select an existing file.", "File Not Found"); return; }
            catch { MessageBox.Show("The selected source file could not be accessed. It might be either blocked by some other process. Stop all the process using the file and then try again.", "Error"); return; }

            TotalFile = lstParts.Items.Count;
            FileLocationArr = new string[TotalFile];
            FileSizeArr = new long[TotalFile];
            StartByteArr = new long[TotalFile];
            EndByteArr = new long[TotalFile];
            BufferSize = Convert.ToInt64(txtBufferSize.Value);
            for (int i = 0; i < TotalFile; i++)
            {
                FileLocationArr[i] = lstParts.Items[i].SubItems[0].Text;
                FileSizeArr[i] = Convert.ToInt64(lstParts.Items[i].SubItems[1].Text);
                StartByteArr[i] = Convert.ToInt64(lstParts.Items[i].SubItems[2].Text);
                EndByteArr[i] = Convert.ToInt64(lstParts.Items[i].SubItems[3].Text);
            }

            Splitter.RunWorkerAsync();
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            panelStatus.Visible = true;
            Progressor.Enabled = true;
            LastEstimation = fileReader.BaseStream.Position;
            TimeEstimater.Enabled = true;

            txtTimeRemaining.Text = "Started, Processing...";
        }

        void btnStop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to end the process?", "Confirm End Process", MessageBoxButtons.YesNo) == DialogResult.No) return;
            btnStop.Enabled = false;
            Canceled = true;
        }

        void ProgressChanged(object sender, EventArgs e)
        {
            try
            {
                txtFileProcessing.Text = "File " + Convert.ToString(CurrentFileIndex + 1) + " / " + TotalFile.ToString();

                progressCurrentFile.Value = Convert.ToInt32((Writer.Length * 100) / FileSizeArr[CurrentFileIndex]);
                txtCurrentFileByte.Text = Writer.Length + " Bytes";
                txtCurrentFilePrec.Text = progressCurrentFile.Value.ToString() + "% Completed";

                progressOverallStatus.Value = Convert.ToInt32((fileReader.BaseStream.Position * 100) / TotalSize);
                txtOverallFileByte.Text = fileReader.BaseStream.Position.ToString() + " Bytes";
                txtOverallPerc.Text = progressOverallStatus.Value.ToString() + "% Completed";
            }
            catch { }
        }

        string GetHours(ref long Sec)
        {
            long Count = 0;
            while (Sec > 3599)
            {
                Count++;
                Sec -= 3600;
            }
            if (Count == 0)
            {
                if (Sec != 0) return GetMin(ref Sec);
                else return "";
            }
            else
            {
                if (Sec != 0) return Count.ToString() + " Hours  " + GetMin(ref Sec);
                else return Count.ToString() + " Hours";
            }
        }

        string GetMin(ref long Sec)
        {
            long Count = 0;
            while (Sec > 59)
            {
                Count++;
                Sec -= 60;
            }
            if (Count == 0)
            {
                if (Sec != 0) return Sec.ToString() + " Seconds";
                else return "";
            }
            else
            {
                if (Sec != 0) return Count.ToString() + " Minutes  " + Sec.ToString() + " Seconds";
                else return Count.ToString() + " Minutes";
            }
        }

        void EstimateTime(object sender, EventArgs e)
        {
            long tmpVar = fileReader.BaseStream.Position - LastEstimation;
            LastEstimation = fileReader.BaseStream.Position;
            if (tmpVar >= 0) tmpVar = (((TotalSize - fileReader.BaseStream.Position) / tmpVar) * 5);
            if (tmpVar < 20) tmpVar += 6;
            txtTimeRemaining.Text = GetHours(ref tmpVar) + "  (approximately)";
        }

        private void txtBufferSize_ValueChanged(object sender, EventArgs e)
        {
            BufferSize = Convert.ToInt64(txtBufferSize.Value);
        }

        #region Spliting

        void SplitFile(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            long tmpEndByte;
            long tmpReadByte;
            CurrentFileIndex = 0;

            while (CurrentFileIndex < TotalFile)
            {
                Data = null;
                try
                {
                    Data = new byte[Convert.ToInt32(BufferSize)];
                }
                catch
                {
                    BufferSize -= 50000;
                    continue;
                }
                Directory.CreateDirectory(FileLocationArr[CurrentFileIndex].Substring(0, FileLocationArr[CurrentFileIndex].LastIndexOf("\\")));
                Writer = new FileStream(FileLocationArr[CurrentFileIndex], FileMode.Append, FileAccess.Write, FileShare.None);

                // Set the position of the reader.
                fileReader.BaseStream.Position = StartByteArr[CurrentFileIndex] - 1 + Writer.Length;

                // Get the end position of Current file.
                tmpEndByte = EndByteArr[CurrentFileIndex];

                tmpReadByte = fileReader.BaseStream.Position;

                while (tmpReadByte < tmpEndByte)
                {
                    // Assign no of bytes to read
                    if (fileReader.BaseStream.Position + BufferSize > tmpEndByte)
                    {
                        Data = null;
                        try
                        {
                            Data = new byte[Convert.ToInt32(tmpEndByte - fileReader.BaseStream.Position)];
                        }
                        catch { BufferSize -= 50000; continue; }
                    }

                    // Read and write the data
                    //tmpReadByte += Reader.Read(Data, 0, Data.Length);
                    Data = fileReader.ReadBytes(Data.Length);
                    tmpReadByte += Data.Length;
                    Writer.Write(Data, 0, Data.Length);
                    if (Canceled) return;
                }

                // Add completed file when completed.
                CurrentFileIndex++;
                Writer.Flush(); Writer.Close();
            }
        }

        void SplitingCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (Canceled) MessageBox.Show("The process had been canceled by the user. Click Start button to resume it again.", "Process Canceled");
            else
            {
                txtFileProcessing.Text = "File " + Convert.ToString(CurrentFileIndex + 1) + " / " + TotalFile.ToString();

                progressCurrentFile.Value = 100;
                txtCurrentFileByte.Text = lstParts.Items[lstParts.Items.Count - 1].SubItems[3].Text + " Bytes";
                txtCurrentFilePrec.Text = "100% Completed";

                progressOverallStatus.Value = 100;
                txtOverallFileByte.Text = txtTotalSize.Text + " Bytes";
                txtOverallPerc.Text = "100% Completed";
            }

            Progressor.Enabled = false;
            TimeEstimater.Enabled = false;
            txtTimeRemaining.Text = "Estimating... Please Wait";

            try { Writer.Close(); Writer = null; }
            catch { }

            fileReader.Close(); fileReader = null;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            panelStatus.Visible = false;
            Canceled = false;
        }
        #endregion

    }
}
