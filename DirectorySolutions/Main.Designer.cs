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
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.display = new System.Windows.Forms.RichTextBox();
            this.findAndReplaceControls = new DirectorySolutions.FindAndReplaceControls();
            this.directorySelectionControls = new DirectorySolutions.DirectorySelection();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(990, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Ready";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
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
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
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
            this.searchAndReplaceToolStripMenuItem});
            this.fileOperationsToolStripMenuItem.Name = "fileOperationsToolStripMenuItem";
            this.fileOperationsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.fileOperationsToolStripMenuItem.Text = "File Operations";
            // 
            // searchAndReplaceToolStripMenuItem
            // 
            this.searchAndReplaceToolStripMenuItem.Name = "searchAndReplaceToolStripMenuItem";
            this.searchAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchAndReplaceToolStripMenuItem.Text = "Search and Replace";
            this.searchAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.searchAndReplaceToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 302);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(951, 239);
            this.display.TabIndex = 3;
            this.display.Text = "";
            // 
            // findAndReplaceControls1
            // 
            this.findAndReplaceControls.Location = new System.Drawing.Point(33, 250);
            this.findAndReplaceControls.Name = "findAndReplaceControls1";
            this.findAndReplaceControls.Size = new System.Drawing.Size(900, 46);
            this.findAndReplaceControls.TabIndex = 4;
            this.findAndReplaceControls.Hide();
            // 
            // directorySelectionControls
            // 
            this.directorySelectionControls.Location = new System.Drawing.Point(12, 36);
            this.directorySelectionControls.Name = "directorySelectionControls";
            this.directorySelectionControls.Size = new System.Drawing.Size(954, 203);
            this.directorySelectionControls.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 600);
            this.Controls.Add(this.findAndReplaceControls);
            this.Controls.Add(this.display);
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
            this.ResumeLayout(false);
            this.PerformLayout();
            this.directorySelectionControls.FilePathChanged += DirectorySelectionControls_FilePathChanged;

        }

        private void DirectorySelectionControls_FilePathChanged(object sender, System.EventArgs e)
        {
            var path = directorySelectionControls.Controls.Find("filePath", true)[0].Text;
            if (Directory.Exists(path))
            {
                UpdateDisplay(path);
            }
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
        private System.Windows.Forms.RichTextBox display;
        private FindAndReplaceControls findAndReplaceControls;
    }
}