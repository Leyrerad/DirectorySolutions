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
            this.label2 = new System.Windows.Forms.Label();
            this.incFilesExist = new System.Windows.Forms.ComboBox();
            this.renameByPathErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.spaceBuffer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.renameByPathErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // dirsToIncludLbl
            // 
            this.dirsToIncludLbl.AutoSize = true;
            this.dirsToIncludLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirsToIncludLbl.Location = new System.Drawing.Point(3, 14);
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
            this.numDirsToInclude.Location = new System.Drawing.Point(199, 13);
            this.numDirsToInclude.Name = "numDirsToInclude";
            this.numDirsToInclude.Size = new System.Drawing.Size(79, 21);
            this.numDirsToInclude.TabIndex = 1;
            // 
            // IsNumberFiles
            // 
            this.IsNumberFiles.AutoSize = true;
            this.IsNumberFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsNumberFiles.Location = new System.Drawing.Point(293, 15);
            this.IsNumberFiles.Name = "IsNumberFiles";
            this.IsNumberFiles.Size = new System.Drawing.Size(211, 19);
            this.IsNumberFiles.TabIndex = 2;
            this.IsNumberFiles.Text = "Include Numerical Incrementation";
            this.IsNumberFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 17);
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
            this.orderBy.Location = new System.Drawing.Point(602, 14);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(194, 21);
            this.orderBy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(814, 17);
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
            this.dirSeperatorChar.Location = new System.Drawing.Point(969, 15);
            this.dirSeperatorChar.Name = "dirSeperatorChar";
            this.dirSeperatorChar.Size = new System.Drawing.Size(99, 21);
            this.dirSeperatorChar.TabIndex = 7;
            // 
            // btnRenameAll
            // 
            this.btnRenameAll.Location = new System.Drawing.Point(1088, 13);
            this.btnRenameAll.Name = "btnRenameAll";
            this.btnRenameAll.Size = new System.Drawing.Size(120, 23);
            this.btnRenameAll.TabIndex = 8;
            this.btnRenameAll.Text = "Rename All";
            this.btnRenameAll.UseVisualStyleBackColor = true;
            this.btnRenameAll.Click += new System.EventHandler(this.renameAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contains Incremented Files:";
            // 
            // incFilesExist
            // 
            this.incFilesExist.FormattingEnabled = true;
            this.incFilesExist.Items.AddRange(new object[] {
            "No",
            "Prepended",
            "Appended"});
            this.incFilesExist.Location = new System.Drawing.Point(438, 51);
            this.incFilesExist.Name = "incFilesExist";
            this.incFilesExist.Size = new System.Drawing.Size(121, 21);
            this.incFilesExist.TabIndex = 10;
            // 
            // renameByPathErrorProv
            // 
            this.renameByPathErrorProv.ContainerControl = this;
            // 
            // spaceBuffer
            // 
            this.spaceBuffer.AutoSize = true;
            this.spaceBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceBuffer.Location = new System.Drawing.Point(622, 51);
            this.spaceBuffer.Name = "spaceBuffer";
            this.spaceBuffer.Size = new System.Drawing.Size(158, 19);
            this.spaceBuffer.TabIndex = 11;
            this.spaceBuffer.Text = "Add Single Space Buffer";
            this.spaceBuffer.UseVisualStyleBackColor = true;
            // 
            // RenameFileForPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spaceBuffer);
            this.Controls.Add(this.incFilesExist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRenameAll);
            this.Controls.Add(this.dirSeperatorChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsNumberFiles);
            this.Controls.Add(this.numDirsToInclude);
            this.Controls.Add(this.dirsToIncludLbl);
            this.Name = "RenameFileForPath";
            this.Size = new System.Drawing.Size(1228, 81);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox incFilesExist;
        private System.Windows.Forms.ErrorProvider renameByPathErrorProv;
        private System.Windows.Forms.CheckBox spaceBuffer;
    }
}
