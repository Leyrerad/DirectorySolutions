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
            this.prependErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.prependTxt = new System.Windows.Forms.TextBox();
            this.appendTxt = new System.Windows.Forms.TextBox();
            this.prependLbl = new System.Windows.Forms.Label();
            this.appendLbl = new System.Windows.Forms.Label();
            this.btnPreAppend = new System.Windows.Forms.Button();
            this.outTxtErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.replaceAllTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.appendErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.replaceAllErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.PreAppendErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.LblFileName = new System.Windows.Forms.Label();
            this.modifiedEndTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modifiedStartTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeEndTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeStartTxt = new System.Windows.Forms.TextBox();
            this.yearLbl = new System.Windows.Forms.Label();
            this.extensionsTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inTxtErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prependErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTxtErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appendErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceAllErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreAppendErrorProv)).BeginInit();
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
            this.textInLbl.Location = new System.Drawing.Point(52, 137);
            this.textInLbl.Name = "textInLbl";
            this.textInLbl.Size = new System.Drawing.Size(43, 13);
            this.textInLbl.TabIndex = 18;
            this.textInLbl.Text = "Text In:";
            // 
            // inTxt
            // 
            this.inTxt.Location = new System.Drawing.Point(101, 134);
            this.inTxt.Name = "inTxt";
            this.inTxt.Size = new System.Drawing.Size(282, 20);
            this.inTxt.TabIndex = 19;
            // 
            // txtOutLbl
            // 
            this.txtOutLbl.AutoSize = true;
            this.txtOutLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOutLbl.Location = new System.Drawing.Point(416, 137);
            this.txtOutLbl.Name = "txtOutLbl";
            this.txtOutLbl.Size = new System.Drawing.Size(51, 13);
            this.txtOutLbl.TabIndex = 21;
            this.txtOutLbl.Text = "Text Out:";
            // 
            // outTxt
            // 
            this.outTxt.Location = new System.Drawing.Point(473, 134);
            this.outTxt.Name = "outTxt";
            this.outTxt.Size = new System.Drawing.Size(282, 20);
            this.outTxt.TabIndex = 22;
            // 
            // btnFindReplace
            // 
            this.btnFindReplace.Location = new System.Drawing.Point(801, 132);
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
            // prependErrorProv
            // 
            this.prependErrorProv.ContainerControl = this;
            // 
            // prependTxt
            // 
            this.prependTxt.Location = new System.Drawing.Point(101, 172);
            this.prependTxt.Name = "prependTxt";
            this.prependTxt.Size = new System.Drawing.Size(282, 20);
            this.prependTxt.TabIndex = 24;
            // 
            // appendTxt
            // 
            this.appendTxt.Location = new System.Drawing.Point(473, 172);
            this.appendTxt.Name = "appendTxt";
            this.appendTxt.Size = new System.Drawing.Size(282, 20);
            this.appendTxt.TabIndex = 25;
            // 
            // prependLbl
            // 
            this.prependLbl.AutoSize = true;
            this.prependLbl.Location = new System.Drawing.Point(46, 175);
            this.prependLbl.Name = "prependLbl";
            this.prependLbl.Size = new System.Drawing.Size(50, 13);
            this.prependLbl.TabIndex = 26;
            this.prependLbl.Text = "Prepend:";
            // 
            // appendLbl
            // 
            this.appendLbl.AutoSize = true;
            this.appendLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appendLbl.Location = new System.Drawing.Point(416, 175);
            this.appendLbl.Name = "appendLbl";
            this.appendLbl.Size = new System.Drawing.Size(47, 13);
            this.appendLbl.TabIndex = 27;
            this.appendLbl.Text = "Append:";
            // 
            // btnPreAppend
            // 
            this.btnPreAppend.Location = new System.Drawing.Point(801, 170);
            this.btnPreAppend.Name = "btnPreAppend";
            this.btnPreAppend.Size = new System.Drawing.Size(115, 23);
            this.btnPreAppend.TabIndex = 28;
            this.btnPreAppend.Text = "Pre/Append";
            this.btnPreAppend.UseVisualStyleBackColor = true;
            this.btnPreAppend.Click += new System.EventHandler(this.btnPreAppend_Click);
            // 
            // outTxtErrorProv
            // 
            this.outTxtErrorProv.ContainerControl = this;
            // 
            // replaceAllTooltip
            // 
            this.replaceAllTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // appendErrorProv
            // 
            this.appendErrorProv.ContainerControl = this;
            // 
            // replaceAllErrorProv
            // 
            this.replaceAllErrorProv.ContainerControl = this;
            // 
            // PreAppendErrorProv
            // 
            this.PreAppendErrorProv.ContainerControl = this;
            // 
            // pathTxt
            // 
            this.pathTxt.Location = new System.Drawing.Point(352, 65);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(347, 20);
            this.pathTxt.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Path:";
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Location = new System.Drawing.Point(115, 23);
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(227, 20);
            this.fileNameTxt.TabIndex = 30;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFileName.Location = new System.Drawing.Point(43, 24);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(67, 15);
            this.LblFileName.TabIndex = 29;
            this.LblFileName.Text = "File Name:";
            // 
            // modifiedEndTxt
            // 
            this.modifiedEndTxt.Location = new System.Drawing.Point(562, 24);
            this.modifiedEndTxt.Name = "modifiedEndTxt";
            this.modifiedEndTxt.Size = new System.Drawing.Size(76, 20);
            this.modifiedEndTxt.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "To";
            // 
            // modifiedStartTxt
            // 
            this.modifiedStartTxt.Location = new System.Drawing.Point(453, 24);
            this.modifiedStartTxt.Name = "modifiedStartTxt";
            this.modifiedStartTxt.Size = new System.Drawing.Size(76, 20);
            this.modifiedStartTxt.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date Modified:";
            // 
            // sizeEndTxt
            // 
            this.sizeEndTxt.Location = new System.Drawing.Point(200, 62);
            this.sizeEndTxt.Name = "sizeEndTxt";
            this.sizeEndTxt.Size = new System.Drawing.Size(80, 20);
            this.sizeEndTxt.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "To";
            // 
            // sizeStartTxt
            // 
            this.sizeStartTxt.Location = new System.Drawing.Point(87, 62);
            this.sizeStartTxt.Name = "sizeStartTxt";
            this.sizeStartTxt.Size = new System.Drawing.Size(80, 20);
            this.sizeStartTxt.TabIndex = 34;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(43, 65);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(34, 15);
            this.yearLbl.TabIndex = 33;
            this.yearLbl.Text = "Size:";
            // 
            // extensionsTxt
            // 
            this.extensionsTxt.Location = new System.Drawing.Point(747, 24);
            this.extensionsTxt.Name = "extensionsTxt";
            this.extensionsTxt.Size = new System.Drawing.Size(180, 20);
            this.extensionsTxt.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Extension (s) :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(801, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 23);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // FindAndReplaceControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.extensionsTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modifiedEndTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modifiedStartTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeEndTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeStartTxt);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileNameTxt);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.btnPreAppend);
            this.Controls.Add(this.appendLbl);
            this.Controls.Add(this.prependLbl);
            this.Controls.Add(this.appendTxt);
            this.Controls.Add(this.prependTxt);
            this.Controls.Add(this.btnFindReplace);
            this.Controls.Add(this.outTxt);
            this.Controls.Add(this.txtOutLbl);
            this.Controls.Add(this.inTxt);
            this.Controls.Add(this.textInLbl);
            this.Name = "FindAndReplaceControls";
            this.Size = new System.Drawing.Size(974, 224);
            ((System.ComponentModel.ISupportInitialize)(this.inTxtErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prependErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTxtErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appendErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceAllErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreAppendErrorProv)).EndInit();
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
        private System.Windows.Forms.ErrorProvider prependErrorProv;
        private System.Windows.Forms.Button btnPreAppend;
        private System.Windows.Forms.Label appendLbl;
        private System.Windows.Forms.Label prependLbl;
        private System.Windows.Forms.TextBox appendTxt;
        private System.Windows.Forms.TextBox prependTxt;
        private System.Windows.Forms.ErrorProvider outTxtErrorProv;
        private System.Windows.Forms.ToolTip replaceAllTooltip;
        private System.Windows.Forms.ErrorProvider appendErrorProv;
        private System.Windows.Forms.ErrorProvider replaceAllErrorProv;
        private System.Windows.Forms.ErrorProvider PreAppendErrorProv;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.TextBox modifiedEndTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modifiedStartTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeEndTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeStartTxt;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.TextBox extensionsTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
    }
}
