using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Split_And_Merge
{
	public partial class Split : Form
	{

		private const int PARTS = 10;

		string[] FileLocationArr;
		byte[] SourceByte;
		long TotalSize;		// Total size of file in bytes
		int TotalFile;		// Total no of files to be splited
		long BufferSize;	// Size of the buffer selected by user
		int CurrentFileIndex;// Index Number of current file in progress
		int startTime;		// Date time when process starts

		#region VariablesSplitter

		public static string filePath = "";

		#region columns ListView
		ListView lstParts = new System.Windows.Forms.ListView();
		private System.Windows.Forms.ColumnHeader itmFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		private System.Windows.Forms.ColumnHeader itmPartSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		private System.Windows.Forms.ColumnHeader itmStartByte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		private System.Windows.Forms.ColumnHeader itmEndByte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		#endregion

		long[] FileSizeArr;
		long[] StartByteArr;
		long[] EndByteArr;

		FileStream fileWriter;
		BinaryReader fileReader;

		bool Canceled = false;
		bool StartedSpliting = false;

		long LastEstimation = 0;
		long RemainingSize;	// Total Size Used while adding.
		byte[] Data;		// Buffer for transferring data

		#endregion

		#region VariablesMerge

		bool StartedMerged = false;
		Stream outputFile;
		Stream inputFile;

		#endregion

		#region Split

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

		private void AssignSourceFile(string Path)
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
					filePath = txtSourceFileSplit.Text = Path;
					txtTotalSizeSplit.Text = fileReader.BaseStream.Length.ToString();
					TotalSize = RemainingSize = fileReader.BaseStream.Length;
					txtNumParts.Value = PARTS;
					txtPartSize.Maximum = fileReader.BaseStream.Length / 2;
					txtPartSize.Minimum = fileReader.BaseStream.Length / 100;
					panelButtonsSplit.Visible = true;
					fileReader.BaseStream.Close();
				}
			}
			catch (FileNotFoundException) { MessageBox.Show("The specified source file to split was not found. Please select an existing file.", "File Not Found"); }
			catch { MessageBox.Show("The selected source file could not be accessed. It might be either blocked by some other process. Stop all the process using the file and then try again.", "Error"); }
		}

		void BrowseSource_Click(object sender, EventArgs e)
		{
			if (StartedSpliting) { MessageBox.Show("You cannot perform this action after started to split the file. Stop the process if running and then Click Restart Spliting option from the file menu to do this action."); return; }
			if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then try again."); }
			OpenFileDialog OFD = new OpenFileDialog();
			OFD.CheckFileExists = true;
			if (OFD.ShowDialog() == DialogResult.Cancel) return;
			AssignSourceFile(OFD.FileName);
		}

		void BrowsePart_Click(object sender, EventArgs e)
		{
			if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then proceed."); return; }
			SaveFileDialog SFD = new SaveFileDialog();
			SFD.CheckPathExists = true;
			if (SFD.ShowDialog() == DialogResult.Cancel) return;
			txtPartNameSplit.Text = SFD.FileName;
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

			lstParts.Items.Add(new ListViewItem(new string[] { txtPartNameSplit.Text + "." + numPart.ToString("D3"), tempInt.ToString(), StartByte, EndByte }));

			if (RemainingSize > 0) { generatePart(numPart + 1, tempInt); }

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			RemainingSize = TotalSize;
			if (txtPartNameSplit.Text.Length == 0 || txtPartSize.Text.Length == 0)
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

			generatePart(1, tempInt);
			Start();
		}

		void ProgressChanged(object sender, EventArgs e)
		{
			if (!Splitter.IsBusy) return;
			try
			{
				txtFileProcessingSplit.Text = "File " + Convert.ToString(CurrentFileIndex + 1) + " / " + TotalFile.ToString();

				progressCurrentFileSplit.Value = Convert.ToInt32((fileWriter.Length * 100) / FileSizeArr[CurrentFileIndex]);
				txtCurrentFileByteSplit.Text = fileWriter.Length + " Bytes";
				txtCurrentFilePrecSplit.Text = progressCurrentFileSplit.Value.ToString() + "% Completed";

				progressOverallStatusSplit.Value = Convert.ToInt32((fileReader.BaseStream.Position * 100) / TotalSize);
				txtOverallFileByteSplit.Text = fileReader.BaseStream.Position.ToString() + " Bytes";
				txtOverallPercSplit.Text = progressOverallStatusSplit.Value.ToString() + "% Completed";
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
			if (!Splitter.IsBusy) return;
			long tmpVar = fileReader.BaseStream.Position - LastEstimation;
			LastEstimation = fileReader.BaseStream.Position;
			if (tmpVar >= 0) tmpVar = (((TotalSize - fileReader.BaseStream.Position) / tmpVar) * 5);
			if (tmpVar < 20) tmpVar += 6;
			txtTimeRemainingSplit.Text = GetHours(ref tmpVar) + "  (approximately)";
		}

		private void txtBufferSize_ValueChanged(object sender, EventArgs e)
		{
			BufferSize = Convert.ToInt64(txtBufferSizeSplit.Value);
		}

		private void Start()
		{
			if (lstParts.Items.Count == 0) { MessageBox.Show("Add the name and size of each part to split.", "No Parts Found"); return; }
			if (lstParts.Items.Count == 1) { MessageBox.Show("The file must be atleast splited into two parts.", "Requirement Failed"); return; }
			try
			{
				fileReader = new BinaryReader(File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None));
			}
			catch (FileNotFoundException) { MessageBox.Show("The specified source file to split was not found. Please select an existing file.", "File Not Found"); return; }
			catch { MessageBox.Show("The selected source file could not be accessed. It might be either blocked by some other process. Stop all the process using the file and then try again.", "Error"); return; }

			TotalFile = lstParts.Items.Count;
			FileLocationArr = new string[TotalFile];
			FileSizeArr = new long[TotalFile];
			StartByteArr = new long[TotalFile];
			EndByteArr = new long[TotalFile];
			BufferSize = Convert.ToInt64(txtBufferSizeSplit.Value);
			for (int i = 0; i < TotalFile; i++)
			{
				FileLocationArr[i] = lstParts.Items[i].SubItems[0].Text;
				FileSizeArr[i] = Convert.ToInt64(lstParts.Items[i].SubItems[1].Text);
				StartByteArr[i] = Convert.ToInt64(lstParts.Items[i].SubItems[2].Text);
				EndByteArr[i] = Convert.ToInt64(lstParts.Items[i].SubItems[3].Text);
			}

			Generate_InfoFile();
			Splitter.RunWorkerAsync();
			btnStartSplit.Enabled = false;
			btnStopSplit.Enabled = true;

			panelStatusSplit.Visible = true;
			ProgressorSplit.Enabled = true;
			LastEstimation = fileReader.BaseStream.Position;
			TimeEstimater.Enabled = true;

			txtTimeRemainingSplit.Text = "Started, Processing...";
		}

		void btnStop_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to end the process?", "Confirm End Process", MessageBoxButtons.YesNo) == DialogResult.No) return;
			btnStopSplit.Enabled = false;
			Canceled = true;
		}

		private void Merge_Click(object sender, EventArgs e)
		{
			if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then try again."); return; }
			mergeToolStripMenuItem.Visible = false;
			splitterToolStripMenuItem.Visible = true;
			panelMerge.Visible = true;
			panelSplit.Visible = false;

		}

		#region Worker - Spliting

		void Generate_InfoFile()
		{
			Directory.CreateDirectory(txtPartNameSplit.Text.Substring(0, txtPartNameSplit.Text.LastIndexOf("\\")));
			FileStream FS = new FileStream(txtPartNameSplit.Text + ".000" , FileMode.Create, FileAccess.Write);
			BinaryWriter BW = new BinaryWriter(FS);

			BW.Write(Convert.ToInt16(666));// Specify it as spliter Project
			BW.Write(Path.GetFileName(txtSourceFileSplit.Text).Length);
			BW.Write(Path.GetFileName(txtSourceFileSplit.Text).ToCharArray());
			BW.Write(TotalSize); // Total size of the current file

			BW.Write(SourceByte); // Write the bytes of the source file.            
			BW.Write(BufferSize); // Size of the buffer
			BW.Write(CurrentFileIndex); // Index of current file processing.
			BW.Write(TotalFile); // Total no of parts to be splited.

			foreach (ListViewItem Item in lstParts.Items)
			{
				BW.Write(Path.GetFileName(Item.SubItems[0].Text).Length);
				BW.Write(Path.GetFileName(Item.SubItems[0].Text).ToCharArray());
				BW.Write(Convert.ToInt64(Item.SubItems[1].Text));
				BW.Write(Convert.ToInt64(Item.SubItems[2].Text));
				BW.Write(Convert.ToInt64(Item.SubItems[3].Text));
			}
			BW.Flush(); BW.Close(); BW = null; FS.Close(); FS = null;
		}

		void SplitFile(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			long tmpEndByte;
			long tmpReadByte;
			CurrentFileIndex = 0;
			startTime = DateTime.Now.Second;

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
				fileWriter = new FileStream(FileLocationArr[CurrentFileIndex], FileMode.Append, FileAccess.Write, FileShare.None);

				// Set the position of the reader.
				fileReader.BaseStream.Position = StartByteArr[CurrentFileIndex] - 1 + fileWriter.Length;

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
					fileWriter.Write(Data, 0, Data.Length);
					if (Canceled) return;
				}

				// Add completed file when completed.
				CurrentFileIndex++;
				fileWriter.Flush(); fileWriter.Close();
			}
		}

		void SplitingCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if (Canceled) MessageBox.Show("The process had been canceled by the user. Click Start button to resume it again.", "Process Canceled");
			else
			{
				txtFileProcessingSplit.Text = "File " + Convert.ToString(CurrentFileIndex + 1) + " / " + TotalFile.ToString();

				progressCurrentFileSplit.Value = 100;
				txtCurrentFileByteSplit.Text = lstParts.Items[lstParts.Items.Count - 1].SubItems[3].Text + " Bytes";
				txtCurrentFilePrecSplit.Text = "100% Completed";

				progressOverallStatusSplit.Value = 100;
				txtOverallFileByteSplit.Text = txtTotalSizeSplit.Text + " Bytes";
				txtOverallPercSplit.Text = "100% Completed";
			}

			Generate_InfoFile();
			ProgressorSplit.Enabled = false;
			TimeEstimater.Enabled = false;
			txtTimeRemainingSplit.Text = "Estimating... Please Wait";

			try { fileWriter.Close(); fileWriter = null; }
			catch { }

			fileReader.Close(); fileReader = null;

			btnStartSplit.Enabled = true;
			btnStopSplit.Enabled = false;
			panelStatusSplit.Visible = false;
			Canceled = false;
			long seconds = ((long)DateTime.Now.Second - startTime);
			MessageBox.Show("Split complet " + GetHours(ref seconds));
		}
		#endregion

		#endregion

		#region Merge

		private void btnBrowseMerge_Click(object sender, EventArgs e)
		{
			if (StartedMerged) { MessageBox.Show("You cannot perform this action after started to merge the file. Stop the process if running."); return; }
			if (Merge.IsBusy) { MessageBox.Show("First stop the current process and then try again."); }
			OpenFileDialog OFD = new OpenFileDialog();
			OFD.CheckFileExists = true;
			if (OFD.ShowDialog() == DialogResult.Cancel) return;
			//ClearAll();
			OpenProject(OFD.FileName);
		}

		private void btnBrowseFileMerge_Click(object sender, EventArgs e)
		{
			if (Merge.IsBusy) { MessageBox.Show("First stop the current process and then proceed."); return; }
			SaveFileDialog SFD = new SaveFileDialog();
			SFD.CheckPathExists = true;
			if (SFD.ShowDialog() == DialogResult.Cancel) return;
			txtFileNameMerge.Text = SFD.FileName;
		}
		
		private void Splitter_Click(object sender, EventArgs e)
		{
			if (Merge.IsBusy) { MessageBox.Show("First stop the current process and then try again."); return; }
			splitterToolStripMenuItem.Visible = false;
			mergeToolStripMenuItem.Visible = true; 
			panelMerge.Visible = false;
			panelSplit.Visible = true;

		}

		private void ProgressChangedMerge(object sender, EventArgs e)
		{

			if (!Merge.IsBusy) return;
			try
			{
				txtFileProcessingMerge.Text = "File " + Convert.ToString(CurrentFileIndex + 1) + " / " + TotalFile.ToString();

				progressCurrentFileMerge.Value = Convert.ToInt32((inputFile.Length * 100) / FileSizeArr[CurrentFileIndex]);
				txtCurrentFileByteMerge.Text = inputFile.Length + " Bytes";
				txtCurrentFilePrecMerge.Text = progressCurrentFileMerge.Value.ToString() + "% Completed";

				progressOverallStatusMerge.Value = Convert.ToInt32((outputFile.Position * 100) / TotalSize);
				txtOverallFileByteMerge.Text = outputFile.Position.ToString() + " Bytes";
				txtOverallPercMerge.Text = progressOverallStatusMerge.Value.ToString() + "% Completed";
			}
			catch { }

		}

		bool OpenProject(String fileInfo)
		{
			string pathFile = Path.GetDirectoryName(fileInfo);

			FileStream FS = new FileStream(fileInfo, FileMode.Open, FileAccess.Read);
			BinaryReader BR = new BinaryReader(FS);

			if (BR.ReadInt16() != 666) { MessageBox.Show("The selected file is not a valid Splitter file.", "Invalid File"); return false; }

			int tmpChrs = BR.ReadInt32(); // specify the length of the source file.
			string fileName = new string(BR.ReadChars(tmpChrs));    // get name of the source file.
			txtFileNameMerge.Text = pathFile + @"\" + fileName;

			TotalSize = BR.ReadInt64(); // Total size of the current file
			txtTotalSizeMerge.Text = TotalSize.ToString();

			// Get start and end bytes of old source file.
			SourceByte = BR.ReadBytes(30);

			//FileStream SrcStr;
		//CheckForFile:
			//try
			//{
			//    SrcStr = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			//}
			//catch (FileNotFoundException)
			//{
			//    if (MessageBox.Show("The source file \"" + fileName + "\" could not be found.  Do you want to select the source file manually?", "File Not Found", MessageBoxButtons.YesNo) == DialogResult.No) return false;
			//    fileName = GetOpenSource();
			//    if (fileName == "") return false; goto CheckForFile;
			//}
			//catch
			//{
			//    if (MessageBox.Show("The source file \"" + fileName + "\" cannot be accessed. It may be used by some other process. Close all the other applications using the file and then click Ok", "Access Denied", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return false;
			//    goto CheckForFile;
			//}

			//if (SrcStr.Length != TotalSize)
			//{
			//    if (MessageBox.Show("The source file \"" + fileName + "\" is not a valid source file related to this project. The size of the file difer. Do you want to select the source file related to the project manualy?", "Invalid Source File", MessageBoxButtons.YesNo) == DialogResult.No) return false;
			//    SrcStr.Close(); SrcStr = null;
			//    fileName = GetOpenSource();
			//    if (fileName == "") return false;
			//    goto CheckForFile;
			//}

			//byte[] tmpSourceBytes = new byte[30];

			// Get start and end bytes of selected file.
			//SrcStr.Read(tmpSourceBytes, 0, 10);

			//SrcStr.Position = (SrcStr.Length / 2) - 5;
			//SrcStr.Read(tmpSourceBytes, 10, 10);

			//SrcStr.Position = SrcStr.Length - 10;
			//SrcStr.Read(tmpSourceBytes, 20, 10);

			// Check for start and end bytes
			//for (int a = 0; a < 30; a++)
			//{
			//    if (tmpSourceBytes[a] == SourceByte[a]) continue;
			//    DialogResult DR = MessageBox.Show("The source file \"" + fileName + "\" is not a valid source file related to this project. Do you want to select the source file related to the project manualy?", "Invalid Source File", MessageBoxButtons.YesNo);
			//    if (DR == DialogResult.No) return false;
			//    SrcStr.Close(); SrcStr = null;
			//    fileName = GetOpenSource();
			//    if (fileName == "") return false;
			//    goto CheckForFile;
			//}

			//SrcStr.Close(); SrcStr = null; // Close the source stream in use.

			BufferSize = BR.ReadInt64(); // Size of the buffer
			txtBufferSizeMerge.Value = BufferSize;

			CurrentFileIndex = BR.ReadInt32(); // Index of current file processing.
			TotalFile = BR.ReadInt32(); // Total no of parts to be splited.
			if (CurrentFileIndex != TotalFile) { MessageBox.Show("Fail in split files.", "Invalid File"); return false; }

			lblPartMerge.Items.Clear();
			for (int i = 0; i < TotalFile; i++)
			{
				string filePart = pathFile + @"\" + new String(BR.ReadChars(BR.ReadInt32()));
				lblPartMerge.Items.Add(new ListViewItem(new string[] { "", filePart, BR.ReadInt64().ToString(), BR.ReadInt64().ToString(), BR.ReadInt64().ToString() }));
				lblPartMerge.Items[i].ImageIndex = (File.Exists(filePart) == true ? 0 : 1);
			}

			BR.Close(); BR = null;
			FS.Close(); FS = null;
			txtSourceFileMerge.Text = fileInfo;
			panelButtonsMerge.Visible = true;
			return true;
		}

		private void btnStartMerge_Click(object sender, EventArgs e)
		{

			FileLocationArr = new string[TotalFile];
			FileSizeArr = new long[TotalFile];

			for (int i = 0; i < TotalFile; i++)
			{
				FileLocationArr[i] = lblPartMerge.Items[i].SubItems[1].Text;
				FileSizeArr[i] = Convert.ToInt64(lblPartMerge.Items[i].SubItems[2].Text);
			}

			Merge.RunWorkerAsync();
			btnStartMerge.Enabled = false;

			panelStatusMerge.Visible = true;
			ProgressorMerge.Enabled = true;
			//LastEstimation = fileReader.BaseStream.Position;
			//TimeEstimater.Enabled = true;

			txtTimeRemainingMerge.Text = "Started, Processing...";
		}

		private void MergeFiles(object sender, DoWorkEventArgs e)
		{
			startTime = DateTime.Now.Second;
			using (outputFile = File.OpenWrite(txtFileNameMerge.Text))
			{
				CurrentFileIndex = 0;
				foreach (string partName in FileLocationArr)
				{
					using (inputFile = File.OpenRead(partName))
					{
						inputFile.CopyTo(outputFile);
					}
					CurrentFileIndex++;
				}
			}

		}

		private void MergingCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnStartMerge.Enabled = true;

			txtFileProcessingMerge.Text = "File " + Convert.ToString(CurrentFileIndex) + " / " + TotalFile.ToString();

			progressCurrentFileMerge.Value = 100;
			txtCurrentFileByteMerge.Text = lblPartMerge.Items[lblPartMerge.Items.Count - 1].SubItems[4].Text + " Bytes";
			txtCurrentFilePrecMerge.Text = "100% Completed";

			progressOverallStatusMerge.Value = 100;
			txtOverallFileByteMerge.Text = txtTotalSizeMerge.Text + " Bytes";
			txtOverallPercMerge.Text = "100% Completed";

			long seconds = ((long)DateTime.Now.Second - startTime);
			MessageBox.Show("Split complet " + GetHours(ref seconds));
		}
		
		#endregion

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new About().Show();
		}

	}
}
