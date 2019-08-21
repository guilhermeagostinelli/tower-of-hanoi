using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using HanoiTower.Properties;
using System.Drawing.Text;
using System.Windows.Forms;

namespace HanoiTower
{
    class HelperClass
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [In] ref uint pcFonts);
        private static FontFamily ff;
        private static Font font;

        public static void LoadFont(byte[] customFont)
        {
            byte[] fontArray = customFont;
            int dataLength = customFont.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);

            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;

            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptrData, dataLength);

            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Regular);
        }

        public static void AllocFont(Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(ff, size, fontStyle);
        }

        public static void PlaySound(Preferences objPref)
        {
            PreferencesDAL objPrefDAL = new PreferencesDAL();

            try
            {
                if (objPref.SoundState == true)
                {
                    System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(HanoiTower.Properties.Resources.sound);
                    simpleSound.Play();
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "\n\nPlease make sure that there's an audio file named 'sound.wav' inside folder 'Sounds' of your application directory.", "Audio reproduction error", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                objPrefDAL.DisableSound(objPref);
            }
        }
    }
}
