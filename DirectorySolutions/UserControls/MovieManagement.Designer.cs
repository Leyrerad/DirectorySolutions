namespace DirectorySolutions.UserControls
{
    partial class MovieManagement
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
            this.btnCreateInfoFiles = new System.Windows.Forms.Button();
            this.createInfoFilesTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.titleLbl = new System.Windows.Forms.Label();
            this.titleSearchTxt = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.yearLbl = new System.Windows.Forms.Label();
            this.yearStartTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearEndTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imdbRatingEndTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imdbRatingStartTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.topBilledTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.runtimeEndTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.runtimeStartTxt = new System.Windows.Forms.TextBox();
            this.freshSearchCheck = new System.Windows.Forms.CheckBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.requireGenresCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateInfoFiles
            // 
            this.btnCreateInfoFiles.Location = new System.Drawing.Point(744, 148);
            this.btnCreateInfoFiles.Name = "btnCreateInfoFiles";
            this.btnCreateInfoFiles.Size = new System.Drawing.Size(137, 24);
            this.btnCreateInfoFiles.TabIndex = 0;
            this.btnCreateInfoFiles.Text = "Create Info Files";
            this.btnCreateInfoFiles.UseVisualStyleBackColor = true;
            this.btnCreateInfoFiles.Click += new System.EventHandler(this.btnCreateInfoFiles_Click);
            // 
            // createInfoFilesTooltip
            // 
            this.createInfoFilesTooltip.IsBalloon = true;
            this.createInfoFilesTooltip.ShowAlways = true;
            this.createInfoFilesTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(10, 85);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(33, 15);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Title:";
            // 
            // titleSearchTxt
            // 
            this.titleSearchTxt.Location = new System.Drawing.Point(65, 83);
            this.titleSearchTxt.Name = "titleSearchTxt";
            this.titleSearchTxt.Size = new System.Drawing.Size(307, 20);
            this.titleSearchTxt.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(511, 148);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(70, 118);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(35, 15);
            this.yearLbl.TabIndex = 8;
            this.yearLbl.Text = "Year:";
            // 
            // yearStartTxt
            // 
            this.yearStartTxt.Location = new System.Drawing.Point(112, 118);
            this.yearStartTxt.Name = "yearStartTxt";
            this.yearStartTxt.Size = new System.Drawing.Size(80, 20);
            this.yearStartTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "To";
            // 
            // yearEndTxt
            // 
            this.yearEndTxt.Location = new System.Drawing.Point(225, 118);
            this.yearEndTxt.Name = "yearEndTxt";
            this.yearEndTxt.Size = new System.Drawing.Size(80, 20);
            this.yearEndTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "IMDb Rating:";
            // 
            // imdbRatingEndTxt
            // 
            this.imdbRatingEndTxt.Location = new System.Drawing.Point(515, 118);
            this.imdbRatingEndTxt.Name = "imdbRatingEndTxt";
            this.imdbRatingEndTxt.Size = new System.Drawing.Size(76, 20);
            this.imdbRatingEndTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "To";
            // 
            // imdbRatingStartTxt
            // 
            this.imdbRatingStartTxt.Location = new System.Drawing.Point(406, 118);
            this.imdbRatingStartTxt.Name = "imdbRatingStartTxt";
            this.imdbRatingStartTxt.Size = new System.Drawing.Size(76, 20);
            this.imdbRatingStartTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Genres:";
            // 
            // genreTxt
            // 
            this.genreTxt.Location = new System.Drawing.Point(451, 85);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(301, 20);
            this.genreTxt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Runtime (min):";
            // 
            // topBilledTxt
            // 
            this.topBilledTxt.Location = new System.Drawing.Point(96, 150);
            this.topBilledTxt.Name = "topBilledTxt";
            this.topBilledTxt.Size = new System.Drawing.Size(295, 20);
            this.topBilledTxt.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Top Billed:";
            // 
            // runtimeEndTxt
            // 
            this.runtimeEndTxt.Location = new System.Drawing.Point(805, 117);
            this.runtimeEndTxt.Name = "runtimeEndTxt";
            this.runtimeEndTxt.Size = new System.Drawing.Size(76, 20);
            this.runtimeEndTxt.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(778, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "To";
            // 
            // runtimeStartTxt
            // 
            this.runtimeStartTxt.Location = new System.Drawing.Point(696, 117);
            this.runtimeStartTxt.Name = "runtimeStartTxt";
            this.runtimeStartTxt.Size = new System.Drawing.Size(76, 20);
            this.runtimeStartTxt.TabIndex = 26;
            // 
            // freshSearchCheck
            // 
            this.freshSearchCheck.AutoSize = true;
            this.freshSearchCheck.Location = new System.Drawing.Point(625, 153);
            this.freshSearchCheck.Name = "freshSearchCheck";
            this.freshSearchCheck.Size = new System.Drawing.Size(82, 17);
            this.freshSearchCheck.TabIndex = 29;
            this.freshSearchCheck.Text = "Refresh List";
            this.freshSearchCheck.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(406, 147);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 30;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // requireGenresCheck
            // 
            this.requireGenresCheck.AutoSize = true;
            this.requireGenresCheck.Location = new System.Drawing.Point(775, 87);
            this.requireGenresCheck.Name = "requireGenresCheck";
            this.requireGenresCheck.Size = new System.Drawing.Size(114, 17);
            this.requireGenresCheck.TabIndex = 31;
            this.requireGenresCheck.Text = "Require All Genres";
            this.requireGenresCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(901, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "Movie Management Tools";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(901, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "These controls allow you to create information files for movies and use them to f" +
    "ilter movie lists.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(901, 18);
            this.label10.TabIndex = 34;
            this.label10.Text = "NOTE: You will need to enter your OMDB.com API key on the options page.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MovieManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.requireGenresCheck);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.freshSearchCheck);
            this.Controls.Add(this.runtimeEndTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.runtimeStartTxt);
            this.Controls.Add(this.topBilledTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imdbRatingEndTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imdbRatingStartTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearEndTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearStartTxt);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.titleSearchTxt);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.btnCreateInfoFiles);
            this.Controls.Add(this.label8);
            this.Name = "MovieManagement";
            this.Size = new System.Drawing.Size(901, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateInfoFiles;
        private System.Windows.Forms.ToolTip createInfoFilesTooltip;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox titleSearchTxt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.TextBox yearStartTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yearEndTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imdbRatingEndTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imdbRatingStartTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox topBilledTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox runtimeEndTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox runtimeStartTxt;
        private System.Windows.Forms.CheckBox freshSearchCheck;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox requireGenresCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
