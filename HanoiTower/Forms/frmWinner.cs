using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace HanoiTower
{
    public partial class frmWinner : Form
    {
        Preferences objPref = new Preferences();
        PreferencesDAL objPrefDAL = new PreferencesDAL();

        Records objRec = new Records();
        RecordsDAL objRecDAL = new RecordsDAL();

        internal frmWinner(Records rec, Preferences objPref)
        {
            InitializeComponent();

            this.objPref = objPref;
            this.objRec = rec;

            #region Modifying Font
            HelperClass.AllocFont(this.txtName, 15);
            HelperClass.AllocFont(this.lblName, 15);
            HelperClass.AllocFont(this.lblScore, 15);
            HelperClass.AllocFont(this.lblScoreDisplay, 15);
            HelperClass.AllocFont(this.lblTime, 15);
            HelperClass.AllocFont(this.lblTimeDisplay, 15);
            #endregion

            lblScoreDisplay.Text = rec.PlayerScore.ToString();
            lblTimeDisplay.Text = rec.ElapsedPlayingTime;
        }

        private void frm_winner_Load(object sender, EventArgs e)
        {
            objRecDAL.MinAndSecSeparation(objRec);
            RecordCheck();
        }

        private void RecordCheck()
        {
            try
            {
                if (!objRecDAL.RecordGeneralCheck(objRec, objPref))
                {
                    MessageBox.Show("Sorry, you didn't break any records.\nClick OK to close the game.", "Tower completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (IOException ioEx)
            {
                if (DialogResult.Retry == MessageBox.Show(ioEx.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                {
                    RecordCheck();
                }
                else // User clicked on Cancel button
                {
                    this.Close();
                }
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            objRec.PlayerName = txtName.Text;

            try
            {
                objRecDAL.Save(objRec, objPref);
                MessageBox.Show("Click OK to close the game.", "Record saved successfully!");
                this.Close();
            }
            catch (IOException ioEx)
            {
                MessageBox.Show(ioEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbSave_Click(null, null);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            this.Close();
        }
    }
}
