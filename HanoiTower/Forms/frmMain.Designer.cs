namespace HanoiTower
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.pbOptions = new System.Windows.Forms.PictureBox();
            this.pbInstructions = new System.Windows.Forms.PictureBox();
            this.pbScores = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlay
            // 
            this.pbPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbPlay.BackColor = System.Drawing.Color.Transparent;
            this.pbPlay.BackgroundImage = global::HanoiTower.Properties.Resources.Play;
            this.pbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlay.Location = new System.Drawing.Point(342, 217);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(115, 36);
            this.pbPlay.TabIndex = 6;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbTitle.BackgroundImage = global::HanoiTower.Properties.Resources.Title;
            this.pbTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTitle.Location = new System.Drawing.Point(140, 30);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(520, 105);
            this.pbTitle.TabIndex = 7;
            this.pbTitle.TabStop = false;
            // 
            // pbOptions
            // 
            this.pbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbOptions.BackColor = System.Drawing.Color.Transparent;
            this.pbOptions.BackgroundImage = global::HanoiTower.Properties.Resources.Options;
            this.pbOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOptions.Location = new System.Drawing.Point(342, 259);
            this.pbOptions.Name = "pbOptions";
            this.pbOptions.Size = new System.Drawing.Size(115, 36);
            this.pbOptions.TabIndex = 8;
            this.pbOptions.TabStop = false;
            this.pbOptions.Click += new System.EventHandler(this.pbOptions_Click);
            // 
            // pbInstructions
            // 
            this.pbInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbInstructions.BackColor = System.Drawing.Color.Transparent;
            this.pbInstructions.BackgroundImage = global::HanoiTower.Properties.Resources.Instructions;
            this.pbInstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbInstructions.Location = new System.Drawing.Point(342, 301);
            this.pbInstructions.Name = "pbInstructions";
            this.pbInstructions.Size = new System.Drawing.Size(115, 36);
            this.pbInstructions.TabIndex = 9;
            this.pbInstructions.TabStop = false;
            this.pbInstructions.Click += new System.EventHandler(this.pbInstructions_Click);
            // 
            // pbScores
            // 
            this.pbScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbScores.BackColor = System.Drawing.Color.Transparent;
            this.pbScores.BackgroundImage = global::HanoiTower.Properties.Resources.Top_Scores;
            this.pbScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbScores.Location = new System.Drawing.Point(342, 343);
            this.pbScores.Name = "pbScores";
            this.pbScores.Size = new System.Drawing.Size(115, 36);
            this.pbScores.TabIndex = 10;
            this.pbScores.TabStop = false;
            this.pbScores.Click += new System.EventHandler(this.pbScores_Click);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.BackgroundImage = global::HanoiTower.Properties.Resources.Exit;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbExit.Location = new System.Drawing.Point(342, 385);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(115, 36);
            this.pbExit.TabIndex = 11;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HanoiTower.Properties.Resources.Main_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 457);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbScores);
            this.Controls.Add(this.pbInstructions);
            this.Controls.Add(this.pbOptions);
            this.Controls.Add(this.pbTitle);
            this.Controls.Add(this.pbPlay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower of Hanoi";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.PictureBox pbOptions;
        private System.Windows.Forms.PictureBox pbInstructions;
        private System.Windows.Forms.PictureBox pbScores;
        private System.Windows.Forms.PictureBox pbExit;
    }
}