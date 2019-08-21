using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HanoiTower
{
    public partial class frmScores : Form
    {
        Preferences objPref = new Preferences();
        PreferencesDAL objPrefDAL = new PreferencesDAL();

        ToolTip ToolTipReturn = new ToolTip();

        internal frmScores(Preferences objPref)
        {
            InitializeComponent();
            this.objPref = objPref;

            #region Modifying Font
            HelperClass.AllocFont(this.msDiskSelection, 12);
            HelperClass.AllocFont(this.lvScores, 8);
            HelperClass.AllocFont(this.lblSelect, 10);
            #endregion
        }

        private void FillTopScoresList(object sender)
        {
            HelperClass.PlaySound(objPref);

            Records objRec = new Records();
            RecordsDAL objRecDAL = new RecordsDAL();

            #region Defining to what number of disks the scores will refer:
            int menuItemLength = ((ToolStripMenuItem)sender).Name.Length;

            string menuItemNumber;
            if(menuItemLength == 23)
                menuItemNumber =((ToolStripMenuItem)sender).Name.Substring(22, 1);
            else // The number has two digits (i.g., 10)
                menuItemNumber = ((ToolStripMenuItem)sender).Name.Substring(22, 2);

            objPref.NumberOfDisksDesired = int.Parse(menuItemNumber);
            #endregion

            try
            {
                objRecDAL.GetTopPlayers(objRec, objPref);

                lvScores.Items.Clear();

                for (int i = 0; i < objRec.Players.Count; i++)
                {
                    ListViewItem item = new ListViewItem((i + 1).ToString());
                    item.SubItems.Add(objRec.Players[i]);
                    item.SubItems.Add(objRec.Scores[i].ToString());
                    item.SubItems.Add(objRec.Minutes[i] + ":" + objRec.Seconds[i]);

                    lvScores.Items.Add(item);
                }
            }
            catch (System.IO.FileNotFoundException)
            { 
                //Do nothing
            }
        }

        #region Click Events
        private void disksToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FillTopScoresList(sender);
        }

        private void disksToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FillTopScoresList(sender);
        }

        private void disksToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FillTopScoresList(sender);
        }

        private void disksToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FillTopScoresList(sender);
        }

        private void disksToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FillTopScoresList(sender);
        }

        private void disksToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FillTopScoresList(sender);
        }

        private void disksToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FillTopScoresList(sender);
        }
        #endregion

        private void btnReturn_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            this.Close();
        }

        private void btnReturn_MouseHover(object sender, EventArgs e)
        {
            ToolTipReturn.SetToolTip(this.btnReturn, "Return to main screen");
        }
    }
}
