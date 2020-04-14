namespace DirectorySolutions.UserControls
{
    partial class FilterFiles
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
            this.sizeOptionCombo = new System.Windows.Forms.ComboBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.freshSearchCheck = new System.Windows.Forms.CheckBox();
            this.modifiedEndTime = new System.Windows.Forms.DateTimePicker();
            this.modifiedStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.extensionsText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeEndTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeStartTxt = new System.Windows.Forms.TextBox();
            this.yearLbl = new System.Windows.Forms.Label();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.LblFileName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sizeOptionCombo
            // 
            this.sizeOptionCombo.FormattingEnabled = true;
            this.sizeOptionCombo.Items.AddRange(new object[] {
            "Byte",
            "KB",
            "MB",
            "Gig"});
            this.sizeOptionCombo.Location = new System.Drawing.Point(257, 100);
            this.sizeOptionCombo.Name = "sizeOptionCombo";
            this.sizeOptionCombo.Size = new System.Drawing.Size(70, 21);
            this.sizeOptionCombo.TabIndex = 70;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(835, 104);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(86, 23);
            this.btnClearFields.TabIndex = 69;
            this.btnClearFields.Text = "Clear All";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // freshSearchCheck
            // 
            this.freshSearchCheck.AutoSize = true;
            this.freshSearchCheck.Location = new System.Drawing.Point(747, 108);
            this.freshSearchCheck.Name = "freshSearchCheck";
            this.freshSearchCheck.Size = new System.Drawing.Size(82, 17);
            this.freshSearchCheck.TabIndex = 68;
            this.freshSearchCheck.Text = "Refresh List";
            this.freshSearchCheck.UseVisualStyleBackColor = true;
            // 
            // modifiedEndTime
            // 
            this.modifiedEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.modifiedEndTime.Location = new System.Drawing.Point(584, 63);
            this.modifiedEndTime.Name = "modifiedEndTime";
            this.modifiedEndTime.Size = new System.Drawing.Size(155, 20);
            this.modifiedEndTime.TabIndex = 67;
            // 
            // modifiedStartTime
            // 
            this.modifiedStartTime.AllowDrop = true;
            this.modifiedStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.modifiedStartTime.Location = new System.Drawing.Point(397, 63);
            this.modifiedStartTime.Name = "modifiedStartTime";
            this.modifiedStartTime.Size = new System.Drawing.Size(154, 20);
            this.modifiedStartTime.TabIndex = 66;
            this.modifiedStartTime.TabStop = false;
            this.modifiedStartTime.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(633, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Filter";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // extensionsText
            // 
            this.extensionsText.Location = new System.Drawing.Point(835, 64);
            this.extensionsText.Name = "extensionsText";
            this.extensionsText.Size = new System.Drawing.Size(85, 20);
            this.extensionsText.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(745, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 63;
            this.label5.Text = "Extension (s) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Modified:";
            // 
            // sizeEndTxt
            // 
            this.sizeEndTxt.Location = new System.Drawing.Point(171, 101);
            this.sizeEndTxt.Name = "sizeEndTxt";
            this.sizeEndTxt.Size = new System.Drawing.Size(77, 20);
            this.sizeEndTxt.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "To";
            // 
            // sizeStartTxt
            // 
            this.sizeStartTxt.Location = new System.Drawing.Point(60, 101);
            this.sizeStartTxt.Name = "sizeStartTxt";
            this.sizeStartTxt.Size = new System.Drawing.Size(78, 20);
            this.sizeStartTxt.TabIndex = 58;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(16, 104);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(34, 15);
            this.yearLbl.TabIndex = 57;
            this.yearLbl.Text = "Size:";
            // 
            // pathTxt
            // 
            this.pathTxt.Location = new System.Drawing.Point(374, 102);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(235, 20);
            this.pathTxt.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Path:";
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Location = new System.Drawing.Point(88, 62);
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(227, 20);
            this.fileNameTxt.TabIndex = 54;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFileName.Location = new System.Drawing.Point(15, 64);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(67, 15);
            this.LblFileName.TabIndex = 53;
            this.LblFileName.Text = "File Name:";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(941, 18);
            this.label9.TabIndex = 72;
            this.label9.Text = "These controls allow you to filter your file list based on the file properties be" +
    "low.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(941, 26);
            this.label8.TabIndex = 71;
            this.label8.Text = "File Filtering Tools";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FilterFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sizeOptionCombo);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.freshSearchCheck);
            this.Controls.Add(this.modifiedEndTime);
            this.Controls.Add(this.modifiedStartTime);
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
            this.Name = "FilterFiles";
            this.Size = new System.Drawing.Size(941, 168);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sizeOptionCombo;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.CheckBox freshSearchCheck;
        private System.Windows.Forms.DateTimePicker modifiedEndTime;
        private System.Windows.Forms.DateTimePicker modifiedStartTime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox extensionsText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeEndTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeStartTxt;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
