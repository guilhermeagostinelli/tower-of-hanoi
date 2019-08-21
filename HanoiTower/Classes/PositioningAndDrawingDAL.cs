using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace HanoiTower
{
    class PositioningAndDrawingDAL
    {
        public void PositionAdjustment(PositioningAndDrawing objPAD, Preferences objPref)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            /* PATTERNS:
             * 
             * DISKS:
             * Width: 2,34% of screen width 
             * Height: 2,9% of screen height
             * 
             * PEGS:
             * Width: same as disk width
             * Height: (number of disks + 2) * disk height
             * Central peg: 50% of screen width - (peg width/2) 
             * Distance between pegs: 19,5% of screen width (number of disks =< 7) or 25% of screen width (number of disks > 7)
             * 
             * CORRECTION FACTOR:
             * 48,8% of screen height
             */

            objPAD.DiskWidth = Convert.ToInt16(0.0234 * screenWidth);
            objPAD.DiskHeight = Convert.ToInt16(0.029 * screenHeight);

            objPAD.PegWidth = Convert.ToInt16(0.0234 * screenWidth);
            objPAD.PegHeight = Convert.ToInt16( (objPref.NumberOfDisks + 2) * 0.029 * screenHeight);
            objPAD.CentralPegHorizontalLocation = Convert.ToInt16((0.5 * screenWidth) - (objPAD.PegWidth / 2));

            if(objPref.NumberOfDisks <= 7)
                objPAD.DistanceBetweenPegs = Convert.ToInt16(0.195 * screenWidth);
            else
                objPAD.DistanceBetweenPegs = Convert.ToInt16(0.25 * screenWidth);

            objPAD.CorrectionFactor = Convert.ToInt16(0.488 * screenHeight);
        }

        public List<Button> CreateButtons(PositioningAndDrawing objPAD, GeneralControl objGC, Preferences objPref)
        {
            List<Button> list = new List<Button>(); //List of buttons to be returned

            for (int btnNumber = objPref.NumberOfDisks; btnNumber > 0; btnNumber--)
            {

                Button btn = new Button();

                btn.Name = "btn_" + btnNumber.ToString();
                btn.Size = new System.Drawing.Size(objPAD.DiskWidth * btnNumber, objPAD.DiskHeight);

                int difference = btn.Size.Width - objPAD.PegWidth;
                int primary_alignment = difference / 2;
                int final_alignment = objPAD.CentralPegHorizontalLocation - objPAD.DistanceBetweenPegs - primary_alignment;

                btn.Location = new System.Drawing.Point(final_alignment, objPAD.DiskHeight * btnNumber + objPAD.CorrectionFactor);
                btn.BackColor = objPAD.DiskColor[btnNumber];
                btn.FlatStyle = FlatStyle.Flat;

                if (btnNumber == 1)
                    btn.Click += new System.EventHandler(objGC.Disk1ClickEvent);
                else
                    btn.Click += new System.EventHandler(objGC.Disk2ClickEvent);

                list.Add(btn);
            }

            return list;
        }

        public Button DrawPegs(PositioningAndDrawing objPAD, GeneralControl objGC, int i)
        {
            Button peg = new Button();

            peg.Name = "btn_peg" + i.ToString();
            #region Location:
            switch (i)
            {
                case 0:
                    peg.Location = new System.Drawing.Point(objPAD.CentralPegHorizontalLocation - objPAD.DistanceBetweenPegs, objPAD.CorrectionFactor);
                    break;
                case 1:
                    peg.Location = new System.Drawing.Point(objPAD.CentralPegHorizontalLocation, objPAD.CorrectionFactor);
                    break;
                default: //case 2
                    peg.Location = new System.Drawing.Point(objPAD.CentralPegHorizontalLocation + objPAD.DistanceBetweenPegs, objPAD.CorrectionFactor);
                    break;
            }
            #endregion
            peg.Size = new System.Drawing.Size(objPAD.PegWidth, objPAD.PegHeight);
            peg.BackColor = Color.Black;
            peg.Click += new System.EventHandler(objGC.PegClickEvent);
            objGC.Pegs[i] = peg;

            return peg;
        }
    }
}
