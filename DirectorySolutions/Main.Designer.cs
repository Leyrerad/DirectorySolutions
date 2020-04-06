using System.IO;

namespace DirectorySolutions
{
    partial class Main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAllExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDisplayByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateModifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.displayGrid = new System.Windows.Forms.DataGridView();
            this.findExtensionControls = new DirectorySolutions.FindExtension();
            this.findAndReplaceControls = new DirectorySolutions.FindAndReplaceControls();
            this.directorySelectionControls = new DirectorySolutions.DirectorySelection();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1245, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Ready";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.directoryOperationsToolStripMenuItem,
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // directoryOperationsToolStripMenuItem
            // 
            this.directoryOperationsToolStripMenuItem.Name = "directoryOperationsToolStripMenuItem";
            this.directoryOperationsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.directoryOperationsToolStripMenuItem.Text = "Directory Operations";
            // 
            // fileOperationsToolStripMenuItem
            // 
            this.fileOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchAndReplaceToolStripMenuItem,
            this.findAllExtensionsToolStripMenuItem});
            this.fileOperationsToolStripMenuItem.Name = "fileOperationsToolStripMenuItem";
            this.fileOperationsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.fileOperationsToolStripMenuItem.Text = "File Operations";
            // 
            // searchAndReplaceToolStripMenuItem
            // 
            this.searchAndReplaceToolStripMenuItem.Name = "searchAndReplaceToolStripMenuItem";
            this.searchAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.searchAndReplaceToolStripMenuItem.Text = "Search and Replace";
            this.searchAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.searchAndReplaceToolStripMenuItem_Click);
            // 
            // findAllExtensionsToolStripMenuItem
            // 
            this.findAllExtensionsToolStripMenuItem.Name = "findAllExtensionsToolStripMenuItem";
            this.findAllExtensionsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.findAllExtensionsToolStripMenuItem.Text = "Find all Extensions";
            this.findAllExtensionsToolStripMenuItem.Click += new System.EventHandler(this.findAllExtensionsToolStripMenuItem_Click);
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
            this.sortDisplayByToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortDisplayByToolStripMenuItem.Text = "Sort Display By";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // dateModifiedToolStripMenuItem
            // 
            this.dateModifiedToolStripMenuItem.Name = "dateModifiedToolStripMenuItem";
            this.dateModifiedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateModifiedToolStripMenuItem.Text = "Date Modified";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // instructionLbl
            // 
            this.instructionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.instructionLbl.Location = new System.Drawing.Point(266, 24);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(684, 23);
            this.instructionLbl.TabIndex = 6;
            this.instructionLbl.Text = "Please select a directory to get started.";
            this.instructionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // displayGrid
            // 
            this.displayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.displayGrid.Location = new System.Drawing.Point(0, 259);
            this.displayGrid.Name = "displayGrid";
            this.displayGrid.Size = new System.Drawing.Size(1245, 396);
            this.displayGrid.TabIndex = 7;
            // 
            // findExtensionControls
            // 
            this.findExtensionControls.Location = new System.Drawing.Point(334, 250);
            this.findExtensionControls.Name = "findExtensionControls";
            this.findExtensionControls.Size = new System.Drawing.Size(491, 57);
            this.findExtensionControls.TabIndex = 5;
            // 
            // findAndReplaceControls
            // 
            this.findAndReplaceControls.Location = new System.Drawing.Point(163, 250);
            this.findAndReplaceControls.Name = "findAndReplaceControls";
            this.findAndReplaceControls.Size = new System.Drawing.Size(900, 89);
            this.findAndReplaceControls.TabIndex = 4;
            // 
            // directorySelectionControls
            // 
            this.directorySelectionControls.Location = new System.Drawing.Point(146, 50);
            this.directorySelectionControls.Name = "directorySelectionControls";
            this.directorySelectionControls.Size = new System.Drawing.Size(961, 203);
            this.directorySelectionControls.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 677);
            this.Controls.Add(this.displayGrid);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.findExtensionControls);
            this.Controls.Add(this.findAndReplaceControls);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.directorySelectionControls);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "DirectorySolutions";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DirectorySelection directorySelectionControls;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private FindAndReplaceControls findAndReplaceControls;
        private System.Windows.Forms.ToolStripMenuItem findAllExtensionsToolStripMenuItem;
        private FindExtension findExtensionControls;
        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.DataGridView displayGrid;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortDisplayByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateModifiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
    }
}