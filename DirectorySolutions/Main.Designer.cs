using System.IO;

namespace DirectorySolutions
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.countLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sizeLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sortedBy = new System.Windows.Forms.ToolStripStatusLabel();
            this.sortedByLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameFilesAfterPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDisplayByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateModifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImportFile = new System.Windows.Forms.OpenFileDialog();
            this.openExportFile = new System.Windows.Forms.OpenFileDialog();
            this.filePathErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.displayGrid = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tooltipFreshDir = new System.Windows.Forms.ToolTip(this.components);
            this.instructionLbl = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.saveDir = new System.Windows.Forms.RadioButton();
            this.freshDir = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picInfoFreshDir = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.appendListRad = new System.Windows.Forms.RadioButton();
            this.freshListRad = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.fileOpenList = new System.Windows.Forms.ListBox();
            this.btnClearFileList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePathErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoFreshDir)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.countLbl,
            this.sizeLbl,
            this.sortedBy,
            this.sortedByLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1245, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Ready";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // countLbl
            // 
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(39, 17);
            this.countLbl.Text = "0 Files";
            // 
            // sizeLbl
            // 
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(44, 17);
            this.sizeLbl.Text = "0 Bytes";
            // 
            // sortedBy
            // 
            this.sortedBy.Name = "sortedBy";
            this.sortedBy.Size = new System.Drawing.Size(60, 17);
            this.sortedBy.Text = "Sorted By:";
            // 
            // sortedByLbl
            // 
            this.sortedByLbl.Name = "sortedByLbl";
            this.sortedByLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fileOperationsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Open Results In Excel";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // fileOperationsToolStripMenuItem
            // 
            this.fileOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchAndReplaceToolStripMenuItem,
            this.nameFilesAfterPathToolStripMenuItem,
            this.movieManagementToolStripMenuItem});
            this.fileOperationsToolStripMenuItem.Name = "fileOperationsToolStripMenuItem";
            this.fileOperationsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.fileOperationsToolStripMenuItem.Text = "File Operations";
            // 
            // searchAndReplaceToolStripMenuItem
            // 
            this.searchAndReplaceToolStripMenuItem.Name = "searchAndReplaceToolStripMenuItem";
            this.searchAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.searchAndReplaceToolStripMenuItem.Text = "Search and Replace";
            this.searchAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.searchAndReplaceToolStripMenuItem_Click);
            // 
            // nameFilesAfterPathToolStripMenuItem
            // 
            this.nameFilesAfterPathToolStripMenuItem.Name = "nameFilesAfterPathToolStripMenuItem";
            this.nameFilesAfterPathToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.nameFilesAfterPathToolStripMenuItem.Text = "Name Files After Path";
            this.nameFilesAfterPathToolStripMenuItem.Click += new System.EventHandler(this.nameFilesAfterPathToolStripMenuItem_Click);
            // 
            // movieManagementToolStripMenuItem
            // 
            this.movieManagementToolStripMenuItem.Name = "movieManagementToolStripMenuItem";
            this.movieManagementToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.movieManagementToolStripMenuItem.Text = "Movie Management";
            this.movieManagementToolStripMenuItem.Click += new System.EventHandler(this.movieManagementToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortDisplayByToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sortDisplayByToolStripMenuItem
            // 
            this.sortDisplayByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.dateModifiedToolStripMenuItem,
            this.nameToolStripMenuItem});
            this.sortDisplayByToolStripMenuItem.Name = "sortDisplayByToolStripMenuItem";
            this.sortDisplayByToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortDisplayByToolStripMenuItem.Text = "Sort Display By";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // dateModifiedToolStripMenuItem
            // 
            this.dateModifiedToolStripMenuItem.Name = "dateModifiedToolStripMenuItem";
            this.dateModifiedToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dateModifiedToolStripMenuItem.Text = "Date Modified";
            this.dateModifiedToolStripMenuItem.Click += new System.EventHandler(this.dateModifiedToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // openImportFile
            // 
            this.openImportFile.FileName = "openImportFile";
            // 
            // openExportFile
            // 
            this.openExportFile.FileName = "openExportFile";
            // 
            // filePathErrorProv
            // 
            this.filePathErrorProv.ContainerControl = this;
            // 
            // displayGrid
            // 
            this.displayGrid.AllowUserToAddRows = false;
            this.displayGrid.AllowUserToDeleteRows = false;
            this.displayGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.displayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.displayGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.displayGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.displayGrid.Location = new System.Drawing.Point(0, 314);
            this.displayGrid.Name = "displayGrid";
            this.displayGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.displayGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.displayGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.displayGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayGrid.Size = new System.Drawing.Size(1245, 259);
            this.displayGrid.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tooltipFreshDir
            // 
            this.tooltipFreshDir.AutoPopDelay = 10000;
            this.tooltipFreshDir.InitialDelay = 500;
            this.tooltipFreshDir.IsBalloon = true;
            this.tooltipFreshDir.ReshowDelay = 100;
            // 
            // instructionLbl
            // 
            this.instructionLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.instructionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.instructionLbl.Location = new System.Drawing.Point(249, 4);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(684, 25);
            this.instructionLbl.TabIndex = 6;
            this.instructionLbl.Text = "Please select a directory or file(s) to get started.";
            this.instructionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(123, 57);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(188, 57);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(56, 23);
            this.btnForward.TabIndex = 9;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(288, 60);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(481, 20);
            this.filePath.TabIndex = 10;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.AccessibleName = "btnOpenDir";
            this.btnOpenDir.Location = new System.Drawing.Point(799, 58);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(142, 23);
            this.btnOpenDir.TabIndex = 11;
            this.btnOpenDir.Text = "Open Directory";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(250, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Path:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 96);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1221, 146);
            this.webBrowser1.TabIndex = 13;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // saveDir
            // 
            this.saveDir.AutoSize = true;
            this.saveDir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.saveDir.Location = new System.Drawing.Point(959, 61);
            this.saveDir.Name = "saveDir";
            this.saveDir.Size = new System.Drawing.Size(106, 17);
            this.saveDir.TabIndex = 14;
            this.saveDir.TabStop = true;
            this.saveDir.Text = "Save Directory(s)";
            this.saveDir.UseVisualStyleBackColor = false;
            // 
            // freshDir
            // 
            this.freshDir.AutoSize = true;
            this.freshDir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.freshDir.Location = new System.Drawing.Point(1071, 61);
            this.freshDir.Name = "freshDir";
            this.freshDir.Size = new System.Drawing.Size(96, 17);
            this.freshDir.TabIndex = 15;
            this.freshDir.TabStop = true;
            this.freshDir.Text = "Fresh Directory";
            this.freshDir.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(42, 58);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picInfoFreshDir
            // 
            this.picInfoFreshDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picInfoFreshDir.Image = global::DirectorySolutions.Properties.Resources.StatusHelp_16x;
            this.picInfoFreshDir.InitialImage = global::DirectorySolutions.Properties.Resources.Question_16x;
            this.picInfoFreshDir.Location = new System.Drawing.Point(1173, 61);
            this.picInfoFreshDir.Name = "picInfoFreshDir";
            this.picInfoFreshDir.Size = new System.Drawing.Size(21, 17);
            this.picInfoFreshDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInfoFreshDir.TabIndex = 17;
            this.picInfoFreshDir.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(600, 251);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 19;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add File(s):";
            // 
            // appendListRad
            // 
            this.appendListRad.AutoSize = true;
            this.appendListRad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.appendListRad.Location = new System.Drawing.Point(1048, 254);
            this.appendListRad.Name = "appendListRad";
            this.appendListRad.Size = new System.Drawing.Size(97, 17);
            this.appendListRad.TabIndex = 21;
            this.appendListRad.TabStop = true;
            this.appendListRad.Text = "Append To List";
            this.appendListRad.UseVisualStyleBackColor = false;
            // 
            // freshListRad
            // 
            this.freshListRad.AutoSize = true;
            this.freshListRad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.freshListRad.Location = new System.Drawing.Point(1160, 254);
            this.freshListRad.Name = "freshListRad";
            this.freshListRad.Size = new System.Drawing.Size(70, 17);
            this.freshListRad.TabIndex = 22;
            this.freshListRad.TabStop = true;
            this.freshListRad.Text = "Fresh List";
            this.freshListRad.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(874, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = " NOTE: Drag and drop enable";
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(681, 251);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(75, 23);
            this.btnAddFiles.TabIndex = 24;
            this.btnAddFiles.Text = "Add";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // fileOpenList
            // 
            this.fileOpenList.AllowDrop = true;
            this.fileOpenList.FormattingEnabled = true;
            this.fileOpenList.Location = new System.Drawing.Point(86, 251);
            this.fileOpenList.Name = "fileOpenList";
            this.fileOpenList.Size = new System.Drawing.Size(491, 30);
            this.fileOpenList.TabIndex = 25;
            // 
            // btnClearFileList
            // 
            this.btnClearFileList.Location = new System.Drawing.Point(762, 251);
            this.btnClearFileList.Name = "btnClearFileList";
            this.btnClearFileList.Size = new System.Drawing.Size(75, 23);
            this.btnClearFileList.TabIndex = 26;
            this.btnClearFileList.Text = "Clear";
            this.btnClearFileList.UseVisualStyleBackColor = true;
            this.btnClearFileList.Click += new System.EventHandler(this.btnClearFileList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.instructionLbl);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 269);
            this.panel1.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 595);
            this.Controls.Add(this.btnClearFileList);
            this.Controls.Add(this.fileOpenList);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.freshListRad);
            this.Controls.Add(this.appendListRad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.picInfoFreshDir);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.freshDir);
            this.Controls.Add(this.saveDir);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.displayGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DirectorySolutions";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePathErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoFreshDir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortDisplayByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateModifiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImportFile;
        private System.Windows.Forms.OpenFileDialog openExportFile;
        private System.Windows.Forms.ToolStripStatusLabel countLbl;
        private System.Windows.Forms.ToolStripStatusLabel sizeLbl;
        private System.Windows.Forms.ErrorProvider filePathErrorProv;
        private System.Windows.Forms.ToolStripStatusLabel sortedBy;
        private System.Windows.Forms.ToolStripStatusLabel sortedByLbl;
        private System.Windows.Forms.ToolStripMenuItem nameFilesAfterPathToolStripMenuItem;
        private System.Windows.Forms.DataGridView displayGrid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem movieManagementToolStripMenuItem;
        private System.Windows.Forms.ToolTip tooltipFreshDir;
        private System.Windows.Forms.Button btnClearFileList;
        private System.Windows.Forms.ListBox fileOpenList;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton freshListRad;
        private System.Windows.Forms.RadioButton appendListRad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.PictureBox picInfoFreshDir;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton freshDir;
        private System.Windows.Forms.RadioButton saveDir;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.Panel panel1;
    }
}