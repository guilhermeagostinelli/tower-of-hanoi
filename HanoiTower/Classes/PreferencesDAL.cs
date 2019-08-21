using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace HanoiTower
{
    class PreferencesDAL
    {
        public void DisableSound(Preferences objPref)
        {
            objPref.SoundState = false;

            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = System.IO.Path.Combine(appPath, "App.config");
            System.Configuration.ExeConfigurationFileMap configFileMap = new System.Configuration.ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            System.Configuration.Configuration config =
                System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(configFileMap, System.Configuration.ConfigurationUserLevel.None);

            config.AppSettings.Settings["soundState"].Value = false.ToString();
            config.Save();
        }
    }
}
