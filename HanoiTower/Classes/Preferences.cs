using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HanoiTower
{
    class Preferences
    {
        private int numberOfDisks; // It specifies the quantity of disks that appear on a peg
        public int NumberOfDisks
        {
            get { return numberOfDisks; }
            set { numberOfDisks = value; }
        }

        private int numberOfDisksDesired; /* It specifies the quantity of disks that has appeared on a peg during the current game or
                                           * during an old one
                                           */
        public int NumberOfDisksDesired
        {
            get { return numberOfDisksDesired; }
            set { numberOfDisksDesired = value; }
        }
        
        private Color[] diskColors;
        public Color[] DiskColors
        {
            get { return diskColors; }
            set { diskColors = value; }
        }

        private bool soundState;
        public bool SoundState
        {
            get { return soundState; }
            set { soundState = value; }
        }

        private bool undoButton;
        public bool UndoButton
        {
            get { return undoButton; }
            set { undoButton = value; }
        }
    }   
}
