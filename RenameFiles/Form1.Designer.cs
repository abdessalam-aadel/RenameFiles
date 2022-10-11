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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.labelTextTotales = new System.Windows.Forms.Label();
            this.txtTotales = new System.Windows.Forms.Label();
            this.labelGit = new System.Windows.Forms.Label();
            this.txtBoxLoad = new System.Windows.Forms.TextBox();
            this.txtDone = new System.Windows.Forms.Label();
            this.picArrowDown = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.checkJPG = new System.Windows.Forms.RadioButton();
            this.checkTIF = new System.Windows.Forms.RadioButton();
            this.labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Teal;
            this.btnLoad.Location = new System.Drawing.Point(306, 19);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 20);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load ...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRename
            // 
            this.btnRename.BackColor = System.Drawing.Color.Tomato;
            this.btnRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRename.FlatAppearance.BorderSize = 0;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.ForeColor = System.Drawing.Color.Moccasin;
            this.btnRename.Location = new System.Drawing.Point(12, 58);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(288, 23);
            this.btnRename.TabIndex = 1;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // labelTextTotales
            // 
            this.labelTextTotales.AutoSize = true;
            this.labelTextTotales.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelTextTotales.Location = new System.Drawing.Point(94, 84);
            this.labelTextTotales.Name = "labelTextTotales";
            this.labelTextTotales.Size = new System.Drawing.Size(105, 13);
            this.labelTextTotales.TabIndex = 2;
            this.labelTextTotales.Text = "Totales images files :";
            // 
            // txtTotales
            // 
            this.txtTotales.AutoSize = true;
            this.txtTotales.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTotales.Location = new System.Drawing.Point(196, 84);
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
            this.labelGit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelGit.Location = new System.Drawing.Point(173, 100);
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
            this.txtBoxLoad.Location = new System.Drawing.Point(12, 19);
            this.txtBoxLoad.Name = "txtBoxLoad";
            this.txtBoxLoad.Size = new System.Drawing.Size(288, 20);
            this.txtBoxLoad.TabIndex = 5;
            this.txtBoxLoad.Text = "Choose your folder ....";
            // 
            // txtDone
            // 
            this.txtDone.AutoSize = true;
            this.txtDone.BackColor = System.Drawing.Color.Transparent;
            this.txtDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDone.ForeColor = System.Drawing.Color.Maroon;
            this.txtDone.Location = new System.Drawing.Point(320, 77);
            this.txtDone.Name = "txtDone";
            this.txtDone.Size = new System.Drawing.Size(0, 13);
            this.txtDone.TabIndex = 6;
            // 
            // picArrowDown
            // 
            this.picArrowDown.BackColor = System.Drawing.Color.Transparent;
            this.picArrowDown.Image = global::RenameFiles.Properties.Resources.Arrows_down_animated;
            this.picArrowDown.Location = new System.Drawing.Point(313, 56);
            this.picArrowDown.Name = "picArrowDown";
            this.picArrowDown.Size = new System.Drawing.Size(62, 50);
            this.picArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrowDown.TabIndex = 7;
            this.picArrowDown.TabStop = false;
            this.picArrowDown.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tomato;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // picCheck
            // 
            this.picCheck.BackColor = System.Drawing.Color.Transparent;
            this.picCheck.Image = ((System.Drawing.Image)(resources.GetObject("picCheck.Image")));
            this.picCheck.Location = new System.Drawing.Point(362, 73);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(19, 20);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 9;
            this.picCheck.TabStop = false;
            this.picCheck.Visible = false;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPath.Location = new System.Drawing.Point(9, 3);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(35, 13);
            this.labelPath.TabIndex = 10;
            this.labelPath.Text = "Path :";
            // 
            // checkJPG
            // 
            this.checkJPG.AutoSize = true;
            this.checkJPG.BackColor = System.Drawing.Color.Transparent;
            this.checkJPG.Checked = true;
            this.checkJPG.Location = new System.Drawing.Point(110, 41);
            this.checkJPG.Name = "checkJPG";
            this.checkJPG.Size = new System.Drawing.Size(45, 17);
            this.checkJPG.TabIndex = 14;
            this.checkJPG.TabStop = true;
            this.checkJPG.Text = "JPG";
            this.checkJPG.UseVisualStyleBackColor = false;
            this.checkJPG.CheckedChanged += new System.EventHandler(this.checkJPG_CheckedChanged);
            // 
            // checkTIF
            // 
            this.checkTIF.AutoSize = true;
            this.checkTIF.BackColor = System.Drawing.Color.Transparent;
            this.checkTIF.Location = new System.Drawing.Point(176, 41);
            this.checkTIF.Name = "checkTIF";
            this.checkTIF.Size = new System.Drawing.Size(41, 17);
            this.checkTIF.TabIndex = 15;
            this.checkTIF.Text = "TIF";
            this.checkTIF.UseVisualStyleBackColor = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelType.Location = new System.Drawing.Point(9, 41);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(95, 13);
            this.labelType.TabIndex = 16;
            this.labelType.Text = "Choose your type :";
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(388, 119);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.checkTIF);
            this.Controls.Add(this.checkJPG);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.picCheck);
            this.Controls.Add(this.txtDone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picArrowDown);
            this.Controls.Add(this.txtBoxLoad);
            this.Controls.Add(this.labelGit);
            this.Controls.Add(this.txtTotales);
            this.Controls.Add(this.labelTextTotales);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnLoad);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename multiple images files in multiple sub-folder";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragEnter);
            this.DragLeave += new System.EventHandler(this.FrmMain_DragLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picArrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
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
        private System.Windows.Forms.PictureBox picArrowDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.RadioButton checkJPG;
        private System.Windows.Forms.RadioButton checkTIF;
        private System.Windows.Forms.Label labelType;
    }
}

