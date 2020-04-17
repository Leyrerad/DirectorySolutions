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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.countLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sizeLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sortedBy = new System.Windows.Forms.ToolStripStatusLabel();
            this.sortedByLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDisplayByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateModifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImportFile = new System.Windows.Forms.OpenFileDialog();
            this.openExportFile = new System.Windows.Forms.OpenFileDialog();
            this.filePathErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.displayGrid = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tooltipFreshDir = new System.Windows.Forms.ToolTip(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.btnOpenDirMain = new System.Windows.Forms.Button();
            this.fastPathMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.appendListRad = new System.Windows.Forms.RadioButton();
            this.freshListRad = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.fileOpenList = new System.Windows.Forms.ListBox();
            this.btnClearFileList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileToolSetsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnMoveCopyDelete = new System.Windows.Forms.Button();
            this.btnMovieManagement = new System.Windows.Forms.Button();
            this.btnFindandReplace = new System.Windows.Forms.Button();
            this.btnFindDuplicates = new System.Windows.Forms.Button();
            this.btnNameFilesForPath = new System.Windows.Forms.Button();
            this.btnFilterFiles = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.fileToolsPanel = new System.Windows.Forms.Panel();
            this.tipsPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainTipLbl = new System.Windows.Forms.Label();
            this.btnMoreTips = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.file = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.directoryListLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePathErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fileToolSetsLayout.SuspendLayout();
            this.fileToolsPanel.SuspendLayout();
            this.tipsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.file.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 769);
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
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            this.saveFileListToolStripMenuItem,
            this.openFileListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveToolStripMenuItem.Text = "Open Display In Excel";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveFileListToolStripMenuItem
            // 
            this.saveFileListToolStripMenuItem.Name = "saveFileListToolStripMenuItem";
            this.saveFileListToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveFileListToolStripMenuItem.Text = "Save File List";
            this.saveFileListToolStripMenuItem.Click += new System.EventHandler(this.saveFileListToolStripMenuItem_Click);
            // 
            // openFileListToolStripMenuItem
            // 
            this.openFileListToolStripMenuItem.Name = "openFileListToolStripMenuItem";
            this.openFileListToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openFileListToolStripMenuItem.Text = "Open File List";
            this.openFileListToolStripMenuItem.Click += new System.EventHandler(this.openFileListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            this.displayGrid.Location = new System.Drawing.Point(3, 35);
            this.displayGrid.Name = "displayGrid";
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
            this.displayGrid.Size = new System.Drawing.Size(1242, 238);
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(97, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(157, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(56, 23);
            this.btnForward.TabIndex = 9;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(290, 3);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(480, 20);
            this.filePath.TabIndex = 10;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // btnOpenDirMain
            // 
            this.btnOpenDirMain.AccessibleName = "btnOpenDir";
            this.btnOpenDirMain.ContextMenuStrip = this.fastPathMenuStrip;
            this.btnOpenDirMain.Location = new System.Drawing.Point(776, 3);
            this.btnOpenDirMain.Name = "btnOpenDirMain";
            this.btnOpenDirMain.Size = new System.Drawing.Size(142, 23);
            this.btnOpenDirMain.TabIndex = 11;
            this.btnOpenDirMain.Text = "Open Directory";
            this.btnOpenDirMain.UseVisualStyleBackColor = true;
            this.btnOpenDirMain.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // fastPathMenuStrip
            // 
            this.fastPathMenuStrip.Name = "fastPathMenuStrip";
            this.fastPathMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(240, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Path:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(379, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(71, 23);
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
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Manually Add File(s):";
            // 
            // appendListRad
            // 
            this.appendListRad.AutoSize = true;
            this.appendListRad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.appendListRad.Location = new System.Drawing.Point(761, 3);
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
            this.freshListRad.Location = new System.Drawing.Point(864, 3);
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
            this.label3.Location = new System.Drawing.Point(598, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(155, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = " NOTE: Drag and drop enabled in   the \"Add File(s)\" text box.";
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(456, 3);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(63, 23);
            this.btnAddFiles.TabIndex = 24;
            this.btnAddFiles.Text = "Add";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // fileOpenList
            // 
            this.fileOpenList.AllowDrop = true;
            this.fileOpenList.FormattingEnabled = true;
            this.fileOpenList.Location = new System.Drawing.Point(130, 3);
            this.fileOpenList.Name = "fileOpenList";
            this.fileOpenList.Size = new System.Drawing.Size(243, 30);
            this.fileOpenList.TabIndex = 25;
            // 
            // btnClearFileList
            // 
            this.btnClearFileList.Location = new System.Drawing.Point(525, 3);
            this.btnClearFileList.Name = "btnClearFileList";
            this.btnClearFileList.Size = new System.Drawing.Size(67, 23);
            this.btnClearFileList.TabIndex = 26;
            this.btnClearFileList.Text = "Clear";
            this.btnClearFileList.UseVisualStyleBackColor = true;
            this.btnClearFileList.Click += new System.EventHandler(this.btnClearFileList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(1242, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "File List Display";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.displayGrid);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 493);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1245, 276);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1242, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Double click a row to view/edit the file contents.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1251, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "label6";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 486F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Controls.Add(this.btnOpenDirMain, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnForward, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.filePath, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 38);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77309F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.22691F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fileOpenList, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOpenFile, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddFiles, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.freshListRad, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.appendListRad, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClearFileList, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(942, 40);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.middlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middlePanel.Controls.Add(this.panel1);
            this.middlePanel.Controls.Add(this.fileToolsPanel);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.middlePanel.Location = new System.Drawing.Point(0, 228);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Padding = new System.Windows.Forms.Padding(3);
            this.middlePanel.Size = new System.Drawing.Size(1245, 198);
            this.middlePanel.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.fileToolSetsLayout);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(221, 184);
            this.panel1.TabIndex = 2;
            // 
            // fileToolSetsLayout
            // 
            this.fileToolSetsLayout.AutoScroll = true;
            this.fileToolSetsLayout.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.fileToolSetsLayout.ColumnCount = 1;
            this.fileToolSetsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileToolSetsLayout.Controls.Add(this.btnMoveCopyDelete, 0, 6);
            this.fileToolSetsLayout.Controls.Add(this.btnMovieManagement, 0, 5);
            this.fileToolSetsLayout.Controls.Add(this.btnFindandReplace, 0, 4);
            this.fileToolSetsLayout.Controls.Add(this.btnFindDuplicates, 0, 3);
            this.fileToolSetsLayout.Controls.Add(this.btnNameFilesForPath, 0, 2);
            this.fileToolSetsLayout.Controls.Add(this.btnFilterFiles, 0, 1);
            this.fileToolSetsLayout.Controls.Add(this.label9, 0, 0);
            this.fileToolSetsLayout.Location = new System.Drawing.Point(4, 3);
            this.fileToolSetsLayout.Name = "fileToolSetsLayout";
            this.fileToolSetsLayout.RowCount = 7;
            this.fileToolSetsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.fileToolSetsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.fileToolSetsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.fileToolSetsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.fileToolSetsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.fileToolSetsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.fileToolSetsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.fileToolSetsLayout.Size = new System.Drawing.Size(197, 207);
            this.fileToolSetsLayout.TabIndex = 0;
            // 
            // btnMoveCopyDelete
            // 
            this.btnMoveCopyDelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnMoveCopyDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveCopyDelete.Location = new System.Drawing.Point(3, 179);
            this.btnMoveCopyDelete.Name = "btnMoveCopyDelete";
            this.btnMoveCopyDelete.Size = new System.Drawing.Size(191, 25);
            this.btnMoveCopyDelete.TabIndex = 7;
            this.btnMoveCopyDelete.Text = "Move, Copy, Delete";
            this.btnMoveCopyDelete.UseVisualStyleBackColor = false;
            this.btnMoveCopyDelete.Click += new System.EventHandler(this.btnMoveCopyDelete_Click);
            // 
            // btnMovieManagement
            // 
            this.btnMovieManagement.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnMovieManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMovieManagement.Location = new System.Drawing.Point(3, 150);
            this.btnMovieManagement.Name = "btnMovieManagement";
            this.btnMovieManagement.Size = new System.Drawing.Size(191, 23);
            this.btnMovieManagement.TabIndex = 5;
            this.btnMovieManagement.Text = "Movie Management";
            this.btnMovieManagement.UseVisualStyleBackColor = false;
            this.btnMovieManagement.Click += new System.EventHandler(this.btnMovieManagement_Click);
            // 
            // btnFindandReplace
            // 
            this.btnFindandReplace.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnFindandReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFindandReplace.Location = new System.Drawing.Point(3, 121);
            this.btnFindandReplace.Name = "btnFindandReplace";
            this.btnFindandReplace.Size = new System.Drawing.Size(191, 23);
            this.btnFindandReplace.TabIndex = 4;
            this.btnFindandReplace.Text = "Find and Replace";
            this.btnFindandReplace.UseVisualStyleBackColor = false;
            this.btnFindandReplace.Click += new System.EventHandler(this.btnFindandReplace_Click);
            // 
            // btnFindDuplicates
            // 
            this.btnFindDuplicates.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnFindDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFindDuplicates.Location = new System.Drawing.Point(3, 92);
            this.btnFindDuplicates.Name = "btnFindDuplicates";
            this.btnFindDuplicates.Size = new System.Drawing.Size(191, 23);
            this.btnFindDuplicates.TabIndex = 3;
            this.btnFindDuplicates.Text = "Find Duplicate Files";
            this.btnFindDuplicates.UseVisualStyleBackColor = false;
            this.btnFindDuplicates.Click += new System.EventHandler(this.btnFindDuplicates_Click);
            // 
            // btnNameFilesForPath
            // 
            this.btnNameFilesForPath.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNameFilesForPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNameFilesForPath.Location = new System.Drawing.Point(3, 63);
            this.btnNameFilesForPath.Name = "btnNameFilesForPath";
            this.btnNameFilesForPath.Size = new System.Drawing.Size(191, 23);
            this.btnNameFilesForPath.TabIndex = 2;
            this.btnNameFilesForPath.Text = "Name Files For Path";
            this.btnNameFilesForPath.UseVisualStyleBackColor = false;
            this.btnNameFilesForPath.Click += new System.EventHandler(this.btnNameFilesForPath_Click);
            // 
            // btnFilterFiles
            // 
            this.btnFilterFiles.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnFilterFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterFiles.Location = new System.Drawing.Point(3, 34);
            this.btnFilterFiles.Name = "btnFilterFiles";
            this.btnFilterFiles.Size = new System.Drawing.Size(191, 23);
            this.btnFilterFiles.TabIndex = 1;
            this.btnFilterFiles.Text = "File List Filtering";
            this.btnFilterFiles.UseVisualStyleBackColor = false;
            this.btnFilterFiles.Click += new System.EventHandler(this.btnFilterFiles_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 31);
            this.label9.TabIndex = 6;
            this.label9.Text = "File Tool Sets";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fileToolsPanel
            // 
            this.fileToolsPanel.AutoScroll = true;
            this.fileToolsPanel.Controls.Add(this.tipsPanel);
            this.fileToolsPanel.Location = new System.Drawing.Point(234, 6);
            this.fileToolsPanel.Name = "fileToolsPanel";
            this.fileToolsPanel.Size = new System.Drawing.Size(1010, 184);
            this.fileToolsPanel.TabIndex = 1;
            // 
            // tipsPanel
            // 
            this.tipsPanel.Controls.Add(this.panel3);
            this.tipsPanel.Controls.Add(this.btnMoreTips);
            this.tipsPanel.Controls.Add(this.pictureBox1);
            this.tipsPanel.Controls.Add(this.panel2);
            this.tipsPanel.Location = new System.Drawing.Point(3, 3);
            this.tipsPanel.Name = "tipsPanel";
            this.tipsPanel.Size = new System.Drawing.Size(1004, 178);
            this.tipsPanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mainTipLbl);
            this.panel3.Location = new System.Drawing.Point(394, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 122);
            this.panel3.TabIndex = 6;
            // 
            // mainTipLbl
            // 
            this.mainTipLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTipLbl.Location = new System.Drawing.Point(0, 0);
            this.mainTipLbl.Name = "mainTipLbl";
            this.mainTipLbl.Size = new System.Drawing.Size(162, 122);
            this.mainTipLbl.TabIndex = 0;
            this.mainTipLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMoreTips
            // 
            this.btnMoreTips.Location = new System.Drawing.Point(439, 150);
            this.btnMoreTips.Name = "btnMoreTips";
            this.btnMoreTips.Size = new System.Drawing.Size(75, 23);
            this.btnMoreTips.TabIndex = 5;
            this.btnMoreTips.Text = "More Tips";
            this.btnMoreTips.UseVisualStyleBackColor = true;
            this.btnMoreTips.Click += new System.EventHandler(this.btnMoreTips_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(84, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 167);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 167);
            this.label10.TabIndex = 0;
            this.label10.Text = "Please select a tool set from the buttons on the left to get started. These tool " +
    "sets contain controls that allow you to manipulate file and directory names and " +
    "contents on your file system.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // file
            // 
            this.file.Controls.Add(this.panel6);
            this.file.Controls.Add(this.panel4);
            this.file.Dock = System.Windows.Forms.DockStyle.Top;
            this.file.Location = new System.Drawing.Point(0, 60);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(1245, 168);
            this.file.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.webBrowser1);
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(942, 168);
            this.panel4.TabIndex = 14;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowser1.Location = new System.Drawing.Point(0, 78);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(942, 87);
            this.webBrowser1.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1245, 36);
            this.panel5.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1245, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Create Your File List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.directoryListLayout);
            this.panel6.Location = new System.Drawing.Point(943, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(302, 172);
            this.panel6.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Open a directory to add it to your directory list. Files from all \r\nyour director" +
    "ies will be included in your file list.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Directory List:";
            // 
            // directoryListLayout
            // 
            this.directoryListLayout.AutoScroll = true;
            this.directoryListLayout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.directoryListLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.directoryListLayout.Location = new System.Drawing.Point(8, 57);
            this.directoryListLayout.Name = "directoryListLayout";
            this.directoryListLayout.Size = new System.Drawing.Size(291, 108);
            this.directoryListLayout.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(755, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 791);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.file);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "File Manager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePathErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.middlePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.fileToolSetsLayout.ResumeLayout(false);
            this.fileToolsPanel.ResumeLayout(false);
            this.tipsPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.file.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView displayGrid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip tooltipFreshDir;
        private System.Windows.Forms.Button btnClearFileList;
        private System.Windows.Forms.ListBox fileOpenList;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton freshListRad;
        private System.Windows.Forms.RadioButton appendListRad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDirMain;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolStripMenuItem saveFileListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileListToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel fileToolsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel fileToolSetsLayout;
        private System.Windows.Forms.Button btnMovieManagement;
        private System.Windows.Forms.Button btnFindandReplace;
        private System.Windows.Forms.Button btnFindDuplicates;
        private System.Windows.Forms.Button btnNameFilesForPath;
        private System.Windows.Forms.Button btnFilterFiles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMoveCopyDelete;
        private System.Windows.Forms.ContextMenuStrip fastPathMenuStrip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel tipsPanel;
        private System.Windows.Forms.Button btnMoreTips;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label mainTipLbl;
        private System.Windows.Forms.Panel file;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel directoryListLayout;
        private System.Windows.Forms.Label label11;
    }
}