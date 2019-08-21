namespace HanoiTower
{
    partial class frmWinner
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblScoreDisplay = new System.Windows.Forms.Label();
            this.lblTimeDisplay = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(265, 196);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(87, 197);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Your name:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(87, 56);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(70, 25);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(87, 112);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 25);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time:";
            // 
            // lblScoreDisplay
            // 
            this.lblScoreDisplay.AutoSize = true;
            this.lblScoreDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblScoreDisplay.Location = new System.Drawing.Point(328, 58);
            this.lblScoreDisplay.Name = "lblScoreDisplay";
            this.lblScoreDisplay.Size = new System.Drawing.Size(19, 25);
            this.lblScoreDisplay.TabIndex = 6;
            this.lblScoreDisplay.Text = "-";
            // 
            // lblTimeDisplay
            // 
            this.lblTimeDisplay.AutoSize = true;
            this.lblTimeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTimeDisplay.Location = new System.Drawing.Point(328, 114);
            this.lblTimeDisplay.Name = "lblTimeDisplay";
            this.lblTimeDisplay.Size = new System.Drawing.Size(19, 25);
            this.lblTimeDisplay.TabIndex = 7;
            this.lblTimeDisplay.Text = "-";
            // 
            // pbSave
            // 
            this.pbSave.BackColor = System.Drawing.Color.Transparent;
            this.pbSave.BackgroundImage = global::HanoiTower.Properties.Resources.Save;
            this.pbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSave.Location = new System.Drawing.Point(268, 259);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(204, 50);
            this.pbSave.TabIndex = 8;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = global::HanoiTower.Properties.Resources.X;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Location = new System.Drawing.Point(672, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(57, 49);
            this.pbClose.TabIndex = 9;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // frmWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::HanoiTower.Properties.Resources.Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 353);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.lblTimeDisplay);
            this.Controls.Add(this.lblScoreDisplay);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_winner";
            this.Load += new System.EventHandler(this.frm_winner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblScoreDisplay;
        private System.Windows.Forms.Label lblTimeDisplay;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbClose;
    }
}