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
            this.fileImportLbl = new System.Windows.Forms.Label();
            this.fileImportTxt = new System.Windows.Forms.TextBox();
            this.fileExportLbl = new System.Windows.Forms.Label();
            this.fileExportTxt = new System.Windows.Forms.TextBox();
            this.btnFileExport = new System.Windows.Forms.Button();
            this.btnFileImport = new System.Windows.Forms.Button();
            this.openImportFile = new System.Windows.Forms.OpenFileDialog();
            this.openExportFile = new System.Windows.Forms.OpenFileDialog();
            this.display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(74, 30);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(56, 23);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(174, 33);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(481, 20);
            this.filePath.TabIndex = 2;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.AccessibleName = "btnOpenDir";
            this.btnOpenDir.Location = new System.Drawing.Point(661, 31);
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
            this.label1.Location = new System.Drawing.Point(136, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(9, 60);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(946, 146);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // fileImportLbl
            // 
            this.fileImportLbl.AutoSize = true;
            this.fileImportLbl.Location = new System.Drawing.Point(9, 233);
            this.fileImportLbl.Name = "fileImportLbl";
            this.fileImportLbl.Size = new System.Drawing.Size(83, 13);
            this.fileImportLbl.TabIndex = 6;
            this.fileImportLbl.Text = "File Import Path:";
            this.fileImportLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // fileImportTxt
            // 
            this.fileImportTxt.Location = new System.Drawing.Point(100, 229);
            this.fileImportTxt.Name = "fileImportTxt";
            this.fileImportTxt.Size = new System.Drawing.Size(282, 20);
            this.fileImportTxt.TabIndex = 7;
            // 
            // fileExportLbl
            // 
            this.fileExportLbl.AutoSize = true;
            this.fileExportLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileExportLbl.Location = new System.Drawing.Point(502, 233);
            this.fileExportLbl.Name = "fileExportLbl";
            this.fileExportLbl.Size = new System.Drawing.Size(84, 13);
            this.fileExportLbl.TabIndex = 9;
            this.fileExportLbl.Text = "File Export Path:";
            // 
            // fileExportTxt
            // 
            this.fileExportTxt.Location = new System.Drawing.Point(592, 230);
            this.fileExportTxt.Name = "fileExportTxt";
            this.fileExportTxt.Size = new System.Drawing.Size(282, 20);
            this.fileExportTxt.TabIndex = 10;
            // 
            // btnFileExport
            // 
            this.btnFileExport.Location = new System.Drawing.Point(880, 227);
            this.btnFileExport.Name = "btnFileExport";
            this.btnFileExport.Size = new System.Drawing.Size(75, 23);
            this.btnFileExport.TabIndex = 11;
            this.btnFileExport.Text = "Select";
            this.btnFileExport.UseVisualStyleBackColor = true;
            this.btnFileExport.Click += new System.EventHandler(this.btnFileExport_Click);
            // 
            // btnFileImport
            // 
            this.btnFileImport.Location = new System.Drawing.Point(388, 226);
            this.btnFileImport.Name = "btnFileImport";
            this.btnFileImport.Size = new System.Drawing.Size(75, 23);
            this.btnFileImport.TabIndex = 8;
            this.btnFileImport.Text = "Select";
            this.btnFileImport.UseVisualStyleBackColor = true;
            this.btnFileImport.Click += new System.EventHandler(this.btnFileImport_Click);
            // 
            // openImportFile
            // 
            this.openImportFile.FileName = "openImportFile";
            // 
            // openExportFile
            // 
            this.openExportFile.FileName = "openExportFile";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(0, 304);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(987, 242);
            this.display.TabIndex = 14;
            this.display.Text = "";
            // 
            // DirecotrySolutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 571);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btnFileExport);
            this.Controls.Add(this.fileExportTxt);
            this.Controls.Add(this.fileExportLbl);
            this.Controls.Add(this.btnFileImport);
            this.Controls.Add(this.fileImportTxt);
            this.Controls.Add(this.fileImportLbl);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Name = "DirecotrySolutions";
            this.Text = "DirectorySolutions";
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
        private System.Windows.Forms.Label fileImportLbl;
        private System.Windows.Forms.TextBox fileImportTxt;
        private System.Windows.Forms.Label fileExportLbl;
        private System.Windows.Forms.TextBox fileExportTxt;
        private System.Windows.Forms.Button btnFileExport;
        private System.Windows.Forms.Button btnFileImport;
        private System.Windows.Forms.OpenFileDialog openImportFile;
        private System.Windows.Forms.OpenFileDialog openExportFile;
        private System.Windows.Forms.RichTextBox display;
    }
}

