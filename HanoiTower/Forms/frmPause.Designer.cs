namespace HanoiTower
{
    partial class frmPause
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
            this.lblMovements = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovements
            // 
            this.lblMovements.AutoSize = true;
            this.lblMovements.BackColor = System.Drawing.Color.Transparent;
            this.lblMovements.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblMovements.Location = new System.Drawing.Point(133, 209);
            this.lblMovements.Name = "lblMovements";
            this.lblMovements.Size = new System.Drawing.Size(20, 20);
            this.lblMovements.TabIndex = 1;
            this.lblMovements.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblTime.Location = new System.Drawing.Point(327, 209);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00";
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = global::HanoiTower.Properties.Resources.X;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Location = new System.Drawing.Point(353, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(55, 46);
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // frmPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HanoiTower.Properties.Resources.Paused_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 285);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMovements);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmPause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_pause";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPause_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovements;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pbClose;
    }
}