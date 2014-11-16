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
    public partial class Form1 : Form
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

        public static string ProjectLocation = "";

        FileStream Reader;
        FileStream Writer;

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


        public Form1()
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
            //if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then try again."); return; }
            DialogResult DR = MessageBox.Show("Are you sure to Exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (DR == DialogResult.No) return;
            this.Close();
        }

        void BrowseSource_Click(object sender, EventArgs e)
        {
            if (StartedSpliting) { MessageBox.Show("You cannot perform this action after started to split the file. Stop the process if running and then Click Restart Spliting option from the file menu to do this action."); return; }
            //if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then try again."); }
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.CheckFileExists = true;
            if (OFD.ShowDialog() == DialogResult.Cancel) return;
            //ClearAll();
            AssignSourceFile(OFD.FileName);
        }

        void BrowsePart_Click(object sender, EventArgs e)
        {
            //if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then proceed."); return; }
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.CheckPathExists = true;
            if (SFD.ShowDialog() == DialogResult.Cancel) return;
            txtPartName.Text = SFD.FileName;
        }

        void AssignSourceFile(string Path)
        {
            try
            {
                Reader = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.None);
                SourceByte = new byte[30];
                Reader.Read(SourceByte, 0, 10);
                Reader.Position = (Reader.Length / 2) - 5;
                Reader.Read(SourceByte, 10, 10);
                Reader.Position = Reader.Length - 10;
                Reader.Read(SourceByte, 20, 10);
                Reader.Position = 0;
                txtSourceFile.Text = Path;
                txtNumParts.Value = PARTS;
                txtPartSize.Maximum = Reader.Length / 2;
                txtPartSize.Minimum = Reader.Length / 100;
                txtPartSize.Value = Reader.Length / PARTS;
                txtTotalSize.Text = Reader.Length.ToString();
                TotalSize = RemainingSize = Reader.Length;
                panelButtons.Visible = true;
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
            txtPartSize.Value = (int)Reader.Length / txtNumParts.Value;
        }

        private void txtPartSize_ValueChanged(object sender, EventArgs e)
        {
            txtNumParts.Value = (int)Reader.Length / txtPartSize.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (RemainingSize == 0) return;
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
        }

        private void generatePart(int numPart, long tempInt)
        {
            tempInt = (RemainingSize - tempInt < 0 ? RemainingSize : tempInt);
            //txtPartSize.Text = tempInt.ToString();

            RemainingSize = RemainingSize - tempInt;

            string StartByte = "1", EndByte = txtPartSize.Text;

            if (lstParts.Items.Count != 0)
            {
                long tmpStart = Convert.ToInt64(lstParts.Items[lstParts.Items.Count - 1].SubItems[3].Text);
                long tmpEnd = tmpStart + Convert.ToInt64(txtPartSize.Text);
                tmpStart++;
                StartByte = tmpStart.ToString();
                EndByte = tmpEnd.ToString();
            }

            lstParts.Items.Add(new ListViewItem(new string[] { txtPartName.Text + "." + numPart.ToString(), txtPartSize.Text, StartByte, EndByte }));

            if (RemainingSize > 0) { generatePart(numPart + 1, tempInt); }

        }
    }
}
