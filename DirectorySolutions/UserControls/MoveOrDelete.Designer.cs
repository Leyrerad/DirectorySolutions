namespace DirectorySolutions.UserControls
{
    partial class MoveOrDelete
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.btnOpenPathMove = new System.Windows.Forms.Button();
            this.fastPathMenuStripMoveDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.movePathTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.movePathTxtErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDeleteFiles = new System.Windows.Forms.Button();
            this.destinationPathsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movePathTxtErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(891, 18);
            this.label9.TabIndex = 58;
            this.label9.Text = "These controls allow you to move, copy, or delete your full file list.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(891, 26);
            this.label8.TabIndex = 57;
            this.label8.Text = "Move, Copy, or Delete Files";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Location = new System.Drawing.Point(33, 104);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(109, 23);
            this.btnMoveFiles.TabIndex = 62;
            this.btnMoveFiles.Text = "Move";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // btnOpenPathMove
            // 
            this.btnOpenPathMove.ContextMenuStrip = this.fastPathMenuStripMoveDelete;
            this.btnOpenPathMove.Location = new System.Drawing.Point(433, 60);
            this.btnOpenPathMove.Name = "btnOpenPathMove";
            this.btnOpenPathMove.Size = new System.Drawing.Size(88, 23);
            this.btnOpenPathMove.TabIndex = 61;
            this.btnOpenPathMove.Text = "Open";
            this.btnOpenPathMove.UseVisualStyleBackColor = true;
            this.btnOpenPathMove.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // fastPathMenuStripMoveDelete
            // 
            this.fastPathMenuStripMoveDelete.Name = "fastPathMenuStrip";
            this.fastPathMenuStripMoveDelete.Size = new System.Drawing.Size(61, 4);
            // 
            // movePathTxt
            // 
            this.movePathTxt.Location = new System.Drawing.Point(71, 62);
            this.movePathTxt.Name = "movePathTxt";
            this.movePathTxt.Size = new System.Drawing.Size(347, 20);
            this.movePathTxt.TabIndex = 60;
            this.movePathTxt.TextChanged += new System.EventHandler(this.movePathTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "Path:";
            // 
            // movePathTxtErrorProv
            // 
            this.movePathTxtErrorProv.ContainerControl = this;
            // 
            // btnDeleteFiles
            // 
            this.btnDeleteFiles.Location = new System.Drawing.Point(333, 145);
            this.btnDeleteFiles.Name = "btnDeleteFiles";
            this.btnDeleteFiles.Size = new System.Drawing.Size(188, 23);
            this.btnDeleteFiles.TabIndex = 63;
            this.btnDeleteFiles.Text = "Delete Files In List";
            this.btnDeleteFiles.UseVisualStyleBackColor = true;
            this.btnDeleteFiles.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // destinationPathsLayout
            // 
            this.destinationPathsLayout.AutoScroll = true;
            this.destinationPathsLayout.Location = new System.Drawing.Point(550, 76);
            this.destinationPathsLayout.Name = "destinationPathsLayout";
            this.destinationPathsLayout.Size = new System.Drawing.Size(321, 92);
            this.destinationPathsLayout.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Paths files will be copied or moved to:";
            // 
            // MoveOrDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationPathsLayout);
            this.Controls.Add(this.btnDeleteFiles);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.btnOpenPathMove);
            this.Controls.Add(this.movePathTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "MoveOrDelete";
            this.Size = new System.Drawing.Size(891, 180);
            ((System.ComponentModel.ISupportInitialize)(this.movePathTxtErrorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Button btnOpenPathMove;
        private System.Windows.Forms.TextBox movePathTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider movePathTxtErrorProv;
        private System.Windows.Forms.ContextMenuStrip fastPathMenuStripMoveDelete;
        private System.Windows.Forms.Button btnDeleteFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel destinationPathsLayout;
    }
}
