namespace DirectorySolutions
{
    partial class FindExtension
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
            this.brnFileExtSearch = new System.Windows.Forms.Button();
            this.findExtLbl = new System.Windows.Forms.Label();
            this.findExtTxt = new System.Windows.Forms.TextBox();
            this.findExtErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.findExtErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // brnFileExtSearch
            // 
            this.brnFileExtSearch.Location = new System.Drawing.Point(342, 14);
            this.brnFileExtSearch.Name = "brnFileExtSearch";
            this.brnFileExtSearch.Size = new System.Drawing.Size(75, 23);
            this.brnFileExtSearch.TabIndex = 5;
            this.brnFileExtSearch.Text = "Search";
            this.brnFileExtSearch.UseVisualStyleBackColor = true;
            this.brnFileExtSearch.Click += new System.EventHandler(this.brnFileExtSearch_Click);
            // 
            // findExtLbl
            // 
            this.findExtLbl.AutoSize = true;
            this.findExtLbl.Location = new System.Drawing.Point(13, 17);
            this.findExtLbl.Name = "findExtLbl";
            this.findExtLbl.Size = new System.Drawing.Size(56, 13);
            this.findExtLbl.TabIndex = 4;
            this.findExtLbl.Text = "Extension:";
            // 
            // findExtTxt
            // 
            this.findExtTxt.Location = new System.Drawing.Point(75, 14);
            this.findExtTxt.Name = "findExtTxt";
            this.findExtTxt.Size = new System.Drawing.Size(244, 20);
            this.findExtTxt.TabIndex = 3;
            // 
            // findExtErrorProv
            // 
            this.findExtErrorProv.ContainerControl = this;
            // 
            // FindExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.brnFileExtSearch);
            this.Controls.Add(this.findExtLbl);
            this.Controls.Add(this.findExtTxt);
            this.Name = "FindExtension";
            this.Size = new System.Drawing.Size(431, 50);
            ((System.ComponentModel.ISupportInitialize)(this.findExtErrorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnFileExtSearch;
        private System.Windows.Forms.Label findExtLbl;
        private System.Windows.Forms.TextBox findExtTxt;
        private System.Windows.Forms.ErrorProvider findExtErrorProv;
    }
}
