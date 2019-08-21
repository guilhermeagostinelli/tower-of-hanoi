using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration; // Besides that, adding the .NET reference (System.Configuration) is needed to use "ConfigurationManager"
using System.Reflection;

namespace HanoiTower
{
    public partial class frmOptions : Form
    {
        Preferences objPref = new Preferences();
        PreferencesDAL objPrefDAL = new PreferencesDAL();

        internal frmOptions(Preferences objPref)
        {
            InitializeComponent();
            this.objPref = objPref;

            #region Modifying Fonts
            HelperClass.AllocFont(this.lblSound, 8);
            HelperClass.AllocFont(this.lblNumberOfDisks, 8);
            HelperClass.AllocFont(this.cbUndo, 8);
            HelperClass.AllocFont(this.gbTowerVisualization, 8);
            HelperClass.AllocFont(this.btnDefault, 8);
            #endregion
            
            #region Adding events to disks
            btnDisk10.Click += disk_Click;
            btnDisk9.Click += disk_Click;
            btnDisk8.Click += disk_Click;
            btnDisk7.Click += disk_Click;
            btnDisk6.Click += disk_Click;
            btnDisk5.Click += disk_Click;
            btnDisk4.Click += disk_Click;
            btnDisk3.Click += disk_Click;
            btnDisk2.Click += disk_Click;
            btnDisk1.Click += disk_Click;
            #endregion
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            LoadPreferences();
        }

        private void LoadPreferences()
        {
            #region Loading DISK preferences

            foreach (Control gb in this.Controls.OfType<GroupBox>())
            {
                foreach (Control disk in gb.Controls.OfType<Button>())
                {
                    int diskNumber = int.Parse(disk.Text);
                    disk.BackColor = objPref.DiskColors[diskNumber];
                    ChangeForeColor(disk);
                }
            }

            cmbNumberOfDisks.Text = objPref.NumberOfDisks.ToString();
            #endregion

            #region Loading SOUND preferences
            if (objPref.SoundState == true)
                pbSound.Image = HanoiTower.Properties.Resources.Sound___On;
            else
                pbSound.Image = HanoiTower.Properties.Resources.Sound___Off;
            #endregion

            #region Loading BUTTON preferences
            if (objPref.UndoButton == true)
                cbUndo.Checked = true;
            else
                cbUndo.Checked = false;
            #endregion
        }

        private void disk_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            ColorDialog myDialog = new ColorDialog();
            myDialog.AllowFullOpen = true; // Let the user select a custom color
            myDialog.ShowHelp = false;
            myDialog.Color = ((Button)sender).BackColor;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = myDialog.Color;
                int diskNumber = int.Parse( ((Button)sender).Text );
                objPref.DiskColors[diskNumber] = myDialog.Color;

                ModifyConfiguration("disk" + diskNumber + "Color", myDialog.Color.ToArgb().ToString(), false);
            }

            ChangeForeColor(sender);
        }

        private void ChangeForeColor(object sender) // Changing ForeColor according to BackColor brightness
        {
            int R = ((Button)sender).BackColor.R;
            int G = ((Button)sender).BackColor.G;
            int B = ((Button)sender).BackColor.B;

            // Counting the perceptive luminance
            double luminance = 1 - (0.299 * R + 0.587 * G + 0.114 * B) / 255;

            if (luminance < 0.5) // Disk color is bright
                ((Button)sender).ForeColor = Color.Black;
            else
                ((Button)sender).ForeColor = Color.White;

        }
        
        private void btnDefault_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            ModifyConfiguration(null, null, true);

            LoadPreferences();
        }

        private void cmbNumberOfDisks_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPref.NumberOfDisks = int.Parse(cmbNumberOfDisks.Text);
            ModifyConfiguration("numberOfDisks", cmbNumberOfDisks.Text, false);
        }

        private void pbSound_Click(object sender, EventArgs e)
        {
            if (objPref.SoundState == false)
            {
                objPref.SoundState = true;
                HelperClass.PlaySound(objPref);
                ModifyConfiguration("soundState", true.ToString(), false);
                pbSound.Image = HanoiTower.Properties.Resources.Sound___On;
            }
            else
            {
                objPref.SoundState = false;
                ModifyConfiguration("soundState", false.ToString(), false);
                pbSound.Image = HanoiTower.Properties.Resources.Sound___Off;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            this.Close();
        }

        private void cbUndo_CheckedChanged(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            if (cbUndo.CheckState == CheckState.Unchecked)
            {
                objPref.UndoButton = false;
                ModifyConfiguration("undoButton", false.ToString(), false);
            }
            else
            {
                objPref.UndoButton = true;
                ModifyConfiguration("undoButton", true.ToString(), false);
            }
        }

        private void ModifyConfiguration(string key, string value, bool defaultConfiguration) // Modifying App.config
        {
            string appPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string configFile = System.IO.Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            System.Configuration.Configuration config =
                ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            if (defaultConfiguration == false)
            {
                config.AppSettings.Settings[key].Value = value;
            }
            else
            {
                for (int i = 1; i < 11; i++)
                {
                    config.AppSettings.Settings["disk" + i + "Color"].Value = ConfigurationManager.AppSettings["defaultDisk" + i + "Color"];
                    objPref.DiskColors[i] = Color.FromArgb(int.Parse(ConfigurationManager.AppSettings["defaultDisk" + i + "Color"]));
                }

                config.AppSettings.Settings["numberOfDisks"].Value = ConfigurationManager.AppSettings["defaultNumberOfDisks"];
                objPref.NumberOfDisks = int.Parse(config.AppSettings.Settings["numberOfDisks"].Value);

                config.AppSettings.Settings["soundState"].Value = ConfigurationManager.AppSettings["defaultSoundState"];
                objPref.SoundState = bool.Parse(config.AppSettings.Settings["soundState"].Value);

                config.AppSettings.Settings["undoButton"].Value = ConfigurationManager.AppSettings["defaultUndoButton"];
                objPref.UndoButton = bool.Parse(config.AppSettings.Settings["undoButton"].Value);
            }

            config.Save(); 
        }
    }
}
