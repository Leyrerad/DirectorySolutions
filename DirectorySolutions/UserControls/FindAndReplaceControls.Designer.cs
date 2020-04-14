﻿namespace DirectorySolutions
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
            this.label6 = new System.Windows.Forms.Label();
            this.movePathTxt = new System.Windows.Forms.TextBox();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.movePathTxtErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.genericErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.operationOptionCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.textInLbl.Location = new System.Drawing.Point(10, 57);
            this.textInLbl.Name = "textInLbl";
            this.textInLbl.Size = new System.Drawing.Size(43, 13);
            this.textInLbl.TabIndex = 18;
            this.textInLbl.Text = "Text In:";
            // 
            // inTxt
            // 
            this.inTxt.Location = new System.Drawing.Point(59, 54);
            this.inTxt.Name = "inTxt";
            this.inTxt.Size = new System.Drawing.Size(258, 20);
            this.inTxt.TabIndex = 19;
            // 
            // txtOutLbl
            // 
            this.txtOutLbl.AutoSize = true;
            this.txtOutLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOutLbl.Location = new System.Drawing.Point(330, 57);
            this.txtOutLbl.Name = "txtOutLbl";
            this.txtOutLbl.Size = new System.Drawing.Size(51, 13);
            this.txtOutLbl.TabIndex = 21;
            this.txtOutLbl.Text = "Text Out:";
            // 
            // outTxt
            // 
            this.outTxt.Location = new System.Drawing.Point(387, 54);
            this.outTxt.Name = "outTxt";
            this.outTxt.Size = new System.Drawing.Size(258, 20);
            this.outTxt.TabIndex = 22;
            // 
            // btnFindReplace
            // 
            this.btnFindReplace.Location = new System.Drawing.Point(662, 54);
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
            this.prependTxt.Location = new System.Drawing.Point(59, 92);
            this.prependTxt.Name = "prependTxt";
            this.prependTxt.Size = new System.Drawing.Size(258, 20);
            this.prependTxt.TabIndex = 24;
            // 
            // appendTxt
            // 
            this.appendTxt.Location = new System.Drawing.Point(387, 92);
            this.appendTxt.Name = "appendTxt";
            this.appendTxt.Size = new System.Drawing.Size(258, 20);
            this.appendTxt.TabIndex = 25;
            // 
            // prependLbl
            // 
            this.prependLbl.AutoSize = true;
            this.prependLbl.Location = new System.Drawing.Point(4, 95);
            this.prependLbl.Name = "prependLbl";
            this.prependLbl.Size = new System.Drawing.Size(50, 13);
            this.prependLbl.TabIndex = 26;
            this.prependLbl.Text = "Prepend:";
            // 
            // appendLbl
            // 
            this.appendLbl.AutoSize = true;
            this.appendLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appendLbl.Location = new System.Drawing.Point(330, 95);
            this.appendLbl.Name = "appendLbl";
            this.appendLbl.Size = new System.Drawing.Size(47, 13);
            this.appendLbl.TabIndex = 27;
            this.appendLbl.Text = "Append:";
            // 
            // btnPreAppend
            // 
            this.btnPreAppend.Location = new System.Drawing.Point(662, 89);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Move Files to Path:";
            // 
            // movePathTxt
            // 
            this.movePathTxt.Location = new System.Drawing.Point(200, 17);
            this.movePathTxt.Name = "movePathTxt";
            this.movePathTxt.Size = new System.Drawing.Size(347, 20);
            this.movePathTxt.TabIndex = 45;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Location = new System.Drawing.Point(574, 15);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(109, 23);
            this.btnOpenPath.TabIndex = 46;
            this.btnOpenPath.Text = "Open";
            this.btnOpenPath.UseVisualStyleBackColor = true;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Location = new System.Drawing.Point(691, 15);
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
            // genericErrorProv
            // 
            this.genericErrorProv.ContainerControl = this;
            // 
            // operationOptionCombo
            // 
            this.operationOptionCombo.FormattingEnabled = true;
            this.operationOptionCombo.Items.AddRange(new object[] {
            "File(s)",
            "Parent Directory",
            "Full Path"});
            this.operationOptionCombo.Location = new System.Drawing.Point(802, 89);
            this.operationOptionCombo.Name = "operationOptionCombo";
            this.operationOptionCombo.Size = new System.Drawing.Size(109, 21);
            this.operationOptionCombo.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(799, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Run Operation On:";
            // 
            // FindAndReplaceControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.operationOptionCombo);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.movePathTxt);
            this.Controls.Add(this.label6);
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
            this.Size = new System.Drawing.Size(935, 132);
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
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.TextBox movePathTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider movePathTxtErrorProv;
        private System.Windows.Forms.ErrorProvider genericErrorProv;
        private System.Windows.Forms.ComboBox operationOptionCombo;
        private System.Windows.Forms.Label label7;
    }
}
