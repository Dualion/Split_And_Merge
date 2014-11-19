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
            this.txtSourceFileSplit = new System.Windows.Forms.TextBox();
            this.lblSourceFileSplit = new System.Windows.Forms.Label();
            this.btnBrowseSplit = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBrowseSplit = new System.Windows.Forms.Panel();
            this.panelButtonsSplit = new System.Windows.Forms.Panel();
            this.gBoxSelParts = new System.Windows.Forms.GroupBox();
            this.rButtonNParts = new System.Windows.Forms.RadioButton();
            this.rButtonSParts = new System.Windows.Forms.RadioButton();
            this.lblPieces = new System.Windows.Forms.Label();
            this.lblTotalSizeSplit = new System.Windows.Forms.Label();
            this.btnBrowsePartSplit = new System.Windows.Forms.Button();
            this.txtTotalSizeSplit = new System.Windows.Forms.TextBox();
            this.lblNumParts = new System.Windows.Forms.Label();
            this.lblBufferSizeSplit = new System.Windows.Forms.Label();
            this.lblPartNameSplit = new System.Windows.Forms.Label();
            this.txtPartSize = new System.Windows.Forms.NumericUpDown();
            this.txtNumParts = new System.Windows.Forms.NumericUpDown();
            this.txtBufferSizeSplit = new System.Windows.Forms.NumericUpDown();
            this.btnStopSplit = new System.Windows.Forms.Button();
            this.txtPartNameSplit = new System.Windows.Forms.TextBox();
            this.btnStartSplit = new System.Windows.Forms.Button();
            this.lblPartSize = new System.Windows.Forms.Label();
            this.panelStatusSplit = new System.Windows.Forms.Panel();
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
            this.panelSplit = new System.Windows.Forms.Panel();
            this.panelTittleSplit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMerge = new System.Windows.Forms.Panel();
            this.panelButtonsMerge = new System.Windows.Forms.Panel();
            this.btnStartMerge = new System.Windows.Forms.Button();
            this.btnStopMerge = new System.Windows.Forms.Button();
            this.btnBrowseFileMerge = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileNameMerge = new System.Windows.Forms.TextBox();
            this.lblPartMerge = new System.Windows.Forms.ListView();
            this.Exist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartByte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndByte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblBufferSizeMerge = new System.Windows.Forms.Label();
            this.txtBufferSizeMerge = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalSizeMerge = new System.Windows.Forms.Label();
            this.txtTotalSizeMerge = new System.Windows.Forms.TextBox();
            this.panelBrowseMerge = new System.Windows.Forms.Panel();
            this.lblSourceFileMerge = new System.Windows.Forms.Label();
            this.btnBrowseMerge = new System.Windows.Forms.Button();
            this.txtSourceFileMerge = new System.Windows.Forms.TextBox();
            this.panelTitleMerge = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelStatusMerge = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Merge = new System.ComponentModel.BackgroundWorker();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.panelBrowseSplit.SuspendLayout();
            this.panelButtonsSplit.SuspendLayout();
            this.gBoxSelParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBufferSizeSplit)).BeginInit();
            this.panelStatusSplit.SuspendLayout();
            this.panelSplit.SuspendLayout();
            this.panelTittleSplit.SuspendLayout();
            this.panelMerge.SuspendLayout();
            this.panelButtonsMerge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBufferSizeMerge)).BeginInit();
            this.panelBrowseMerge.SuspendLayout();
            this.panelTitleMerge.SuspendLayout();
            this.panelStatusMerge.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSourceFileSplit
            // 
            this.txtSourceFileSplit.BackColor = System.Drawing.SystemColors.Window;
            this.txtSourceFileSplit.Location = new System.Drawing.Point(72, 8);
            this.txtSourceFileSplit.Name = "txtSourceFileSplit";
            this.txtSourceFileSplit.ReadOnly = true;
            this.txtSourceFileSplit.Size = new System.Drawing.Size(467, 20);
            this.txtSourceFileSplit.TabIndex = 1;
            this.txtSourceFileSplit.TabStop = false;
            this.txtSourceFileSplit.Click += new System.EventHandler(this.BrowseSource_Click);
            // 
            // lblSourceFileSplit
            // 
            this.lblSourceFileSplit.AutoSize = true;
            this.lblSourceFileSplit.Location = new System.Drawing.Point(6, 11);
            this.lblSourceFileSplit.Margin = new System.Windows.Forms.Padding(0);
            this.lblSourceFileSplit.Name = "lblSourceFileSplit";
            this.lblSourceFileSplit.Size = new System.Drawing.Size(60, 13);
            this.lblSourceFileSplit.TabIndex = 2;
            this.lblSourceFileSplit.Text = "Source File";
            // 
            // btnBrowseSplit
            // 
            this.btnBrowseSplit.Location = new System.Drawing.Point(569, 6);
            this.btnBrowseSplit.Name = "btnBrowseSplit";
            this.btnBrowseSplit.Size = new System.Drawing.Size(87, 23);
            this.btnBrowseSplit.TabIndex = 3;
            this.btnBrowseSplit.Text = "Browse";
            this.btnBrowseSplit.UseVisualStyleBackColor = true;
            this.btnBrowseSplit.Click += new System.EventHandler(this.BrowseSource_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mergeToolStripMenuItem,
            this.splitterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(678, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
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
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mergeToolStripMenuItem.Text = "Merge";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.Merge_Click);
            // 
            // splitterToolStripMenuItem
            // 
            this.splitterToolStripMenuItem.Name = "splitterToolStripMenuItem";
            this.splitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.splitterToolStripMenuItem.Text = "Splitter";
            this.splitterToolStripMenuItem.Visible = false;
            this.splitterToolStripMenuItem.Click += new System.EventHandler(this.Splitter_Click);
            // 
            // panelBrowseSplit
            // 
            this.panelBrowseSplit.Controls.Add(this.lblSourceFileSplit);
            this.panelBrowseSplit.Controls.Add(this.btnBrowseSplit);
            this.panelBrowseSplit.Controls.Add(this.txtSourceFileSplit);
            this.panelBrowseSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBrowseSplit.Location = new System.Drawing.Point(0, 23);
            this.panelBrowseSplit.Name = "panelBrowseSplit";
            this.panelBrowseSplit.Size = new System.Drawing.Size(678, 38);
            this.panelBrowseSplit.TabIndex = 5;
            // 
            // panelButtonsSplit
            // 
            this.panelButtonsSplit.Controls.Add(this.gBoxSelParts);
            this.panelButtonsSplit.Controls.Add(this.lblPieces);
            this.panelButtonsSplit.Controls.Add(this.lblTotalSizeSplit);
            this.panelButtonsSplit.Controls.Add(this.btnBrowsePartSplit);
            this.panelButtonsSplit.Controls.Add(this.txtTotalSizeSplit);
            this.panelButtonsSplit.Controls.Add(this.lblNumParts);
            this.panelButtonsSplit.Controls.Add(this.lblBufferSizeSplit);
            this.panelButtonsSplit.Controls.Add(this.lblPartNameSplit);
            this.panelButtonsSplit.Controls.Add(this.txtPartSize);
            this.panelButtonsSplit.Controls.Add(this.txtNumParts);
            this.panelButtonsSplit.Controls.Add(this.txtBufferSizeSplit);
            this.panelButtonsSplit.Controls.Add(this.btnStopSplit);
            this.panelButtonsSplit.Controls.Add(this.txtPartNameSplit);
            this.panelButtonsSplit.Controls.Add(this.btnStartSplit);
            this.panelButtonsSplit.Controls.Add(this.lblPartSize);
            this.panelButtonsSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonsSplit.Location = new System.Drawing.Point(0, 61);
            this.panelButtonsSplit.Name = "panelButtonsSplit";
            this.panelButtonsSplit.Size = new System.Drawing.Size(678, 140);
            this.panelButtonsSplit.TabIndex = 6;
            this.panelButtonsSplit.Visible = false;
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
            this.lblPieces.Size = new System.Drawing.Size(678, 23);
            this.lblPieces.TabIndex = 37;
            this.lblPieces.Text = "Info File";
            this.lblPieces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSizeSplit
            // 
            this.lblTotalSizeSplit.AutoSize = true;
            this.lblTotalSizeSplit.Location = new System.Drawing.Point(6, 29);
            this.lblTotalSizeSplit.Name = "lblTotalSizeSplit";
            this.lblTotalSizeSplit.Size = new System.Drawing.Size(54, 13);
            this.lblTotalSizeSplit.TabIndex = 24;
            this.lblTotalSizeSplit.Text = "Total Size";
            // 
            // btnBrowsePartSplit
            // 
            this.btnBrowsePartSplit.Location = new System.Drawing.Point(483, 55);
            this.btnBrowsePartSplit.Name = "btnBrowsePartSplit";
            this.btnBrowsePartSplit.Size = new System.Drawing.Size(56, 20);
            this.btnBrowsePartSplit.TabIndex = 33;
            this.btnBrowsePartSplit.Text = "&Browse";
            this.btnBrowsePartSplit.UseVisualStyleBackColor = true;
            this.btnBrowsePartSplit.Click += new System.EventHandler(this.BrowsePart_Click);
            // 
            // txtTotalSizeSplit
            // 
            this.txtTotalSizeSplit.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalSizeSplit.Location = new System.Drawing.Point(72, 26);
            this.txtTotalSizeSplit.Name = "txtTotalSizeSplit";
            this.txtTotalSizeSplit.ReadOnly = true;
            this.txtTotalSizeSplit.Size = new System.Drawing.Size(165, 20);
            this.txtTotalSizeSplit.TabIndex = 25;
            this.txtTotalSizeSplit.TabStop = false;
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
            // lblBufferSizeSplit
            // 
            this.lblBufferSizeSplit.AutoSize = true;
            this.lblBufferSizeSplit.Location = new System.Drawing.Point(264, 29);
            this.lblBufferSizeSplit.Name = "lblBufferSizeSplit";
            this.lblBufferSizeSplit.Size = new System.Drawing.Size(58, 13);
            this.lblBufferSizeSplit.TabIndex = 31;
            this.lblBufferSizeSplit.Text = "Buffer Size";
            // 
            // lblPartNameSplit
            // 
            this.lblPartNameSplit.AutoSize = true;
            this.lblPartNameSplit.Location = new System.Drawing.Point(6, 58);
            this.lblPartNameSplit.Name = "lblPartNameSplit";
            this.lblPartNameSplit.Size = new System.Drawing.Size(57, 13);
            this.lblPartNameSplit.TabIndex = 28;
            this.lblPartNameSplit.Text = "Part Name";
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
            // txtBufferSizeSplit
            // 
            this.txtBufferSizeSplit.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtBufferSizeSplit.Location = new System.Drawing.Point(330, 26);
            this.txtBufferSizeSplit.Maximum = new decimal(new int[] {
            90000000,
            0,
            0,
            0});
            this.txtBufferSizeSplit.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.txtBufferSizeSplit.Name = "txtBufferSizeSplit";
            this.txtBufferSizeSplit.Size = new System.Drawing.Size(147, 20);
            this.txtBufferSizeSplit.TabIndex = 32;
            this.txtBufferSizeSplit.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtBufferSizeSplit.ValueChanged += new System.EventHandler(this.txtBufferSize_ValueChanged);
            // 
            // btnStopSplit
            // 
            this.btnStopSplit.BackColor = System.Drawing.Color.Red;
            this.btnStopSplit.Enabled = false;
            this.btnStopSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopSplit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStopSplit.Location = new System.Drawing.Point(569, 95);
            this.btnStopSplit.Name = "btnStopSplit";
            this.btnStopSplit.Size = new System.Drawing.Size(87, 35);
            this.btnStopSplit.TabIndex = 36;
            this.btnStopSplit.Text = "Stop";
            this.btnStopSplit.UseVisualStyleBackColor = false;
            this.btnStopSplit.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtPartNameSplit
            // 
            this.txtPartNameSplit.BackColor = System.Drawing.SystemColors.Window;
            this.txtPartNameSplit.Location = new System.Drawing.Point(72, 55);
            this.txtPartNameSplit.Name = "txtPartNameSplit";
            this.txtPartNameSplit.ReadOnly = true;
            this.txtPartNameSplit.Size = new System.Drawing.Size(405, 20);
            this.txtPartNameSplit.TabIndex = 29;
            this.txtPartNameSplit.Click += new System.EventHandler(this.BrowsePart_Click);
            // 
            // btnStartSplit
            // 
            this.btnStartSplit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnStartSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSplit.ForeColor = System.Drawing.Color.Blue;
            this.btnStartSplit.Location = new System.Drawing.Point(570, 31);
            this.btnStartSplit.Name = "btnStartSplit";
            this.btnStartSplit.Size = new System.Drawing.Size(87, 59);
            this.btnStartSplit.TabIndex = 35;
            this.btnStartSplit.Text = "Start";
            this.btnStartSplit.UseVisualStyleBackColor = false;
            this.btnStartSplit.Click += new System.EventHandler(this.btnStart_Click);
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
            // panelStatusSplit
            // 
            this.panelStatusSplit.Controls.Add(this.txtOverallFileByte);
            this.panelStatusSplit.Controls.Add(this.lblProcessingOL);
            this.panelStatusSplit.Controls.Add(this.txtCurrentFileByte);
            this.panelStatusSplit.Controls.Add(this.lblProcessingCF);
            this.panelStatusSplit.Controls.Add(this.txtFileProcessing);
            this.panelStatusSplit.Controls.Add(this.lblProcessing);
            this.panelStatusSplit.Controls.Add(this.progressOverallStatus);
            this.panelStatusSplit.Controls.Add(this.progressCurrentFile);
            this.panelStatusSplit.Controls.Add(this.txtOverallPerc);
            this.panelStatusSplit.Controls.Add(this.txtCurrentFilePrec);
            this.panelStatusSplit.Controls.Add(this.txtTimeRemaining);
            this.panelStatusSplit.Controls.Add(this.lblOverallStatus);
            this.panelStatusSplit.Controls.Add(this.lblCurrentFile);
            this.panelStatusSplit.Controls.Add(this.lblRemainingTime);
            this.panelStatusSplit.Controls.Add(this.lblBottomHeader);
            this.panelStatusSplit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatusSplit.Location = new System.Drawing.Point(0, 201);
            this.panelStatusSplit.Name = "panelStatusSplit";
            this.panelStatusSplit.Size = new System.Drawing.Size(678, 124);
            this.panelStatusSplit.TabIndex = 7;
            this.panelStatusSplit.Visible = false;
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
            this.lblBottomHeader.Size = new System.Drawing.Size(678, 23);
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
            // panelSplit
            // 
            this.panelSplit.Controls.Add(this.panelButtonsSplit);
            this.panelSplit.Controls.Add(this.panelBrowseSplit);
            this.panelSplit.Controls.Add(this.panelTittleSplit);
            this.panelSplit.Controls.Add(this.panelStatusSplit);
            this.panelSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSplit.Location = new System.Drawing.Point(0, 24);
            this.panelSplit.Name = "panelSplit";
            this.panelSplit.Size = new System.Drawing.Size(678, 325);
            this.panelSplit.TabIndex = 8;
            // 
            // panelTittleSplit
            // 
            this.panelTittleSplit.Controls.Add(this.label1);
            this.panelTittleSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleSplit.Location = new System.Drawing.Point(0, 0);
            this.panelTittleSplit.Name = "panelTittleSplit";
            this.panelTittleSplit.Size = new System.Drawing.Size(678, 23);
            this.panelTittleSplit.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Splitter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMerge
            // 
            this.panelMerge.Controls.Add(this.panelButtonsMerge);
            this.panelMerge.Controls.Add(this.panelBrowseMerge);
            this.panelMerge.Controls.Add(this.panelTitleMerge);
            this.panelMerge.Controls.Add(this.panelStatusMerge);
            this.panelMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMerge.Location = new System.Drawing.Point(0, 24);
            this.panelMerge.Name = "panelMerge";
            this.panelMerge.Size = new System.Drawing.Size(678, 325);
            this.panelMerge.TabIndex = 9;
            this.panelMerge.Visible = false;
            // 
            // panelButtonsMerge
            // 
            this.panelButtonsMerge.Controls.Add(this.btnStartMerge);
            this.panelButtonsMerge.Controls.Add(this.btnStopMerge);
            this.panelButtonsMerge.Controls.Add(this.btnBrowseFileMerge);
            this.panelButtonsMerge.Controls.Add(this.lblFileName);
            this.panelButtonsMerge.Controls.Add(this.txtFileNameMerge);
            this.panelButtonsMerge.Controls.Add(this.lblPartMerge);
            this.panelButtonsMerge.Controls.Add(this.lblBufferSizeMerge);
            this.panelButtonsMerge.Controls.Add(this.txtBufferSizeMerge);
            this.panelButtonsMerge.Controls.Add(this.label2);
            this.panelButtonsMerge.Controls.Add(this.lblTotalSizeMerge);
            this.panelButtonsMerge.Controls.Add(this.txtTotalSizeMerge);
            this.panelButtonsMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonsMerge.Location = new System.Drawing.Point(0, 61);
            this.panelButtonsMerge.Name = "panelButtonsMerge";
            this.panelButtonsMerge.Size = new System.Drawing.Size(678, 264);
            this.panelButtonsMerge.TabIndex = 39;
            this.panelButtonsMerge.Visible = false;
            // 
            // btnStartMerge
            // 
            this.btnStartMerge.BackColor = System.Drawing.Color.GreenYellow;
            this.btnStartMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMerge.ForeColor = System.Drawing.Color.Blue;
            this.btnStartMerge.Location = new System.Drawing.Point(483, 208);
            this.btnStartMerge.Name = "btnStartMerge";
            this.btnStartMerge.Size = new System.Drawing.Size(87, 45);
            this.btnStartMerge.TabIndex = 40;
            this.btnStartMerge.Text = "Start";
            this.btnStartMerge.UseVisualStyleBackColor = false;
            this.btnStartMerge.Click += new System.EventHandler(this.btnStartMerge_Click);
            // 
            // btnStopMerge
            // 
            this.btnStopMerge.BackColor = System.Drawing.Color.Red;
            this.btnStopMerge.Enabled = false;
            this.btnStopMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopMerge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStopMerge.Location = new System.Drawing.Point(576, 214);
            this.btnStopMerge.Name = "btnStopMerge";
            this.btnStopMerge.Size = new System.Drawing.Size(87, 35);
            this.btnStopMerge.TabIndex = 41;
            this.btnStopMerge.Text = "Stop";
            this.btnStopMerge.UseVisualStyleBackColor = false;
            this.btnStopMerge.Visible = false;
            // 
            // btnBrowseFileMerge
            // 
            this.btnBrowseFileMerge.Location = new System.Drawing.Point(421, 208);
            this.btnBrowseFileMerge.Name = "btnBrowseFileMerge";
            this.btnBrowseFileMerge.Size = new System.Drawing.Size(56, 20);
            this.btnBrowseFileMerge.TabIndex = 46;
            this.btnBrowseFileMerge.Text = "&Browse";
            this.btnBrowseFileMerge.UseVisualStyleBackColor = true;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 211);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(54, 13);
            this.lblFileName.TabIndex = 44;
            this.lblFileName.Text = "File Name";
            // 
            // txtFileNameMerge
            // 
            this.txtFileNameMerge.BackColor = System.Drawing.SystemColors.Window;
            this.txtFileNameMerge.Location = new System.Drawing.Point(72, 208);
            this.txtFileNameMerge.Name = "txtFileNameMerge";
            this.txtFileNameMerge.ReadOnly = true;
            this.txtFileNameMerge.Size = new System.Drawing.Size(343, 20);
            this.txtFileNameMerge.TabIndex = 45;
            // 
            // lblPartMerge
            // 
            this.lblPartMerge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Exist,
            this.FileName,
            this.PartSize,
            this.StartByte,
            this.EndByte});
            this.lblPartMerge.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPartMerge.Location = new System.Drawing.Point(0, 23);
            this.lblPartMerge.Name = "lblPartMerge";
            this.lblPartMerge.Size = new System.Drawing.Size(678, 178);
            this.lblPartMerge.SmallImageList = this.imageList1;
            this.lblPartMerge.TabIndex = 43;
            this.lblPartMerge.UseCompatibleStateImageBehavior = false;
            this.lblPartMerge.View = System.Windows.Forms.View.Details;
            // 
            // Exist
            // 
            this.Exist.Text = "Exist";
            this.Exist.Width = 41;
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 333;
            // 
            // PartSize
            // 
            this.PartSize.Text = "Part Size";
            this.PartSize.Width = 100;
            // 
            // StartByte
            // 
            this.StartByte.Text = "Start Byte";
            this.StartByte.Width = 100;
            // 
            // EndByte
            // 
            this.EndByte.Text = "End Byte";
            this.EndByte.Width = 100;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "accept.png");
            this.imageList1.Images.SetKeyName(1, "cancel.png");
            // 
            // lblBufferSizeMerge
            // 
            this.lblBufferSizeMerge.AutoSize = true;
            this.lblBufferSizeMerge.Location = new System.Drawing.Point(264, 236);
            this.lblBufferSizeMerge.Name = "lblBufferSizeMerge";
            this.lblBufferSizeMerge.Size = new System.Drawing.Size(58, 13);
            this.lblBufferSizeMerge.TabIndex = 41;
            this.lblBufferSizeMerge.Text = "Buffer Size";
            this.lblBufferSizeMerge.Visible = false;
            // 
            // txtBufferSizeMerge
            // 
            this.txtBufferSizeMerge.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtBufferSizeMerge.Location = new System.Drawing.Point(330, 233);
            this.txtBufferSizeMerge.Maximum = new decimal(new int[] {
            90000000,
            0,
            0,
            0});
            this.txtBufferSizeMerge.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.txtBufferSizeMerge.Name = "txtBufferSizeMerge";
            this.txtBufferSizeMerge.Size = new System.Drawing.Size(147, 20);
            this.txtBufferSizeMerge.TabIndex = 42;
            this.txtBufferSizeMerge.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtBufferSizeMerge.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(678, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Info File";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSizeMerge
            // 
            this.lblTotalSizeMerge.AutoSize = true;
            this.lblTotalSizeMerge.Location = new System.Drawing.Point(6, 236);
            this.lblTotalSizeMerge.Name = "lblTotalSizeMerge";
            this.lblTotalSizeMerge.Size = new System.Drawing.Size(54, 13);
            this.lblTotalSizeMerge.TabIndex = 38;
            this.lblTotalSizeMerge.Text = "Total Size";
            // 
            // txtTotalSizeMerge
            // 
            this.txtTotalSizeMerge.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalSizeMerge.Location = new System.Drawing.Point(72, 233);
            this.txtTotalSizeMerge.Name = "txtTotalSizeMerge";
            this.txtTotalSizeMerge.ReadOnly = true;
            this.txtTotalSizeMerge.Size = new System.Drawing.Size(165, 20);
            this.txtTotalSizeMerge.TabIndex = 39;
            this.txtTotalSizeMerge.TabStop = false;
            // 
            // panelBrowseMerge
            // 
            this.panelBrowseMerge.Controls.Add(this.lblSourceFileMerge);
            this.panelBrowseMerge.Controls.Add(this.btnBrowseMerge);
            this.panelBrowseMerge.Controls.Add(this.txtSourceFileMerge);
            this.panelBrowseMerge.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBrowseMerge.Location = new System.Drawing.Point(0, 23);
            this.panelBrowseMerge.Name = "panelBrowseMerge";
            this.panelBrowseMerge.Size = new System.Drawing.Size(678, 38);
            this.panelBrowseMerge.TabIndex = 6;
            // 
            // lblSourceFileMerge
            // 
            this.lblSourceFileMerge.AutoSize = true;
            this.lblSourceFileMerge.Location = new System.Drawing.Point(6, 11);
            this.lblSourceFileMerge.Margin = new System.Windows.Forms.Padding(0);
            this.lblSourceFileMerge.Name = "lblSourceFileMerge";
            this.lblSourceFileMerge.Size = new System.Drawing.Size(60, 13);
            this.lblSourceFileMerge.TabIndex = 2;
            this.lblSourceFileMerge.Text = "Source File";
            // 
            // btnBrowseMerge
            // 
            this.btnBrowseMerge.Location = new System.Drawing.Point(569, 6);
            this.btnBrowseMerge.Name = "btnBrowseMerge";
            this.btnBrowseMerge.Size = new System.Drawing.Size(87, 23);
            this.btnBrowseMerge.TabIndex = 3;
            this.btnBrowseMerge.Text = "Browse";
            this.btnBrowseMerge.UseVisualStyleBackColor = true;
            this.btnBrowseMerge.Click += new System.EventHandler(this.btnBrowseMerge_Click);
            // 
            // txtSourceFileMerge
            // 
            this.txtSourceFileMerge.BackColor = System.Drawing.SystemColors.Window;
            this.txtSourceFileMerge.Location = new System.Drawing.Point(72, 8);
            this.txtSourceFileMerge.Name = "txtSourceFileMerge";
            this.txtSourceFileMerge.ReadOnly = true;
            this.txtSourceFileMerge.Size = new System.Drawing.Size(467, 20);
            this.txtSourceFileMerge.TabIndex = 1;
            this.txtSourceFileMerge.TabStop = false;
            // 
            // panelTitleMerge
            // 
            this.panelTitleMerge.Controls.Add(this.label3);
            this.panelTitleMerge.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleMerge.Location = new System.Drawing.Point(0, 0);
            this.panelTitleMerge.Name = "panelTitleMerge";
            this.panelTitleMerge.Size = new System.Drawing.Size(678, 23);
            this.panelTitleMerge.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(678, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Merge";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelStatusMerge
            // 
            this.panelStatusMerge.Controls.Add(this.label4);
            this.panelStatusMerge.Controls.Add(this.label5);
            this.panelStatusMerge.Controls.Add(this.label6);
            this.panelStatusMerge.Controls.Add(this.label7);
            this.panelStatusMerge.Controls.Add(this.label8);
            this.panelStatusMerge.Controls.Add(this.label9);
            this.panelStatusMerge.Controls.Add(this.progressBar1);
            this.panelStatusMerge.Controls.Add(this.progressBar2);
            this.panelStatusMerge.Controls.Add(this.label10);
            this.panelStatusMerge.Controls.Add(this.label11);
            this.panelStatusMerge.Controls.Add(this.label12);
            this.panelStatusMerge.Controls.Add(this.label13);
            this.panelStatusMerge.Controls.Add(this.label14);
            this.panelStatusMerge.Controls.Add(this.label15);
            this.panelStatusMerge.Controls.Add(this.label16);
            this.panelStatusMerge.Location = new System.Drawing.Point(0, 205);
            this.panelStatusMerge.Name = "panelStatusMerge";
            this.panelStatusMerge.Size = new System.Drawing.Size(678, 121);
            this.panelStatusMerge.TabIndex = 40;
            this.panelStatusMerge.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "0 Bytes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Processed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "0 Bytes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Processed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "File 0 / 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Processing";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(90, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(90, 55);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(200, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "0% Completed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "0% Completed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Estimating... Please Wait";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Overall Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Current File";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Remaining";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.Info;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(678, 23);
            this.label16.TabIndex = 15;
            this.label16.Text = "Spliting Status";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Merge
            // 
            this.Merge.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MergeFiles);
            this.Merge.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MergingCompleted);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Split
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 349);
            this.Controls.Add(this.panelSplit);
            this.Controls.Add(this.panelMerge);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Split";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split and Merge";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.panelBrowseSplit.ResumeLayout(false);
            this.panelBrowseSplit.PerformLayout();
            this.panelButtonsSplit.ResumeLayout(false);
            this.panelButtonsSplit.PerformLayout();
            this.gBoxSelParts.ResumeLayout(false);
            this.gBoxSelParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBufferSizeSplit)).EndInit();
            this.panelStatusSplit.ResumeLayout(false);
            this.panelStatusSplit.PerformLayout();
            this.panelSplit.ResumeLayout(false);
            this.panelTittleSplit.ResumeLayout(false);
            this.panelMerge.ResumeLayout(false);
            this.panelButtonsMerge.ResumeLayout(false);
            this.panelButtonsMerge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBufferSizeMerge)).EndInit();
            this.panelBrowseMerge.ResumeLayout(false);
            this.panelBrowseMerge.PerformLayout();
            this.panelTitleMerge.ResumeLayout(false);
            this.panelStatusMerge.ResumeLayout(false);
            this.panelStatusMerge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceFileSplit;
        private System.Windows.Forms.Label lblSourceFileSplit;
        private System.Windows.Forms.Button btnBrowseSplit;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem itmExit;
        private System.Windows.Forms.Panel panelBrowseSplit;
        private System.Windows.Forms.Panel panelButtonsSplit;
        private System.Windows.Forms.Label lblTotalSizeSplit;
        private System.Windows.Forms.Button btnBrowsePartSplit;
        private System.Windows.Forms.TextBox txtTotalSizeSplit;
        private System.Windows.Forms.Label lblNumParts;
        private System.Windows.Forms.Label lblBufferSizeSplit;
        private System.Windows.Forms.Label lblPartNameSplit;
        private System.Windows.Forms.NumericUpDown txtBufferSizeSplit;
        private System.Windows.Forms.Button btnStopSplit;
        private System.Windows.Forms.TextBox txtPartNameSplit;
        private System.Windows.Forms.Button btnStartSplit;
        private System.Windows.Forms.Label lblPartSize;
        private System.Windows.Forms.Panel panelStatusSplit;
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
		private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
		private System.Windows.Forms.Panel panelSplit;
		private System.Windows.Forms.Panel panelTittleSplit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelMerge;
		private System.Windows.Forms.Panel panelTitleMerge;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panelBrowseMerge;
		private System.Windows.Forms.Label lblSourceFileMerge;
		private System.Windows.Forms.Button btnBrowseMerge;
		private System.Windows.Forms.TextBox txtSourceFileMerge;
        private System.ComponentModel.BackgroundWorker Merge;
        private System.Windows.Forms.ToolStripMenuItem splitterToolStripMenuItem;
        private System.Windows.Forms.Panel panelButtonsMerge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalSizeMerge;
        private System.Windows.Forms.TextBox txtTotalSizeMerge;
        private System.Windows.Forms.Label lblBufferSizeMerge;
        private System.Windows.Forms.NumericUpDown txtBufferSizeMerge;
        private System.Windows.Forms.ListView lblPartMerge;
        private System.Windows.Forms.Button btnBrowseFileMerge;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileNameMerge;
        private System.Windows.Forms.Button btnStartMerge;
        private System.Windows.Forms.Button btnStopMerge;
        private System.Windows.Forms.ColumnHeader Exist;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader PartSize;
        private System.Windows.Forms.ColumnHeader StartByte;
        private System.Windows.Forms.ColumnHeader EndByte;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelStatusMerge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

