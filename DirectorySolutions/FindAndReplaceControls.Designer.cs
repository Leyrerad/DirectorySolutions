namespace DirectorySolutions
{
    partial class FindAndReplaceControls
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
            this.components = new System.ComponentModel.Container();
            this.openImportFile = new System.Windows.Forms.OpenFileDialog();
            this.openExportFile = new System.Windows.Forms.OpenFileDialog();
            this.textInLbl = new System.Windows.Forms.Label();
            this.inTxt = new System.Windows.Forms.TextBox();
            this.txtOutLbl = new System.Windows.Forms.Label();
            this.outTxt = new System.Windows.Forms.TextBox();
            this.btnFindReplace = new System.Windows.Forms.Button();
            this.inTxtErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.outTxtErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inTxtErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTxtErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // openImportFile
            // 
            this.openImportFile.FileName = "openImportFile";
            // 
            // openExportFile
            // 
            this.openExportFile.FileName = "openExportFile";
            // 
            // textInLbl
            // 
            this.textInLbl.AutoSize = true;
            this.textInLbl.Location = new System.Drawing.Point(9, 17);
            this.textInLbl.Name = "textInLbl";
            this.textInLbl.Size = new System.Drawing.Size(43, 13);
            this.textInLbl.TabIndex = 18;
            this.textInLbl.Text = "Text In:";
            // 
            // inTxt
            // 
            this.inTxt.Location = new System.Drawing.Point(58, 14);
            this.inTxt.Name = "inTxt";
            this.inTxt.Size = new System.Drawing.Size(282, 20);
            this.inTxt.TabIndex = 19;
            // 
            // txtOutLbl
            // 
            this.txtOutLbl.AutoSize = true;
            this.txtOutLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOutLbl.Location = new System.Drawing.Point(373, 17);
            this.txtOutLbl.Name = "txtOutLbl";
            this.txtOutLbl.Size = new System.Drawing.Size(51, 13);
            this.txtOutLbl.TabIndex = 21;
            this.txtOutLbl.Text = "Text Out:";
            // 
            // outTxt
            // 
            this.outTxt.Location = new System.Drawing.Point(430, 14);
            this.outTxt.Name = "outTxt";
            this.outTxt.Size = new System.Drawing.Size(282, 20);
            this.outTxt.TabIndex = 22;
            // 
            // btnFindReplace
            // 
            this.btnFindReplace.Location = new System.Drawing.Point(758, 12);
            this.btnFindReplace.Name = "btnFindReplace";
            this.btnFindReplace.Size = new System.Drawing.Size(115, 23);
            this.btnFindReplace.TabIndex = 23;
            this.btnFindReplace.Text = "Replace All";
            this.btnFindReplace.UseVisualStyleBackColor = true;
            this.btnFindReplace.Click += new System.EventHandler(this.btnFindReplace_Click);
            // 
            // inTxtErrorProv
            // 
            this.inTxtErrorProv.ContainerControl = this;
            // 
            // outTxtErrorProv
            // 
            this.outTxtErrorProv.ContainerControl = this;
            // 
            // FindAndReplaceControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindReplace);
            this.Controls.Add(this.outTxt);
            this.Controls.Add(this.txtOutLbl);
            this.Controls.Add(this.inTxt);
            this.Controls.Add(this.textInLbl);
            this.Name = "FindAndReplaceControls";
            this.Size = new System.Drawing.Size(886, 48);
            this.Load += new System.EventHandler(this.FindAndReplaceControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inTxtErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTxtErrorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FindAndReplaceControls_FindReplaceClicked1(object sender, System.EventArgs e)
        {
        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openImportFile;
        private System.Windows.Forms.OpenFileDialog openExportFile;
        private System.Windows.Forms.Label textInLbl;
        private System.Windows.Forms.TextBox inTxt;
        private System.Windows.Forms.Label txtOutLbl;
        private System.Windows.Forms.TextBox outTxt;
        private System.Windows.Forms.Button btnFindReplace;
        private System.Windows.Forms.ErrorProvider inTxtErrorProv;
        private System.Windows.Forms.ErrorProvider outTxtErrorProv;
    }
}
