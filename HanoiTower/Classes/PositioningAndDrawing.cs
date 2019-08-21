using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiTower
{
    class PositioningAndDrawing
    {
        #region Disks
        private int diskWidth;
        public int DiskWidth
        {
            get { return diskWidth; }
            set { diskWidth = value; }
        }

        private int diskHeight;
        public int DiskHeight
        {
            get { return diskHeight; }
            set { diskHeight = value; }
        }

        private System.Drawing.Color[] diskColor;
        public System.Drawing.Color[] DiskColor
        {
            get { return diskColor; }
            set { diskColor = value; }
        }
        #endregion

        #region Pegs
        private int pegWidth;
        public int PegWidth
        {
            get { return pegWidth; }
            set { pegWidth = value; }
        }

        private int pegHeight;
        public int PegHeight
        {
            get { return pegHeight; }
            set { pegHeight = value; }
        }

        private int centralPegHorizontalLocation;
        public int CentralPegHorizontalLocation
        {
            get { return centralPegHorizontalLocation; }
            set { centralPegHorizontalLocation = value; }
        }

        private int distanceBetweenPegs;
        public int DistanceBetweenPegs
        {
            get { return distanceBetweenPegs; }
            set { distanceBetweenPegs = value; }
        }
        
        private int correctionFactor;
        public int CorrectionFactor
        {
            get { return correctionFactor; }
            set { correctionFactor = value; }
        }
        
        private int numberOfPegs;
        public int NumberOfPegs
        {
            get { return numberOfPegs; }
            set { numberOfPegs = value; }
        }
        #endregion
    }
}
