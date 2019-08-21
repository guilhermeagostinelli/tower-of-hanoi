namespace HanoiTower
{
    partial class frmScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScores));
            this.lvScores = new System.Windows.Forms.ListView();
            this.chPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMovements = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.msDiskSelection = new System.Windows.Forms.MenuStrip();
            this.disksToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.disksToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.disksToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.disksToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.disksToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.disksToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.disksToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.msDiskSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvScores
            // 
            this.lvScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPosition,
            this.chName,
            this.chMovements,
            this.chTime});
            this.lvScores.FullRowSelect = true;
            this.lvScores.GridLines = true;
            this.lvScores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvScores.Location = new System.Drawing.Point(139, 66);
            this.lvScores.Name = "lvScores";
            this.lvScores.Size = new System.Drawing.Size(351, 358);
            this.lvScores.TabIndex = 0;
            this.lvScores.UseCompatibleStateImageBehavior = false;
            this.lvScores.View = System.Windows.Forms.View.Details;
            // 
            // chPosition
            // 
            this.chPosition.Text = "";
            this.chPosition.Width = 29;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 129;
            // 
            // chMovements
            // 
            this.chMovements.Text = "Movements";
            this.chMovements.Width = 90;
            // 
            // chTime
            // 
            this.chTime.Text = "Elapsed Time";
            this.chTime.Width = 99;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::HanoiTower.Properties.Resources.Main_Screen_Arrow;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(52, 48);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnReturn.MouseHover += new System.EventHandler(this.btnReturn_MouseHover);
            // 
            // lblSelect
            // 
            this.lblSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelect.AutoSize = true;
            this.lblSelect.BackColor = System.Drawing.Color.Maroon;
            this.lblSelect.Location = new System.Drawing.Point(614, 9);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(95, 39);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Select the quantity\r\n\r\nof disks:";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msDiskSelection
            // 
            this.msDiskSelection.AutoSize = false;
            this.msDiskSelection.BackColor = System.Drawing.Color.Maroon;
            this.msDiskSelection.Dock = System.Windows.Forms.DockStyle.Right;
            this.msDiskSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disksToolStripMenuItem4,
            this.disksToolStripMenuItem5,
            this.disksToolStripMenuItem6,
            this.disksToolStripMenuItem7,
            this.disksToolStripMenuItem8,
            this.disksToolStripMenuItem9,
            this.disksToolStripMenuItem10});
            this.msDiskSelection.Location = new System.Drawing.Point(611, 0);
            this.msDiskSelection.Name = "msDiskSelection";
            this.msDiskSelection.Size = new System.Drawing.Size(174, 457);
            this.msDiskSelection.TabIndex = 4;
            this.msDiskSelection.Text = "menuStrip1";
            // 
            // disksToolStripMenuItem4
            // 
            this.disksToolStripMenuItem4.AutoSize = false;
            this.disksToolStripMenuItem4.Margin = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.disksToolStripMenuItem4.Name = "disksToolStripMenuItem4";
            this.disksToolStripMenuItem4.Size = new System.Drawing.Size(167, 50);
            this.disksToolStripMenuItem4.Text = "4 Disks";
            this.disksToolStripMenuItem4.Click += new System.EventHandler(this.disksToolStripMenuItem4_Click);
            // 
            // disksToolStripMenuItem5
            // 
            this.disksToolStripMenuItem5.AutoSize = false;
            this.disksToolStripMenuItem5.Name = "disksToolStripMenuItem5";
            this.disksToolStripMenuItem5.Size = new System.Drawing.Size(167, 50);
            this.disksToolStripMenuItem5.Text = "5 Disks";
            this.disksToolStripMenuItem5.Click += new System.EventHandler(this.disksToolStripMenuItem5_Click);
            // 
            // disksToolStripMenuItem6
            // 
            this.disksToolStripMenuItem6.AutoSize = false;
            this.disksToolStripMenuItem6.Name = "disksToolStripMenuItem6";
            this.disksToolStripMenuItem6.Size = new System.Drawing.Size(167, 50);
            this.disksToolStripMenuItem6.Text = "6 Disks";
            this.disksToolStripMenuItem6.Click += new System.EventHandler(this.disksToolStripMenuItem6_Click);
            // 
            // disksToolStripMenuItem7
            // 
            this.disksToolStripMenuItem7.AutoSize = false;
            this.disksToolStripMenuItem7.Name = "disksToolStripMenuItem7";
            this.disksToolStripMenuItem7.Size = new System.Drawing.Size(167, 50);
            this.disksToolStripMenuItem7.Text = "7 Disks";
            this.disksToolStripMenuItem7.Click += new System.EventHandler(this.disksToolStripMenuItem7_Click);
            // 
            // disksToolStripMenuItem8
            // 
            this.disksToolStripMenuItem8.AutoSize = false;
            this.disksToolStripMenuItem8.Name = "disksToolStripMenuItem8";
            this.disksToolStripMenuItem8.Size = new System.Drawing.Size(167, 50);
            this.disksToolStripMenuItem8.Text = "8 Disks";
            this.disksToolStripMenuItem8.Click += new System.EventHandler(this.disksToolStripMenuItem8_Click);
            // 
            // disksToolStripMenuItem9
            // 
            this.disksToolStripMenuItem9.AutoSize = false;
            this.disksToolStripMenuItem9.Name = "disksToolStripMenuItem9";
            this.disksToolStripMenuItem9.Size = new System.Drawing.Size(167, 50);
            this.disksToolStripMenuItem9.Text = "9 Disks";
            this.disksToolStripMenuItem9.Click += new System.EventHandler(this.disksToolStripMenuItem9_Click);
            // 
            // disksToolStripMenuItem10
            // 
            this.disksToolStripMenuItem10.AutoSize = false;
            this.disksToolStripMenuItem10.Name = "disksToolStripMenuItem10";
            this.disksToolStripMenuItem10.Size = new System.Drawing.Size(167, 50);
            this.disksToolStripMenuItem10.Text = "10 Disks";
            this.disksToolStripMenuItem10.Click += new System.EventHandler(this.disksToolStripMenuItem10_Click);
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HanoiTower.Properties.Resources.Main_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 457);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lvScores);
            this.Controls.Add(this.msDiskSelection);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msDiskSelection;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top Scores";
            this.msDiskSelection.ResumeLayout(false);
            this.msDiskSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvScores;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chMovements;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chPosition;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.MenuStrip msDiskSelection;
        private System.Windows.Forms.ToolStripMenuItem disksToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem disksToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem disksToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem disksToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem disksToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem disksToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem disksToolStripMenuItem10;
    }
}