namespace DirectorySolutions.UserControls
{
    partial class RenameFileForPath
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
            this.dirsToIncludLbl = new System.Windows.Forms.Label();
            this.numDirsToInclude = new System.Windows.Forms.ComboBox();
            this.IsNumberFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dirSeperatorChar = new System.Windows.Forms.ComboBox();
            this.btnRenameAll = new System.Windows.Forms.Button();
            this.renameByPathErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.spaceBuffer = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exampleFileNameLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renameByPathErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // dirsToIncludLbl
            // 
            this.dirsToIncludLbl.AutoSize = true;
            this.dirsToIncludLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirsToIncludLbl.Location = new System.Drawing.Point(21, 152);
            this.dirsToIncludLbl.Name = "dirsToIncludLbl";
            this.dirsToIncludLbl.Size = new System.Drawing.Size(190, 15);
            this.dirsToIncludLbl.TabIndex = 0;
            this.dirsToIncludLbl.Text = "Number of Directories To Include:";
            // 
            // numDirsToInclude
            // 
            this.numDirsToInclude.FormattingEnabled = true;
            this.numDirsToInclude.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.numDirsToInclude.Location = new System.Drawing.Point(217, 151);
            this.numDirsToInclude.Name = "numDirsToInclude";
            this.numDirsToInclude.Size = new System.Drawing.Size(79, 21);
            this.numDirsToInclude.TabIndex = 1;
            this.numDirsToInclude.SelectedIndexChanged += new System.EventHandler(this.numDirsToInclude_SelectedIndexChanged);
            // 
            // IsNumberFiles
            // 
            this.IsNumberFiles.AutoSize = true;
            this.IsNumberFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsNumberFiles.Location = new System.Drawing.Point(190, 107);
            this.IsNumberFiles.Name = "IsNumberFiles";
            this.IsNumberFiles.Size = new System.Drawing.Size(211, 19);
            this.IsNumberFiles.TabIndex = 2;
            this.IsNumberFiles.Text = "Include Numerical Incrementation";
            this.IsNumberFiles.UseVisualStyleBackColor = true;
            this.IsNumberFiles.CheckedChanged += new System.EventHandler(this.IsNumberFiles_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Files By:";
            // 
            // orderBy
            // 
            this.orderBy.FormattingEnabled = true;
            this.orderBy.Items.AddRange(new object[] {
            "Size Ascending",
            "Size Descending",
            "Name Ascending",
            "Name Descending",
            "Date Modified Ascending",
            "Date Modified Descending",
            ""});
            this.orderBy.Location = new System.Drawing.Point(499, 106);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(194, 21);
            this.orderBy.TabIndex = 4;
            this.orderBy.SelectedIndexChanged += new System.EventHandler(this.orderBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seperate Directories With:";
            // 
            // dirSeperatorChar
            // 
            this.dirSeperatorChar.FormattingEnabled = true;
            this.dirSeperatorChar.Items.AddRange(new object[] {
            "_ underscore",
            "- dash",
            " space",
            "[] brackets",
            "() parantheses"});
            this.dirSeperatorChar.Location = new System.Drawing.Point(468, 150);
            this.dirSeperatorChar.Name = "dirSeperatorChar";
            this.dirSeperatorChar.Size = new System.Drawing.Size(99, 21);
            this.dirSeperatorChar.TabIndex = 7;
            this.dirSeperatorChar.SelectedIndexChanged += new System.EventHandler(this.dirSeperatorChar_SelectedIndexChanged);
            // 
            // btnRenameAll
            // 
            this.btnRenameAll.Location = new System.Drawing.Point(778, 152);
            this.btnRenameAll.Name = "btnRenameAll";
            this.btnRenameAll.Size = new System.Drawing.Size(120, 23);
            this.btnRenameAll.TabIndex = 8;
            this.btnRenameAll.Text = "Rename All";
            this.btnRenameAll.UseVisualStyleBackColor = true;
            this.btnRenameAll.Click += new System.EventHandler(this.renameAll_Click);
            // 
            // renameByPathErrorProv
            // 
            this.renameByPathErrorProv.ContainerControl = this;
            // 
            // spaceBuffer
            // 
            this.spaceBuffer.AutoSize = true;
            this.spaceBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceBuffer.Location = new System.Drawing.Point(590, 152);
            this.spaceBuffer.Name = "spaceBuffer";
            this.spaceBuffer.Size = new System.Drawing.Size(158, 19);
            this.spaceBuffer.TabIndex = 11;
            this.spaceBuffer.Text = "Add Single Space Buffer";
            this.spaceBuffer.UseVisualStyleBackColor = true;
            this.spaceBuffer.CheckedChanged += new System.EventHandler(this.spaceBuffer_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Change options to see how an example name changes.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Example name:";
            // 
            // exampleFileNameLbl
            // 
            this.exampleFileNameLbl.AutoSize = true;
            this.exampleFileNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleFileNameLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exampleFileNameLbl.Location = new System.Drawing.Point(427, 63);
            this.exampleFileNameLbl.Name = "exampleFileNameLbl";
            this.exampleFileNameLbl.Size = new System.Drawing.Size(0, 15);
            this.exampleFileNameLbl.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(918, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "These controls allow you to remane your files based on their directory path.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(918, 26);
            this.label8.TabIndex = 34;
            this.label8.Text = "Rename Files By Path";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RenameFileForPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exampleFileNameLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spaceBuffer);
            this.Controls.Add(this.btnRenameAll);
            this.Controls.Add(this.dirSeperatorChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsNumberFiles);
            this.Controls.Add(this.numDirsToInclude);
            this.Controls.Add(this.dirsToIncludLbl);
            this.Name = "RenameFileForPath";
            this.Size = new System.Drawing.Size(918, 187);
            ((System.ComponentModel.ISupportInitialize)(this.renameByPathErrorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dirsToIncludLbl;
        private System.Windows.Forms.ComboBox numDirsToInclude;
        private System.Windows.Forms.CheckBox IsNumberFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox orderBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dirSeperatorChar;
        private System.Windows.Forms.Button btnRenameAll;
        private System.Windows.Forms.ErrorProvider renameByPathErrorProv;
        private System.Windows.Forms.CheckBox spaceBuffer;
        private System.Windows.Forms.Label exampleFileNameLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
