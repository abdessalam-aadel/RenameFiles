namespace RenameFiles
{
    partial class FrmMain
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.labelTextTotales = new System.Windows.Forms.Label();
            this.txtTotales = new System.Windows.Forms.Label();
            this.labelGit = new System.Windows.Forms.Label();
            this.txtBoxLoad = new System.Windows.Forms.TextBox();
            this.txtDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLoad.Location = new System.Drawing.Point(306, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load ...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRename
            // 
            this.btnRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRename.Location = new System.Drawing.Point(12, 38);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(288, 23);
            this.btnRename.TabIndex = 1;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // labelTextTotales
            // 
            this.labelTextTotales.AutoSize = true;
            this.labelTextTotales.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTextTotales.Location = new System.Drawing.Point(124, 64);
            this.labelTextTotales.Name = "labelTextTotales";
            this.labelTextTotales.Size = new System.Drawing.Size(72, 13);
            this.labelTextTotales.TabIndex = 2;
            this.labelTextTotales.Text = "Totales Files :";
            // 
            // txtTotales
            // 
            this.txtTotales.AutoSize = true;
            this.txtTotales.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotales.Location = new System.Drawing.Point(196, 64);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.Size = new System.Drawing.Size(16, 13);
            this.txtTotales.TabIndex = 3;
            this.txtTotales.Text = "...";
            // 
            // labelGit
            // 
            this.labelGit.AutoSize = true;
            this.labelGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelGit.Location = new System.Drawing.Point(177, 86);
            this.labelGit.Name = "labelGit";
            this.labelGit.Size = new System.Drawing.Size(38, 13);
            this.labelGit.TabIndex = 4;
            this.labelGit.Text = "Github";
            this.labelGit.Click += new System.EventHandler(this.labelGit_Click);
            // 
            // txtBoxLoad
            // 
            this.txtBoxLoad.AllowDrop = true;
            this.txtBoxLoad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxLoad.Location = new System.Drawing.Point(12, 12);
            this.txtBoxLoad.Name = "txtBoxLoad";
            this.txtBoxLoad.Size = new System.Drawing.Size(288, 20);
            this.txtBoxLoad.TabIndex = 5;
            this.txtBoxLoad.Text = "Chose your folde ....";
            // 
            // txtDone
            // 
            this.txtDone.AutoSize = true;
            this.txtDone.ForeColor = System.Drawing.Color.Maroon;
            this.txtDone.Location = new System.Drawing.Point(345, 64);
            this.txtDone.Name = "txtDone";
            this.txtDone.Size = new System.Drawing.Size(0, 13);
            this.txtDone.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(388, 103);
            this.Controls.Add(this.txtDone);
            this.Controls.Add(this.txtBoxLoad);
            this.Controls.Add(this.labelGit);
            this.Controls.Add(this.txtTotales);
            this.Controls.Add(this.labelTextTotales);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnLoad);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Multiple Files (JPG) in Multiples Folder";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label labelTextTotales;
        private System.Windows.Forms.Label txtTotales;
        private System.Windows.Forms.Label labelGit;
        private System.Windows.Forms.TextBox txtBoxLoad;
        private System.Windows.Forms.Label txtDone;
    }
}

