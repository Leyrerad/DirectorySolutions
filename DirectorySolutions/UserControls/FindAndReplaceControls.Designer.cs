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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeEndTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeStartTxt = new System.Windows.Forms.TextBox();
            this.yearLbl = new System.Windows.Forms.Label();
            this.extensionsText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.movePathTxt = new System.Windows.Forms.TextBox();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.movePathTxtErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.modifiedStartTime = new System.Windows.Forms.DateTimePicker();
            this.modifiedEndTime = new System.Windows.Forms.DateTimePicker();
            this.genericErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.freshSearchCheck = new System.Windows.Forms.CheckBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.sizeOptionCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.inTxtErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prependErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTxtErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appendErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceAllErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreAppendErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePathTxtErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genericErrorProv)).BeginInit();
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
            this.textInLbl.Location = new System.Drawing.Point(38, 179);
            this.textInLbl.Name = "textInLbl";
            this.textInLbl.Size = new System.Drawing.Size(43, 13);
            this.textInLbl.TabIndex = 18;
            this.textInLbl.Text = "Text In:";
            // 
            // inTxt
            // 
            this.inTxt.Location = new System.Drawing.Point(87, 176);
            this.inTxt.Name = "inTxt";
            this.inTxt.Size = new System.Drawing.Size(282, 20);
            this.inTxt.TabIndex = 19;
            // 
            // txtOutLbl
            // 
            this.txtOutLbl.AutoSize = true;
            this.txtOutLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOutLbl.Location = new System.Drawing.Point(402, 179);
            this.txtOutLbl.Name = "txtOutLbl";
            this.txtOutLbl.Size = new System.Drawing.Size(51, 13);
            this.txtOutLbl.TabIndex = 21;
            this.txtOutLbl.Text = "Text Out:";
            // 
            // outTxt
            // 
            this.outTxt.Location = new System.Drawing.Point(459, 176);
            this.outTxt.Name = "outTxt";
            this.outTxt.Size = new System.Drawing.Size(282, 20);
            this.outTxt.TabIndex = 22;
            // 
            // btnFindReplace
            // 
            this.btnFindReplace.Location = new System.Drawing.Point(830, 176);
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
            this.prependTxt.Location = new System.Drawing.Point(87, 214);
            this.prependTxt.Name = "prependTxt";
            this.prependTxt.Size = new System.Drawing.Size(282, 20);
            this.prependTxt.TabIndex = 24;
            // 
            // appendTxt
            // 
            this.appendTxt.Location = new System.Drawing.Point(459, 214);
            this.appendTxt.Name = "appendTxt";
            this.appendTxt.Size = new System.Drawing.Size(282, 20);
            this.appendTxt.TabIndex = 25;
            // 
            // prependLbl
            // 
            this.prependLbl.AutoSize = true;
            this.prependLbl.Location = new System.Drawing.Point(32, 217);
            this.prependLbl.Name = "prependLbl";
            this.prependLbl.Size = new System.Drawing.Size(50, 13);
            this.prependLbl.TabIndex = 26;
            this.prependLbl.Text = "Prepend:";
            // 
            // appendLbl
            // 
            this.appendLbl.AutoSize = true;
            this.appendLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appendLbl.Location = new System.Drawing.Point(402, 217);
            this.appendLbl.Name = "appendLbl";
            this.appendLbl.Size = new System.Drawing.Size(47, 13);
            this.appendLbl.TabIndex = 27;
            this.appendLbl.Text = "Append:";
            // 
            // btnPreAppend
            // 
            this.btnPreAppend.Location = new System.Drawing.Point(830, 211);
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
            this.pathTxt.Location = new System.Drawing.Point(392, 65);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(235, 20);
            this.pathTxt.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Path:";
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Location = new System.Drawing.Point(106, 26);
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(227, 20);
            this.fileNameTxt.TabIndex = 30;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFileName.Location = new System.Drawing.Point(34, 27);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(67, 15);
            this.LblFileName.TabIndex = 29;
            this.LblFileName.Text = "File Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Modified:";
            // 
            // sizeEndTxt
            // 
            this.sizeEndTxt.Location = new System.Drawing.Point(189, 65);
            this.sizeEndTxt.Name = "sizeEndTxt";
            this.sizeEndTxt.Size = new System.Drawing.Size(77, 20);
            this.sizeEndTxt.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "To";
            // 
            // sizeStartTxt
            // 
            this.sizeStartTxt.Location = new System.Drawing.Point(78, 65);
            this.sizeStartTxt.Name = "sizeStartTxt";
            this.sizeStartTxt.Size = new System.Drawing.Size(78, 20);
            this.sizeStartTxt.TabIndex = 34;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(34, 68);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(34, 15);
            this.yearLbl.TabIndex = 33;
            this.yearLbl.Text = "Size:";
            // 
            // extensionsText
            // 
            this.extensionsText.Location = new System.Drawing.Point(853, 28);
            this.extensionsText.Name = "extensionsText";
            this.extensionsText.Size = new System.Drawing.Size(85, 20);
            this.extensionsText.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(763, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Extension (s) :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(651, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Move Files to Path:";
            // 
            // movePathTxt
            // 
            this.movePathTxt.Location = new System.Drawing.Point(228, 121);
            this.movePathTxt.Name = "movePathTxt";
            this.movePathTxt.Size = new System.Drawing.Size(347, 20);
            this.movePathTxt.TabIndex = 45;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Location = new System.Drawing.Point(602, 119);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(109, 23);
            this.btnOpenPath.TabIndex = 46;
            this.btnOpenPath.Text = "Open";
            this.btnOpenPath.UseVisualStyleBackColor = true;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Location = new System.Drawing.Point(719, 119);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(109, 23);
            this.btnMoveFiles.TabIndex = 47;
            this.btnMoveFiles.Text = "Move";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // movePathTxtErrorProv
            // 
            this.movePathTxtErrorProv.ContainerControl = this;
            // 
            // modifiedStartTime
            // 
            this.modifiedStartTime.AllowDrop = true;
            this.modifiedStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.modifiedStartTime.Location = new System.Drawing.Point(415, 27);
            this.modifiedStartTime.Name = "modifiedStartTime";
            this.modifiedStartTime.Size = new System.Drawing.Size(154, 20);
            this.modifiedStartTime.TabIndex = 48;
            this.modifiedStartTime.TabStop = false;
            this.modifiedStartTime.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // modifiedEndTime
            // 
            this.modifiedEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.modifiedEndTime.Location = new System.Drawing.Point(602, 27);
            this.modifiedEndTime.Name = "modifiedEndTime";
            this.modifiedEndTime.Size = new System.Drawing.Size(155, 20);
            this.modifiedEndTime.TabIndex = 49;
            // 
            // genericErrorProv
            // 
            this.genericErrorProv.ContainerControl = this;
            // 
            // freshSearchCheck
            // 
            this.freshSearchCheck.AutoSize = true;
            this.freshSearchCheck.Location = new System.Drawing.Point(765, 72);
            this.freshSearchCheck.Name = "freshSearchCheck";
            this.freshSearchCheck.Size = new System.Drawing.Size(82, 17);
            this.freshSearchCheck.TabIndex = 50;
            this.freshSearchCheck.Text = "Refresh List";
            this.freshSearchCheck.UseVisualStyleBackColor = true;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(853, 68);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(86, 23);
            this.btnClearFields.TabIndex = 51;
            this.btnClearFields.Text = "Clear All";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // sizeOptionCombo
            // 
            this.sizeOptionCombo.FormattingEnabled = true;
            this.sizeOptionCombo.Items.AddRange(new object[] {
            "Byte",
            "KB",
            "MB",
            "Gig"});
            this.sizeOptionCombo.Location = new System.Drawing.Point(275, 64);
            this.sizeOptionCombo.Name = "sizeOptionCombo";
            this.sizeOptionCombo.Size = new System.Drawing.Size(70, 21);
            this.sizeOptionCombo.TabIndex = 52;
            // 
            // FindAndReplaceControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.sizeOptionCombo);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.freshSearchCheck);
            this.Controls.Add(this.modifiedEndTime);
            this.Controls.Add(this.modifiedStartTime);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.movePathTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.extensionsText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
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
            this.Size = new System.Drawing.Size(974, 265);
            ((System.ComponentModel.ISupportInitialize)(this.inTxtErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prependErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTxtErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appendErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceAllErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreAppendErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePathTxtErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genericErrorProv)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeEndTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeStartTxt;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.TextBox extensionsText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.TextBox movePathTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider movePathTxtErrorProv;
        private System.Windows.Forms.DateTimePicker modifiedStartTime;
        private System.Windows.Forms.DateTimePicker modifiedEndTime;
        private System.Windows.Forms.ErrorProvider genericErrorProv;
        private System.Windows.Forms.CheckBox freshSearchCheck;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.ComboBox sizeOptionCombo;
    }
}
