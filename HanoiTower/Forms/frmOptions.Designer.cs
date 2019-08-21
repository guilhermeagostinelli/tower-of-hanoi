namespace HanoiTower
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.lblSound = new System.Windows.Forms.Label();
            this.lblNumberOfDisks = new System.Windows.Forms.Label();
            this.cmbNumberOfDisks = new System.Windows.Forms.ComboBox();
            this.gbTowerVisualization = new System.Windows.Forms.GroupBox();
            this.btnDisk1 = new System.Windows.Forms.Button();
            this.btnDisk2 = new System.Windows.Forms.Button();
            this.btnDisk3 = new System.Windows.Forms.Button();
            this.btnDisk4 = new System.Windows.Forms.Button();
            this.btnDisk5 = new System.Windows.Forms.Button();
            this.btnDisk6 = new System.Windows.Forms.Button();
            this.btnDisk7 = new System.Windows.Forms.Button();
            this.btnDisk8 = new System.Windows.Forms.Button();
            this.btnDisk9 = new System.Windows.Forms.Button();
            this.btnDisk10 = new System.Windows.Forms.Button();
            this.pbSound = new System.Windows.Forms.PictureBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cbUndo = new System.Windows.Forms.CheckBox();
            this.gbTowerVisualization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.BackColor = System.Drawing.Color.Transparent;
            this.lblSound.Location = new System.Drawing.Point(68, 98);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(38, 13);
            this.lblSound.TabIndex = 1;
            this.lblSound.Text = "Sound";
            // 
            // lblNumberOfDisks
            // 
            this.lblNumberOfDisks.AutoSize = true;
            this.lblNumberOfDisks.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfDisks.Location = new System.Drawing.Point(62, 230);
            this.lblNumberOfDisks.Name = "lblNumberOfDisks";
            this.lblNumberOfDisks.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfDisks.TabIndex = 2;
            this.lblNumberOfDisks.Text = "Number of disks";
            // 
            // cmbNumberOfDisks
            // 
            this.cmbNumberOfDisks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfDisks.FormattingEnabled = true;
            this.cmbNumberOfDisks.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumberOfDisks.Location = new System.Drawing.Point(64, 260);
            this.cmbNumberOfDisks.Name = "cmbNumberOfDisks";
            this.cmbNumberOfDisks.Size = new System.Drawing.Size(121, 21);
            this.cmbNumberOfDisks.TabIndex = 4;
            this.cmbNumberOfDisks.SelectedIndexChanged += new System.EventHandler(this.cmbNumberOfDisks_SelectedIndexChanged);
            // 
            // gbTowerVisualization
            // 
            this.gbTowerVisualization.BackColor = System.Drawing.Color.Transparent;
            this.gbTowerVisualization.Controls.Add(this.btnDisk1);
            this.gbTowerVisualization.Controls.Add(this.btnDisk2);
            this.gbTowerVisualization.Controls.Add(this.btnDisk3);
            this.gbTowerVisualization.Controls.Add(this.btnDisk4);
            this.gbTowerVisualization.Controls.Add(this.btnDisk5);
            this.gbTowerVisualization.Controls.Add(this.btnDisk6);
            this.gbTowerVisualization.Controls.Add(this.btnDisk7);
            this.gbTowerVisualization.Controls.Add(this.btnDisk8);
            this.gbTowerVisualization.Controls.Add(this.btnDisk9);
            this.gbTowerVisualization.Controls.Add(this.btnDisk10);
            this.gbTowerVisualization.Location = new System.Drawing.Point(456, 37);
            this.gbTowerVisualization.Name = "gbTowerVisualization";
            this.gbTowerVisualization.Size = new System.Drawing.Size(351, 408);
            this.gbTowerVisualization.TabIndex = 5;
            this.gbTowerVisualization.TabStop = false;
            this.gbTowerVisualization.Text = "Disk colors";
            // 
            // btnDisk1
            // 
            this.btnDisk1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk1.Location = new System.Drawing.Point(150, 41);
            this.btnDisk1.Name = "btnDisk1";
            this.btnDisk1.Size = new System.Drawing.Size(30, 29);
            this.btnDisk1.TabIndex = 9;
            this.btnDisk1.Text = "1";
            this.btnDisk1.UseVisualStyleBackColor = true;
            // 
            // btnDisk2
            // 
            this.btnDisk2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk2.Location = new System.Drawing.Point(135, 76);
            this.btnDisk2.Name = "btnDisk2";
            this.btnDisk2.Size = new System.Drawing.Size(60, 29);
            this.btnDisk2.TabIndex = 8;
            this.btnDisk2.Text = "2";
            this.btnDisk2.UseVisualStyleBackColor = true;
            // 
            // btnDisk3
            // 
            this.btnDisk3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk3.Location = new System.Drawing.Point(120, 111);
            this.btnDisk3.Name = "btnDisk3";
            this.btnDisk3.Size = new System.Drawing.Size(90, 29);
            this.btnDisk3.TabIndex = 7;
            this.btnDisk3.Text = "3";
            this.btnDisk3.UseVisualStyleBackColor = true;
            // 
            // btnDisk4
            // 
            this.btnDisk4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk4.Location = new System.Drawing.Point(105, 146);
            this.btnDisk4.Name = "btnDisk4";
            this.btnDisk4.Size = new System.Drawing.Size(120, 29);
            this.btnDisk4.TabIndex = 6;
            this.btnDisk4.Text = "4";
            this.btnDisk4.UseVisualStyleBackColor = true;
            // 
            // btnDisk5
            // 
            this.btnDisk5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk5.Location = new System.Drawing.Point(90, 181);
            this.btnDisk5.Name = "btnDisk5";
            this.btnDisk5.Size = new System.Drawing.Size(150, 29);
            this.btnDisk5.TabIndex = 5;
            this.btnDisk5.Text = "5";
            this.btnDisk5.UseVisualStyleBackColor = true;
            // 
            // btnDisk6
            // 
            this.btnDisk6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk6.Location = new System.Drawing.Point(75, 215);
            this.btnDisk6.Name = "btnDisk6";
            this.btnDisk6.Size = new System.Drawing.Size(180, 29);
            this.btnDisk6.TabIndex = 4;
            this.btnDisk6.Text = "6";
            this.btnDisk6.UseVisualStyleBackColor = true;
            // 
            // btnDisk7
            // 
            this.btnDisk7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk7.Location = new System.Drawing.Point(60, 251);
            this.btnDisk7.Name = "btnDisk7";
            this.btnDisk7.Size = new System.Drawing.Size(210, 29);
            this.btnDisk7.TabIndex = 3;
            this.btnDisk7.Text = "7";
            this.btnDisk7.UseVisualStyleBackColor = true;
            // 
            // btnDisk8
            // 
            this.btnDisk8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk8.Location = new System.Drawing.Point(45, 286);
            this.btnDisk8.Name = "btnDisk8";
            this.btnDisk8.Size = new System.Drawing.Size(240, 29);
            this.btnDisk8.TabIndex = 2;
            this.btnDisk8.Text = "8";
            this.btnDisk8.UseVisualStyleBackColor = true;
            // 
            // btnDisk9
            // 
            this.btnDisk9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk9.Location = new System.Drawing.Point(30, 321);
            this.btnDisk9.Name = "btnDisk9";
            this.btnDisk9.Size = new System.Drawing.Size(270, 29);
            this.btnDisk9.TabIndex = 1;
            this.btnDisk9.Text = "9";
            this.btnDisk9.UseVisualStyleBackColor = true;
            // 
            // btnDisk10
            // 
            this.btnDisk10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisk10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk10.Location = new System.Drawing.Point(15, 356);
            this.btnDisk10.Name = "btnDisk10";
            this.btnDisk10.Size = new System.Drawing.Size(300, 29);
            this.btnDisk10.TabIndex = 0;
            this.btnDisk10.Text = "10";
            this.btnDisk10.UseVisualStyleBackColor = true;
            // 
            // pbSound
            // 
            this.pbSound.BackColor = System.Drawing.Color.Transparent;
            this.pbSound.Image = global::HanoiTower.Properties.Resources.Sound___On;
            this.pbSound.Location = new System.Drawing.Point(67, 113);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(43, 42);
            this.pbSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSound.TabIndex = 3;
            this.pbSound.TabStop = false;
            this.pbSound.Click += new System.EventHandler(this.pbSound_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.White;
            this.btnDefault.FlatAppearance.BorderSize = 2;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDefault.Location = new System.Drawing.Point(818, 490);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(132, 35);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "Restore default settings";
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.BackgroundImage = global::HanoiTower.Properties.Resources.Main_Screen_Arrow;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(12, 7);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(49, 43);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cbUndo
            // 
            this.cbUndo.AutoSize = true;
            this.cbUndo.BackColor = System.Drawing.Color.Transparent;
            this.cbUndo.Checked = true;
            this.cbUndo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUndo.Location = new System.Drawing.Point(64, 365);
            this.cbUndo.Name = "cbUndo";
            this.cbUndo.Size = new System.Drawing.Size(131, 17);
            this.cbUndo.TabIndex = 8;
            this.cbUndo.Text = "Enable \"Undo\" button";
            this.cbUndo.UseVisualStyleBackColor = false;
            this.cbUndo.CheckedChanged += new System.EventHandler(this.cbUndo_CheckedChanged);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HanoiTower.Properties.Resources.Main_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 537);
            this.Controls.Add(this.cbUndo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.gbTowerVisualization);
            this.Controls.Add(this.cmbNumberOfDisks);
            this.Controls.Add(this.pbSound);
            this.Controls.Add(this.lblNumberOfDisks);
            this.Controls.Add(this.lblSound);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.gbTowerVisualization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label lblNumberOfDisks;
        private System.Windows.Forms.PictureBox pbSound;
        private System.Windows.Forms.ComboBox cmbNumberOfDisks;
        private System.Windows.Forms.GroupBox gbTowerVisualization;
        private System.Windows.Forms.Button btnDisk1;
        private System.Windows.Forms.Button btnDisk2;
        private System.Windows.Forms.Button btnDisk3;
        private System.Windows.Forms.Button btnDisk4;
        private System.Windows.Forms.Button btnDisk5;
        private System.Windows.Forms.Button btnDisk6;
        private System.Windows.Forms.Button btnDisk7;
        private System.Windows.Forms.Button btnDisk8;
        private System.Windows.Forms.Button btnDisk9;
        private System.Windows.Forms.Button btnDisk10;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox cbUndo;
    }
}