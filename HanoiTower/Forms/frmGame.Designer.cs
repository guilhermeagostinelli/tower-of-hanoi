namespace HanoiTower
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.ssGame = new System.Windows.Forms.StatusStrip();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.lblElapsedTimeCounter = new System.Windows.Forms.Label();
            this.lblMovement = new System.Windows.Forms.Label();
            this.lblMovementCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmr_time
            // 
            this.tmr_time.Enabled = true;
            this.tmr_time.Interval = 1000;
            this.tmr_time.Tick += new System.EventHandler(this.tmr_time_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackgroundImage = global::HanoiTower.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Location = new System.Drawing.Point(797, 375);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(131, 61);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.MouseHover += new System.EventHandler(this.btnPause_MouseHover);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.BackgroundImage = global::HanoiTower.Properties.Resources.Main_Screen_Arrow;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(58, 55);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnReturn.MouseHover += new System.EventHandler(this.btnReturn_MouseHover);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUndo.BackColor = System.Drawing.Color.White;
            this.btnUndo.BackgroundImage = global::HanoiTower.Properties.Resources.Return_Arrow___disabled;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(364, 454);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(40, 38);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            this.btnUndo.MouseHover += new System.EventHandler(this.btnUndo_MouseHover);
            // 
            // ssGame
            // 
            this.ssGame.AutoSize = false;
            this.ssGame.BackColor = System.Drawing.Color.White;
            this.ssGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ssGame.Location = new System.Drawing.Point(0, 451);
            this.ssGame.Name = "ssGame";
            this.ssGame.Size = new System.Drawing.Size(940, 44);
            this.ssGame.TabIndex = 6;
            this.ssGame.Text = "statusStrip1";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.BackColor = System.Drawing.Color.White;
            this.lblElapsedTime.Location = new System.Drawing.Point(12, 467);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(74, 13);
            this.lblElapsedTime.TabIndex = 7;
            this.lblElapsedTime.Text = "Elapsed Time:";
            // 
            // lblElapsedTimeCounter
            // 
            this.lblElapsedTimeCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblElapsedTimeCounter.AutoSize = true;
            this.lblElapsedTimeCounter.BackColor = System.Drawing.Color.White;
            this.lblElapsedTimeCounter.Location = new System.Drawing.Point(145, 468);
            this.lblElapsedTimeCounter.Name = "lblElapsedTimeCounter";
            this.lblElapsedTimeCounter.Size = new System.Drawing.Size(34, 13);
            this.lblElapsedTimeCounter.TabIndex = 8;
            this.lblElapsedTimeCounter.Text = "00:00";
            // 
            // lblMovement
            // 
            this.lblMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMovement.AutoSize = true;
            this.lblMovement.BackColor = System.Drawing.Color.White;
            this.lblMovement.Location = new System.Drawing.Point(224, 467);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(65, 13);
            this.lblMovement.TabIndex = 9;
            this.lblMovement.Text = "Movements:";
            // 
            // lblMovementCounter
            // 
            this.lblMovementCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMovementCounter.AutoSize = true;
            this.lblMovementCounter.BackColor = System.Drawing.Color.White;
            this.lblMovementCounter.Location = new System.Drawing.Point(327, 468);
            this.lblMovementCounter.Name = "lblMovementCounter";
            this.lblMovementCounter.Size = new System.Drawing.Size(13, 13);
            this.lblMovementCounter.TabIndex = 10;
            this.lblMovementCounter.Text = "0";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::HanoiTower.Properties.Resources.Main_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 495);
            this.Controls.Add(this.lblMovementCounter);
            this.Controls.Add(this.lblMovement);
            this.Controls.Add(this.lblElapsedTimeCounter);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.ssGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tower of Hanoi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmGame_MouseClick);
            this.Controls.SetChildIndex(this.ssGame, 0);
            this.Controls.SetChildIndex(this.btnPause, 0);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.btnUndo, 0);
            this.Controls.SetChildIndex(this.lblElapsedTime, 0);
            this.Controls.SetChildIndex(this.lblElapsedTimeCounter, 0);
            this.Controls.SetChildIndex(this.lblMovement, 0);
            this.Controls.SetChildIndex(this.lblMovementCounter, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_time;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.StatusStrip ssGame;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label lblElapsedTimeCounter;
        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.Label lblMovementCounter;
    }
}

