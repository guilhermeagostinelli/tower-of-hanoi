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
    public partial class frmPause : Form
    {
        Preferences objPref = new Preferences();
        PreferencesDAL objPrefDAL = new PreferencesDAL();

        internal frmPause(int movements, string time, Preferences objPref)
        {
            InitializeComponent();

            this.objPref = objPref;

            #region Modifying Fonts
            HelperClass.AllocFont(this.lblTime, 12);
            HelperClass.AllocFont(this.lblMovements, 12);
            #endregion

            lblMovements.Text = movements.ToString();
            lblTime.Text = time;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            this.Close();
        }

        private void frmPause_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pbClose_Click(null, null);
        }
    }
}
