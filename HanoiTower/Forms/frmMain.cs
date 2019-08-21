using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;

namespace HanoiTower
{
    public partial class frmMain : Form
    {
        Preferences objPref = new Preferences();
        PreferencesDAL objPrefDAL = new PreferencesDAL();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //Loading custom font:
            HelperClass.LoadFont(HanoiTower.Properties.Resources.small_font_regular);

            // Loading user's preferences:
            objPref.SoundState = bool.Parse(ConfigurationManager.AppSettings["soundState"]);
            objPref.NumberOfDisks = int.Parse(ConfigurationManager.AppSettings["numberOfDisks"]);
            objPref.UndoButton = bool.Parse(ConfigurationManager.AppSettings["undoButton"]);
            
            objPref.DiskColors = new Color[11];
            for (int i = 1; i < 11; i++)
                objPref.DiskColors[i] = Color.FromArgb(int.Parse(ConfigurationManager.AppSettings["disk" + i + "Color"]));
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            frmGame objGame = new frmGame(objPref);
            this.Hide();
            objGame.ShowDialog();
            this.Show();
        }

        private void pbOptions_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            frmOptions objOptions = new frmOptions(objPref);
            this.Hide();
            objOptions.ShowDialog();
            this.Show();
        }

        private void pbInstructions_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            MessageBox.Show("The puzzle's main goal is to move disks from the leftmost peg onto the rightmost peg. " +
                                "However, bigger disks cannot be put on the top of smaller ones and only one disk may be moved at a time." +
                                "\n\nThe original Tower of Hanoi was invented in 1883 by the french mathematician Édouard Anatole Lucas, " +
                                "who was inspired by the Hindu myth which said that, after the priests completed the tiring task of finishing " +
                                "a tower of 64 disks, the world would vanish and everything would be turned into dust.");

            HelperClass.PlaySound(objPref);
        }

        private void pbScores_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            frmScores objScores = new frmScores(objPref);
            this.Hide();
            objScores.ShowDialog();
            this.Show();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdjustPosition(object obj)
        {
            Type t = obj.GetType();

            PropertyInfo[] pi = new PropertyInfo[2];
            pi[0] = t.GetProperty("Width");
            pi[1] = t.GetProperty("Left");

            int currentWidth = Convert.ToInt32(pi[0].GetValue(obj, null));
            int correction = 5;
            int newLeft = (this.Width - currentWidth) / 2 - correction;

            pi[1].SetValue(obj, newLeft, null);
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            //Adjusting position of all PictureBoxes:

            foreach (var obj in this.Controls)
            {
                AdjustPosition(obj);
            }
        }
    }
}
