namespace DirectorySolutions
{
    partial class Options
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultPathTxt = new System.Windows.Forms.TextBox();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.fastPathMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.displayGridOptionsFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.displayGridOptionsMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.mainOptionPanel = new System.Windows.Forms.Panel();
            this.fastPathFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.fastPathTxt = new System.Windows.Forms.TextBox();
            this.btnOpenFastPathDir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.omdbApiTxt = new System.Windows.Forms.TextBox();
            this.btnOmdbApiEdit = new System.Windows.Forms.Button();
            this.btnOmdbApiSave = new System.Windows.Forms.Button();
            this.omdbLink = new System.Windows.Forms.LinkLabel();
            this.btnSaveFastPath = new System.Windows.Forms.Button();
            this.btnRemoveFastPath = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainOptionPanel.SuspendLayout();
            this.fastPathFlowLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 454);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(875, 33);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(797, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(716, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.defaultPathTxt);
            this.flowLayoutPanel3.Controls.Add(this.btnOpenDir);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(875, 32);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Default Directory Path On Open:";
            // 
            // defaultPathTxt
            // 
            this.defaultPathTxt.Location = new System.Drawing.Point(189, 5);
            this.defaultPathTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.defaultPathTxt.Name = "defaultPathTxt";
            this.defaultPathTxt.Size = new System.Drawing.Size(478, 20);
            this.defaultPathTxt.TabIndex = 1;
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.ContextMenuStrip = this.fastPathMenuStrip;
            this.btnOpenDir.Location = new System.Drawing.Point(673, 3);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDir.TabIndex = 2;
            this.btnOpenDir.Text = "Open";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // fastPathMenuStrip
            // 
            this.fastPathMenuStrip.Name = "fastPathMenuStrip";
            this.fastPathMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // displayGridOptionsFiles
            // 
            this.displayGridOptionsFiles.AutoScroll = true;
            this.displayGridOptionsFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayGridOptionsFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayGridOptionsFiles.Location = new System.Drawing.Point(0, 57);
            this.displayGridOptionsFiles.Name = "displayGridOptionsFiles";
            this.displayGridOptionsFiles.Size = new System.Drawing.Size(875, 100);
            this.displayGridOptionsFiles.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 25);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(875, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "File Columns Displayed";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(875, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Movie Columns Displayed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayGridOptionsMovies
            // 
            this.displayGridOptionsMovies.AutoScroll = true;
            this.displayGridOptionsMovies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayGridOptionsMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayGridOptionsMovies.Location = new System.Drawing.Point(0, 182);
            this.displayGridOptionsMovies.Name = "displayGridOptionsMovies";
            this.displayGridOptionsMovies.Size = new System.Drawing.Size(875, 100);
            this.displayGridOptionsMovies.TabIndex = 5;
            // 
            // mainOptionPanel
            // 
            this.mainOptionPanel.AutoScroll = true;
            this.mainOptionPanel.Controls.Add(this.flowLayoutPanel1);
            this.mainOptionPanel.Controls.Add(this.fastPathFlowLayout);
            this.mainOptionPanel.Controls.Add(this.displayGridOptionsMovies);
            this.mainOptionPanel.Controls.Add(this.flowLayoutPanel2);
            this.mainOptionPanel.Controls.Add(this.label4);
            this.mainOptionPanel.Controls.Add(this.displayGridOptionsFiles);
            this.mainOptionPanel.Controls.Add(this.panel1);
            this.mainOptionPanel.Controls.Add(this.flowLayoutPanel3);
            this.mainOptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainOptionPanel.Location = new System.Drawing.Point(0, 18);
            this.mainOptionPanel.Name = "mainOptionPanel";
            this.mainOptionPanel.Size = new System.Drawing.Size(875, 487);
            this.mainOptionPanel.TabIndex = 6;
            // 
            // fastPathFlowLayout
            // 
            this.fastPathFlowLayout.Controls.Add(this.label5);
            this.fastPathFlowLayout.Controls.Add(this.fastPathTxt);
            this.fastPathFlowLayout.Controls.Add(this.btnOpenFastPathDir);
            this.fastPathFlowLayout.Controls.Add(this.btnSaveFastPath);
            this.fastPathFlowLayout.Controls.Add(this.btnRemoveFastPath);
            this.fastPathFlowLayout.Controls.Add(this.label6);
            this.fastPathFlowLayout.Controls.Add(this.label7);
            this.fastPathFlowLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.fastPathFlowLayout.Location = new System.Drawing.Point(0, 282);
            this.fastPathFlowLayout.Name = "fastPathFlowLayout";
            this.fastPathFlowLayout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.fastPathFlowLayout.Size = new System.Drawing.Size(875, 57);
            this.fastPathFlowLayout.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add path to \"Fast Path\":";
            // 
            // fastPathTxt
            // 
            this.fastPathTxt.Location = new System.Drawing.Point(142, 10);
            this.fastPathTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.fastPathTxt.Name = "fastPathTxt";
            this.fastPathTxt.Size = new System.Drawing.Size(435, 20);
            this.fastPathTxt.TabIndex = 1;
            // 
            // btnOpenFastPathDir
            // 
            this.btnOpenFastPathDir.ContextMenuStrip = this.fastPathMenuStrip;
            this.btnOpenFastPathDir.Location = new System.Drawing.Point(583, 8);
            this.btnOpenFastPathDir.Name = "btnOpenFastPathDir";
            this.btnOpenFastPathDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFastPathDir.TabIndex = 2;
            this.btnOpenFastPathDir.Text = "Open";
            this.btnOpenFastPathDir.UseVisualStyleBackColor = true;
            this.btnOpenFastPathDir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 34);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(448, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "\"Fast Path\" lets you right click on any directory opening button to quickly selec" +
    "t a saved path.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 34);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(321, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Save a path then right click on \"Open\" above to see how it works.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.omdbApiTxt);
            this.flowLayoutPanel1.Controls.Add(this.btnOmdbApiEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnOmdbApiSave);
            this.flowLayoutPanel1.Controls.Add(this.omdbLink);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 339);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(875, 35);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "OMDB API KEY:";
            // 
            // omdbApiTxt
            // 
            this.omdbApiTxt.Location = new System.Drawing.Point(103, 5);
            this.omdbApiTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.omdbApiTxt.Name = "omdbApiTxt";
            this.omdbApiTxt.ReadOnly = true;
            this.omdbApiTxt.Size = new System.Drawing.Size(197, 20);
            this.omdbApiTxt.TabIndex = 1;
            // 
            // btnOmdbApiEdit
            // 
            this.btnOmdbApiEdit.Location = new System.Drawing.Point(306, 3);
            this.btnOmdbApiEdit.Name = "btnOmdbApiEdit";
            this.btnOmdbApiEdit.Size = new System.Drawing.Size(75, 23);
            this.btnOmdbApiEdit.TabIndex = 2;
            this.btnOmdbApiEdit.Text = "Edit";
            this.btnOmdbApiEdit.UseVisualStyleBackColor = true;
            this.btnOmdbApiEdit.Click += new System.EventHandler(this.btnOmdbApiEdit_Click);
            // 
            // btnOmdbApiSave
            // 
            this.btnOmdbApiSave.Location = new System.Drawing.Point(387, 3);
            this.btnOmdbApiSave.Name = "btnOmdbApiSave";
            this.btnOmdbApiSave.Size = new System.Drawing.Size(75, 23);
            this.btnOmdbApiSave.TabIndex = 3;
            this.btnOmdbApiSave.Text = "Save";
            this.btnOmdbApiSave.UseVisualStyleBackColor = true;
            this.btnOmdbApiSave.Click += new System.EventHandler(this.btnOmdbApiSave_Click);
            // 
            // omdbLink
            // 
            this.omdbLink.AutoSize = true;
            this.omdbLink.Location = new System.Drawing.Point(468, 0);
            this.omdbLink.Name = "omdbLink";
            this.omdbLink.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.omdbLink.Size = new System.Drawing.Size(99, 20);
            this.omdbLink.TabIndex = 4;
            this.omdbLink.TabStop = true;
            this.omdbLink.Text = "Get OMDB API key";
            this.omdbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.omdbLink_LinkClicked);
            // 
            // btnSaveFastPath
            // 
            this.btnSaveFastPath.ContextMenuStrip = this.fastPathMenuStrip;
            this.btnSaveFastPath.Location = new System.Drawing.Point(664, 8);
            this.btnSaveFastPath.Name = "btnSaveFastPath";
            this.btnSaveFastPath.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFastPath.TabIndex = 5;
            this.btnSaveFastPath.Text = "Save";
            this.btnSaveFastPath.UseVisualStyleBackColor = true;
            this.btnSaveFastPath.Click += new System.EventHandler(this.btnSaveFastPath_Click);
            // 
            // btnRemoveFastPath
            // 
            this.btnRemoveFastPath.ContextMenuStrip = this.fastPathMenuStrip;
            this.btnRemoveFastPath.Location = new System.Drawing.Point(745, 8);
            this.btnRemoveFastPath.Name = "btnRemoveFastPath";
            this.btnRemoveFastPath.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFastPath.TabIndex = 6;
            this.btnRemoveFastPath.Text = "Remove";
            this.btnRemoveFastPath.UseVisualStyleBackColor = true;
            this.btnRemoveFastPath.Click += new System.EventHandler(this.btnRemoveFastPath_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 505);
            this.Controls.Add(this.mainOptionPanel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.mainOptionPanel.ResumeLayout(false);
            this.fastPathFlowLayout.ResumeLayout(false);
            this.fastPathFlowLayout.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox defaultPathTxt;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.FlowLayoutPanel displayGridOptionsFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel displayGridOptionsMovies;
        private System.Windows.Forms.Panel mainOptionPanel;
        private System.Windows.Forms.FlowLayoutPanel fastPathFlowLayout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fastPathTxt;
        private System.Windows.Forms.Button btnOpenFastPathDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip fastPathMenuStrip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox omdbApiTxt;
        private System.Windows.Forms.Button btnOmdbApiEdit;
        private System.Windows.Forms.Button btnOmdbApiSave;
        private System.Windows.Forms.LinkLabel omdbLink;
        private System.Windows.Forms.Button btnSaveFastPath;
        private System.Windows.Forms.Button btnRemoveFastPath;
    }
}