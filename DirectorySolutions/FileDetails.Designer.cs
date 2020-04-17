namespace DirectorySolutions
{
    partial class FileDetails
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.allFieldsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnSave);
            this.flowLayoutPanel3.Controls.Add(this.btnOpen);
            this.flowLayoutPanel3.Controls.Add(this.btnClose);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(632, 493);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(263, 33);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save File Name";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(104, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(185, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // allFieldsLayout
            // 
            this.allFieldsLayout.AutoScroll = true;
            this.allFieldsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.allFieldsLayout.Location = new System.Drawing.Point(26, 3);
            this.allFieldsLayout.Name = "allFieldsLayout";
            this.allFieldsLayout.Size = new System.Drawing.Size(866, 484);
            this.allFieldsLayout.TabIndex = 5;
            this.allFieldsLayout.WrapContents = false;
            // 
            // FileDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 547);
            this.Controls.Add(this.allFieldsLayout);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "FileDetails";
            this.Text = "FileDetails";
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel allFieldsLayout;
    }
}