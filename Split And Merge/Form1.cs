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


    }
}
