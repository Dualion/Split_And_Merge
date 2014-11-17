namespace Split_And_Merge
{
    partial class Split
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Split));
			this.txtSourceFile = new System.Windows.Forms.TextBox();
			this.lblSourceFile = new System.Windows.Forms.Label();
			this.btnBrowseSource = new System.Windows.Forms.Button();
			this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.itmExit = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.gBoxSelParts = new System.Windows.Forms.GroupBox();
			this.rButtonNParts = new System.Windows.Forms.RadioButton();
			this.rButtonSParts = new System.Windows.Forms.RadioButton();
			this.lblPieces = new System.Windows.Forms.Label();
			this.lblTotalSize = new System.Windows.Forms.Label();
			this.btnBrowsePart = new System.Windows.Forms.Button();
			this.txtTotalSize = new System.Windows.Forms.TextBox();
			this.lblNumParts = new System.Windows.Forms.Label();
			this.lblBufferSize = new System.Windows.Forms.Label();
			this.lblPartName = new System.Windows.Forms.Label();
			this.txtPartSize = new System.Windows.Forms.NumericUpDown();
			this.txtNumParts = new System.Windows.Forms.NumericUpDown();
			this.txtBufferSize = new System.Windows.Forms.NumericUpDown();
			this.btnStop = new System.Windows.Forms.Button();
			this.txtPartName = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblPartSize = new System.Windows.Forms.Label();
			this.panelStatus = new System.Windows.Forms.Panel();
			this.txtOverallFileByte = new System.Windows.Forms.Label();
			this.lblProcessingOL = new System.Windows.Forms.Label();
			this.txtCurrentFileByte = new System.Windows.Forms.Label();
			this.lblProcessingCF = new System.Windows.Forms.Label();
			this.txtFileProcessing = new System.Windows.Forms.Label();
			this.lblProcessing = new System.Windows.Forms.Label();
			this.progressOverallStatus = new System.Windows.Forms.ProgressBar();
			this.progressCurrentFile = new System.Windows.Forms.ProgressBar();
			this.txtOverallPerc = new System.Windows.Forms.Label();
			this.txtCurrentFilePrec = new System.Windows.Forms.Label();
			this.txtTimeRemaining = new System.Windows.Forms.Label();
			this.lblOverallStatus = new System.Windows.Forms.Label();
			this.lblCurrentFile = new System.Windows.Forms.Label();
			this.lblRemainingTime = new System.Windows.Forms.Label();
			this.lblBottomHeader = new System.Windows.Forms.Label();
			this.Progressor = new System.Windows.Forms.Timer(this.components);
			this.TimeEstimater = new System.Windows.Forms.Timer(this.components);
			this.Splitter = new System.ComponentModel.BackgroundWorker();
			this.MainMenuStrip.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.gBoxSelParts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPartSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumParts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBufferSize)).BeginInit();
			this.panelStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSourceFile
			// 
			this.txtSourceFile.BackColor = System.Drawing.SystemColors.Window;
			this.txtSourceFile.Location = new System.Drawing.Point(72, 8);
			this.txtSourceFile.Name = "txtSourceFile";
			this.txtSourceFile.ReadOnly = true;
			this.txtSourceFile.Size = new System.Drawing.Size(467, 20);
			this.txtSourceFile.TabIndex = 1;
			this.txtSourceFile.TabStop = false;
			this.txtSourceFile.Click += new System.EventHandler(this.BrowseSource_Click);
			// 
			// lblSourceFile
			// 
			this.lblSourceFile.AutoSize = true;
			this.lblSourceFile.Location = new System.Drawing.Point(6, 11);
			this.lblSourceFile.Margin = new System.Windows.Forms.Padding(0);
			this.lblSourceFile.Name = "lblSourceFile";
			this.lblSourceFile.Size = new System.Drawing.Size(60, 13);
			this.lblSourceFile.TabIndex = 2;
			this.lblSourceFile.Text = "Source File";
			// 
			// btnBrowseSource
			// 
			this.btnBrowseSource.Location = new System.Drawing.Point(569, 6);
			this.btnBrowseSource.Name = "btnBrowseSource";
			this.btnBrowseSource.Size = new System.Drawing.Size(87, 23);
			this.btnBrowseSource.TabIndex = 3;
			this.btnBrowseSource.Text = "Browse";
			this.btnBrowseSource.UseVisualStyleBackColor = true;
			this.btnBrowseSource.Click += new System.EventHandler(this.BrowseSource_Click);
			// 
			// MainMenuStrip
			// 
			this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
			this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip.Name = "MainMenuStrip";
			this.MainMenuStrip.Size = new System.Drawing.Size(669, 24);
			this.MainMenuStrip.TabIndex = 4;
			this.MainMenuStrip.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(37, 20);
			this.mnuFile.Text = "File";
			// 
			// itmExit
			// 
			this.itmExit.Name = "itmExit";
			this.itmExit.Size = new System.Drawing.Size(92, 22);
			this.itmExit.Text = "Exit";
			this.itmExit.ToolTipText = "Exit the application.";
			this.itmExit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblSourceFile);
			this.panel1.Controls.Add(this.btnBrowseSource);
			this.panel1.Controls.Add(this.txtSourceFile);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(669, 38);
			this.panel1.TabIndex = 5;
			// 
			// panelButtons
			// 
			this.panelButtons.Controls.Add(this.gBoxSelParts);
			this.panelButtons.Controls.Add(this.lblPieces);
			this.panelButtons.Controls.Add(this.lblTotalSize);
			this.panelButtons.Controls.Add(this.btnBrowsePart);
			this.panelButtons.Controls.Add(this.txtTotalSize);
			this.panelButtons.Controls.Add(this.lblNumParts);
			this.panelButtons.Controls.Add(this.lblBufferSize);
			this.panelButtons.Controls.Add(this.lblPartName);
			this.panelButtons.Controls.Add(this.txtPartSize);
			this.panelButtons.Controls.Add(this.txtNumParts);
			this.panelButtons.Controls.Add(this.txtBufferSize);
			this.panelButtons.Controls.Add(this.btnStop);
			this.panelButtons.Controls.Add(this.txtPartName);
			this.panelButtons.Controls.Add(this.btnStart);
			this.panelButtons.Controls.Add(this.lblPartSize);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelButtons.Location = new System.Drawing.Point(0, 62);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(669, 262);
			this.panelButtons.TabIndex = 6;
			this.panelButtons.Visible = false;
			// 
			// gBoxSelParts
			// 
			this.gBoxSelParts.Controls.Add(this.rButtonNParts);
			this.gBoxSelParts.Controls.Add(this.rButtonSParts);
			this.gBoxSelParts.Location = new System.Drawing.Point(267, 81);
			this.gBoxSelParts.Name = "gBoxSelParts";
			this.gBoxSelParts.Size = new System.Drawing.Size(112, 51);
			this.gBoxSelParts.TabIndex = 39;
			this.gBoxSelParts.TabStop = false;
			this.gBoxSelParts.Text = "Sel Parts";
			// 
			// rButtonNParts
			// 
			this.rButtonNParts.AutoSize = true;
			this.rButtonNParts.Checked = true;
			this.rButtonNParts.Location = new System.Drawing.Point(32, 14);
			this.rButtonNParts.Name = "rButtonNParts";
			this.rButtonNParts.Size = new System.Drawing.Size(77, 17);
			this.rButtonNParts.TabIndex = 38;
			this.rButtonNParts.TabStop = true;
			this.rButtonNParts.Text = "Num Parts ";
			this.rButtonNParts.UseVisualStyleBackColor = true;
			this.rButtonNParts.CheckedChanged += new System.EventHandler(this.rButton_CheckedChanged);
			// 
			// rButtonSParts
			// 
			this.rButtonSParts.AutoSize = true;
			this.rButtonSParts.Location = new System.Drawing.Point(32, 32);
			this.rButtonSParts.Name = "rButtonSParts";
			this.rButtonSParts.Size = new System.Drawing.Size(72, 17);
			this.rButtonSParts.TabIndex = 38;
			this.rButtonSParts.Text = "Size Parts";
			this.rButtonSParts.UseVisualStyleBackColor = true;
			// 
			// lblPieces
			// 
			this.lblPieces.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lblPieces.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPieces.Location = new System.Drawing.Point(0, 0);
			this.lblPieces.Name = "lblPieces";
			this.lblPieces.Size = new System.Drawing.Size(669, 23);
			this.lblPieces.TabIndex = 37;
			this.lblPieces.Text = "Info File";
			this.lblPieces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotalSize
			// 
			this.lblTotalSize.AutoSize = true;
			this.lblTotalSize.Location = new System.Drawing.Point(6, 29);
			this.lblTotalSize.Name = "lblTotalSize";
			this.lblTotalSize.Size = new System.Drawing.Size(54, 13);
			this.lblTotalSize.TabIndex = 24;
			this.lblTotalSize.Text = "Total Size";
			// 
			// btnBrowsePart
			// 
			this.btnBrowsePart.Location = new System.Drawing.Point(483, 55);
			this.btnBrowsePart.Name = "btnBrowsePart";
			this.btnBrowsePart.Size = new System.Drawing.Size(56, 20);
			this.btnBrowsePart.TabIndex = 33;
			this.btnBrowsePart.Text = "&Browse";
			this.btnBrowsePart.UseVisualStyleBackColor = true;
			this.btnBrowsePart.Click += new System.EventHandler(this.BrowsePart_Click);
			// 
			// txtTotalSize
			// 
			this.txtTotalSize.BackColor = System.Drawing.SystemColors.Window;
			this.txtTotalSize.Location = new System.Drawing.Point(72, 26);
			this.txtTotalSize.Name = "txtTotalSize";
			this.txtTotalSize.ReadOnly = true;
			this.txtTotalSize.Size = new System.Drawing.Size(165, 20);
			this.txtTotalSize.TabIndex = 25;
			this.txtTotalSize.TabStop = false;
			// 
			// lblNumParts
			// 
			this.lblNumParts.AutoSize = true;
			this.lblNumParts.Location = new System.Drawing.Point(6, 86);
			this.lblNumParts.Name = "lblNumParts";
			this.lblNumParts.Size = new System.Drawing.Size(56, 13);
			this.lblNumParts.TabIndex = 26;
			this.lblNumParts.Text = "Num Parts";
			// 
			// lblBufferSize
			// 
			this.lblBufferSize.AutoSize = true;
			this.lblBufferSize.Location = new System.Drawing.Point(264, 29);
			this.lblBufferSize.Name = "lblBufferSize";
			this.lblBufferSize.Size = new System.Drawing.Size(58, 13);
			this.lblBufferSize.TabIndex = 31;
			this.lblBufferSize.Text = "Buffer Size";
			// 
			// lblPartName
			// 
			this.lblPartName.AutoSize = true;
			this.lblPartName.Location = new System.Drawing.Point(6, 58);
			this.lblPartName.Name = "lblPartName";
			this.lblPartName.Size = new System.Drawing.Size(57, 13);
			this.lblPartName.TabIndex = 28;
			this.lblPartName.Text = "Part Name";
			// 
			// txtPartSize
			// 
			this.txtPartSize.Enabled = false;
			this.txtPartSize.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.txtPartSize.Location = new System.Drawing.Point(72, 110);
			this.txtPartSize.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
			this.txtPartSize.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
			this.txtPartSize.Name = "txtPartSize";
			this.txtPartSize.Size = new System.Drawing.Size(165, 20);
			this.txtPartSize.TabIndex = 32;
			this.txtPartSize.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.txtPartSize.ValueChanged += new System.EventHandler(this.txtPartSize_ValueChanged);
			// 
			// txtNumParts
			// 
			this.txtNumParts.Location = new System.Drawing.Point(72, 84);
			this.txtNumParts.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.txtNumParts.Name = "txtNumParts";
			this.txtNumParts.Size = new System.Drawing.Size(165, 20);
			this.txtNumParts.TabIndex = 32;
			this.txtNumParts.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.txtNumParts.ValueChanged += new System.EventHandler(this.txtNumParts_ValueChanged);
			// 
			// txtBufferSize
			// 
			this.txtBufferSize.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.txtBufferSize.Location = new System.Drawing.Point(330, 27);
			this.txtBufferSize.Maximum = new decimal(new int[] {
            90000000,
            0,
            0,
            0});
			this.txtBufferSize.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
			this.txtBufferSize.Name = "txtBufferSize";
			this.txtBufferSize.Size = new System.Drawing.Size(147, 20);
			this.txtBufferSize.TabIndex = 32;
			this.txtBufferSize.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.txtBufferSize.ValueChanged += new System.EventHandler(this.txtBufferSize_ValueChanged);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.Color.Red;
			this.btnStop.Enabled = false;
			this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnStop.Location = new System.Drawing.Point(569, 95);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(87, 35);
			this.btnStop.TabIndex = 36;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// txtPartName
			// 
			this.txtPartName.BackColor = System.Drawing.SystemColors.Window;
			this.txtPartName.Location = new System.Drawing.Point(72, 55);
			this.txtPartName.Name = "txtPartName";
			this.txtPartName.ReadOnly = true;
			this.txtPartName.Size = new System.Drawing.Size(405, 20);
			this.txtPartName.TabIndex = 29;
			this.txtPartName.Click += new System.EventHandler(this.BrowsePart_Click);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.GreenYellow;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.Color.Blue;
			this.btnStart.Location = new System.Drawing.Point(570, 31);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(87, 59);
			this.btnStart.TabIndex = 35;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblPartSize
			// 
			this.lblPartSize.AutoSize = true;
			this.lblPartSize.Location = new System.Drawing.Point(6, 113);
			this.lblPartSize.Name = "lblPartSize";
			this.lblPartSize.Size = new System.Drawing.Size(49, 13);
			this.lblPartSize.TabIndex = 30;
			this.lblPartSize.Text = "Part Size";
			// 
			// panelStatus
			// 
			this.panelStatus.Controls.Add(this.txtOverallFileByte);
			this.panelStatus.Controls.Add(this.lblProcessingOL);
			this.panelStatus.Controls.Add(this.txtCurrentFileByte);
			this.panelStatus.Controls.Add(this.lblProcessingCF);
			this.panelStatus.Controls.Add(this.txtFileProcessing);
			this.panelStatus.Controls.Add(this.lblProcessing);
			this.panelStatus.Controls.Add(this.progressOverallStatus);
			this.panelStatus.Controls.Add(this.progressCurrentFile);
			this.panelStatus.Controls.Add(this.txtOverallPerc);
			this.panelStatus.Controls.Add(this.txtCurrentFilePrec);
			this.panelStatus.Controls.Add(this.txtTimeRemaining);
			this.panelStatus.Controls.Add(this.lblOverallStatus);
			this.panelStatus.Controls.Add(this.lblCurrentFile);
			this.panelStatus.Controls.Add(this.lblRemainingTime);
			this.panelStatus.Controls.Add(this.lblBottomHeader);
			this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelStatus.Location = new System.Drawing.Point(0, 200);
			this.panelStatus.Name = "panelStatus";
			this.panelStatus.Size = new System.Drawing.Size(669, 124);
			this.panelStatus.TabIndex = 7;
			this.panelStatus.Visible = false;
			// 
			// txtOverallFileByte
			// 
			this.txtOverallFileByte.AutoSize = true;
			this.txtOverallFileByte.Location = new System.Drawing.Point(485, 93);
			this.txtOverallFileByte.Name = "txtOverallFileByte";
			this.txtOverallFileByte.Size = new System.Drawing.Size(42, 13);
			this.txtOverallFileByte.TabIndex = 1;
			this.txtOverallFileByte.Text = "0 Bytes";
			// 
			// lblProcessingOL
			// 
			this.lblProcessingOL.AutoSize = true;
			this.lblProcessingOL.Location = new System.Drawing.Point(420, 93);
			this.lblProcessingOL.Name = "lblProcessingOL";
			this.lblProcessingOL.Size = new System.Drawing.Size(57, 13);
			this.lblProcessingOL.TabIndex = 2;
			this.lblProcessingOL.Text = "Processed";
			// 
			// txtCurrentFileByte
			// 
			this.txtCurrentFileByte.AutoSize = true;
			this.txtCurrentFileByte.Location = new System.Drawing.Point(485, 60);
			this.txtCurrentFileByte.Name = "txtCurrentFileByte";
			this.txtCurrentFileByte.Size = new System.Drawing.Size(42, 13);
			this.txtCurrentFileByte.TabIndex = 3;
			this.txtCurrentFileByte.Text = "0 Bytes";
			// 
			// lblProcessingCF
			// 
			this.lblProcessingCF.AutoSize = true;
			this.lblProcessingCF.Location = new System.Drawing.Point(420, 60);
			this.lblProcessingCF.Name = "lblProcessingCF";
			this.lblProcessingCF.Size = new System.Drawing.Size(57, 13);
			this.lblProcessingCF.TabIndex = 4;
			this.lblProcessingCF.Text = "Processed";
			// 
			// txtFileProcessing
			// 
			this.txtFileProcessing.AutoSize = true;
			this.txtFileProcessing.Location = new System.Drawing.Point(485, 32);
			this.txtFileProcessing.Name = "txtFileProcessing";
			this.txtFileProcessing.Size = new System.Drawing.Size(49, 13);
			this.txtFileProcessing.TabIndex = 5;
			this.txtFileProcessing.Text = "File 0 / 0";
			// 
			// lblProcessing
			// 
			this.lblProcessing.AutoSize = true;
			this.lblProcessing.Location = new System.Drawing.Point(420, 32);
			this.lblProcessing.Name = "lblProcessing";
			this.lblProcessing.Size = new System.Drawing.Size(59, 13);
			this.lblProcessing.TabIndex = 6;
			this.lblProcessing.Text = "Processing";
			// 
			// progressOverallStatus
			// 
			this.progressOverallStatus.Location = new System.Drawing.Point(90, 88);
			this.progressOverallStatus.Name = "progressOverallStatus";
			this.progressOverallStatus.Size = new System.Drawing.Size(200, 23);
			this.progressOverallStatus.Step = 1;
			this.progressOverallStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressOverallStatus.TabIndex = 7;
			// 
			// progressCurrentFile
			// 
			this.progressCurrentFile.Location = new System.Drawing.Point(90, 55);
			this.progressCurrentFile.Name = "progressCurrentFile";
			this.progressCurrentFile.Size = new System.Drawing.Size(200, 23);
			this.progressCurrentFile.Step = 1;
			this.progressCurrentFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressCurrentFile.TabIndex = 8;
			// 
			// txtOverallPerc
			// 
			this.txtOverallPerc.AutoSize = true;
			this.txtOverallPerc.Location = new System.Drawing.Point(296, 93);
			this.txtOverallPerc.Name = "txtOverallPerc";
			this.txtOverallPerc.Size = new System.Drawing.Size(74, 13);
			this.txtOverallPerc.TabIndex = 9;
			this.txtOverallPerc.Text = "0% Completed";
			// 
			// txtCurrentFilePrec
			// 
			this.txtCurrentFilePrec.AutoSize = true;
			this.txtCurrentFilePrec.Location = new System.Drawing.Point(296, 60);
			this.txtCurrentFilePrec.Name = "txtCurrentFilePrec";
			this.txtCurrentFilePrec.Size = new System.Drawing.Size(74, 13);
			this.txtCurrentFilePrec.TabIndex = 10;
			this.txtCurrentFilePrec.Text = "0% Completed";
			// 
			// txtTimeRemaining
			// 
			this.txtTimeRemaining.AutoSize = true;
			this.txtTimeRemaining.Location = new System.Drawing.Point(87, 32);
			this.txtTimeRemaining.Name = "txtTimeRemaining";
			this.txtTimeRemaining.Size = new System.Drawing.Size(124, 13);
			this.txtTimeRemaining.TabIndex = 11;
			this.txtTimeRemaining.Text = "Estimating... Please Wait";
			// 
			// lblOverallStatus
			// 
			this.lblOverallStatus.AutoSize = true;
			this.lblOverallStatus.Location = new System.Drawing.Point(6, 93);
			this.lblOverallStatus.Name = "lblOverallStatus";
			this.lblOverallStatus.Size = new System.Drawing.Size(73, 13);
			this.lblOverallStatus.TabIndex = 12;
			this.lblOverallStatus.Text = "Overall Status";
			// 
			// lblCurrentFile
			// 
			this.lblCurrentFile.AutoSize = true;
			this.lblCurrentFile.Location = new System.Drawing.Point(6, 60);
			this.lblCurrentFile.Name = "lblCurrentFile";
			this.lblCurrentFile.Size = new System.Drawing.Size(60, 13);
			this.lblCurrentFile.TabIndex = 13;
			this.lblCurrentFile.Text = "Current File";
			// 
			// lblRemainingTime
			// 
			this.lblRemainingTime.AutoSize = true;
			this.lblRemainingTime.Location = new System.Drawing.Point(6, 32);
			this.lblRemainingTime.Name = "lblRemainingTime";
			this.lblRemainingTime.Size = new System.Drawing.Size(57, 13);
			this.lblRemainingTime.TabIndex = 14;
			this.lblRemainingTime.Text = "Remaining";
			// 
			// lblBottomHeader
			// 
			this.lblBottomHeader.BackColor = System.Drawing.SystemColors.Info;
			this.lblBottomHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblBottomHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBottomHeader.Location = new System.Drawing.Point(0, 0);
			this.lblBottomHeader.Name = "lblBottomHeader";
			this.lblBottomHeader.Size = new System.Drawing.Size(669, 23);
			this.lblBottomHeader.TabIndex = 15;
			this.lblBottomHeader.Text = "Spliting Status";
			this.lblBottomHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Progressor
			// 
			this.Progressor.Interval = 1000;
			this.Progressor.Tick += new System.EventHandler(this.ProgressChanged);
			// 
			// TimeEstimater
			// 
			this.TimeEstimater.Interval = 5000;
			this.TimeEstimater.Tick += new System.EventHandler(this.EstimateTime);
			// 
			// Splitter
			// 
			this.Splitter.WorkerSupportsCancellation = true;
			this.Splitter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SplitFile);
			this.Splitter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SplitingCompleted);
			// 
			// Split
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 324);
			this.Controls.Add(this.panelStatus);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.MainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Split";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Split and Merge - Split";
			this.MainMenuStrip.ResumeLayout(false);
			this.MainMenuStrip.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.panelButtons.PerformLayout();
			this.gBoxSelParts.ResumeLayout(false);
			this.gBoxSelParts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPartSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumParts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBufferSize)).EndInit();
			this.panelStatus.ResumeLayout(false);
			this.panelStatus.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem itmExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Button btnBrowsePart;
        private System.Windows.Forms.TextBox txtTotalSize;
        private System.Windows.Forms.Label lblNumParts;
        private System.Windows.Forms.Label lblBufferSize;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.NumericUpDown txtBufferSize;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPartSize;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblPieces;
        private System.Windows.Forms.Label txtOverallFileByte;
        private System.Windows.Forms.Label lblProcessingOL;
        private System.Windows.Forms.Label txtCurrentFileByte;
        private System.Windows.Forms.Label lblProcessingCF;
        private System.Windows.Forms.Label txtFileProcessing;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.ProgressBar progressOverallStatus;
        private System.Windows.Forms.ProgressBar progressCurrentFile;
        private System.Windows.Forms.Label txtOverallPerc;
        private System.Windows.Forms.Label txtCurrentFilePrec;
        private System.Windows.Forms.Label txtTimeRemaining;
        private System.Windows.Forms.Label lblOverallStatus;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label lblBottomHeader;
        private System.Windows.Forms.GroupBox gBoxSelParts;
        private System.Windows.Forms.RadioButton rButtonNParts;
        private System.Windows.Forms.RadioButton rButtonSParts;
        private System.Windows.Forms.NumericUpDown txtPartSize;
        private System.Windows.Forms.NumericUpDown txtNumParts;
        private System.Windows.Forms.Timer Progressor;
        private System.Windows.Forms.Timer TimeEstimater;
        private System.ComponentModel.BackgroundWorker Splitter;
    }
}

