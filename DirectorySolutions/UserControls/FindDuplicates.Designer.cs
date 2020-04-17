namespace DirectorySolutions.UserControls
{
    partial class FindDuplicates
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(951, 18);
            this.label9.TabIndex = 74;
            this.label9.Text = "These controls allow you to find duplicate files across multiple directories.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(951, 26);
            this.label8.TabIndex = 73;
            this.label8.Text = "Find Duplicate Files";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FindDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "FindDuplicates";
            this.Size = new System.Drawing.Size(951, 212);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
