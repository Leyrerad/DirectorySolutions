namespace DirectorySolutions
{
    partial class FileSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFileExport = new System.Windows.Forms.Button();
            this.fileExportTxt = new System.Windows.Forms.TextBox();
            this.fileExportLbl = new System.Windows.Forms.Label();
            this.btnFileImport = new System.Windows.Forms.Button();
            this.fileImportTxt = new System.Windows.Forms.TextBox();
            this.fileImportLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFileExport
            // 
            this.btnFileExport.Location = new System.Drawing.Point(885, 5);
            this.btnFileExport.Name = "btnFileExport";
            this.btnFileExport.Size = new System.Drawing.Size(75, 23);
            this.btnFileExport.TabIndex = 17;
            this.btnFileExport.Text = "Select";
            this.btnFileExport.UseVisualStyleBackColor = true;
            // 
            // fileExportTxt
            // 
            this.fileExportTxt.Location = new System.Drawing.Point(597, 8);
            this.fileExportTxt.Name = "fileExportTxt";
            this.fileExportTxt.Size = new System.Drawing.Size(282, 20);
            this.fileExportTxt.TabIndex = 16;
            // 
            // fileExportLbl
            // 
            this.fileExportLbl.AutoSize = true;
            this.fileExportLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileExportLbl.Location = new System.Drawing.Point(507, 11);
            this.fileExportLbl.Name = "fileExportLbl";
            this.fileExportLbl.Size = new System.Drawing.Size(84, 13);
            this.fileExportLbl.TabIndex = 15;
            this.fileExportLbl.Text = "File Export Path:";
            // 
            // btnFileImport
            // 
            this.btnFileImport.Location = new System.Drawing.Point(393, 4);
            this.btnFileImport.Name = "btnFileImport";
            this.btnFileImport.Size = new System.Drawing.Size(75, 23);
            this.btnFileImport.TabIndex = 14;
            this.btnFileImport.Text = "Select";
            this.btnFileImport.UseVisualStyleBackColor = true;
            // 
            // fileImportTxt
            // 
            this.fileImportTxt.Location = new System.Drawing.Point(105, 7);
            this.fileImportTxt.Name = "fileImportTxt";
            this.fileImportTxt.Size = new System.Drawing.Size(282, 20);
            this.fileImportTxt.TabIndex = 13;
            // 
            // fileImportLbl
            // 
            this.fileImportLbl.AutoSize = true;
            this.fileImportLbl.Location = new System.Drawing.Point(14, 11);
            this.fileImportLbl.Name = "fileImportLbl";
            this.fileImportLbl.Size = new System.Drawing.Size(83, 13);
            this.fileImportLbl.TabIndex = 12;
            this.fileImportLbl.Text = "File Import Path:";
            // 
            // FileSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFileExport);
            this.Controls.Add(this.fileExportTxt);
            this.Controls.Add(this.fileExportLbl);
            this.Controls.Add(this.btnFileImport);
            this.Controls.Add(this.fileImportTxt);
            this.Controls.Add(this.fileImportLbl);
            this.Name = "FileSelection";
            this.Size = new System.Drawing.Size(970, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileExport;
        private System.Windows.Forms.TextBox fileExportTxt;
        private System.Windows.Forms.Label fileExportLbl;
        private System.Windows.Forms.Button btnFileImport;
        private System.Windows.Forms.TextBox fileImportTxt;
        private System.Windows.Forms.Label fileImportLbl;
    }
}
