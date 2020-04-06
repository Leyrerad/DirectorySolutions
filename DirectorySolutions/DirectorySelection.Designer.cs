namespace DirectorySolutions
{
    partial class DirectorySelection
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.openImportFile = new System.Windows.Forms.OpenFileDialog();
            this.openExportFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(68, 7);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(56, 23);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(168, 10);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(481, 20);
            this.filePath.TabIndex = 2;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.AccessibleName = "btnOpenDir";
            this.btnOpenDir.Location = new System.Drawing.Point(655, 8);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(216, 23);
            this.btnOpenDir.TabIndex = 3;
            this.btnOpenDir.Text = "Open Directory";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 37);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(946, 146);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // openImportFile
            // 
            this.openImportFile.FileName = "openImportFile";
            // 
            // openExportFile
            // 
            this.openExportFile.FileName = "openExportFile";
            // 
            // DirectorySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Name = "DirectorySelection";
            this.Size = new System.Drawing.Size(960, 203);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.OpenFileDialog openImportFile;
        private System.Windows.Forms.OpenFileDialog openExportFile;
    }
}

