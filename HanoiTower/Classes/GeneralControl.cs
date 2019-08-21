using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace HanoiTower
{
    public enum Brightness
    {
        darkened,
        lightened
    };

    class GeneralControl
    {
        private Color currentDiskColor;
        public Color CurrentDiskColor
        {
            get { return currentDiskColor; }
            set { currentDiskColor = value; }
        }
        
        private object currentDisk;
        public object CurrentDisk
        {
            get { return currentDisk; }
            set { currentDisk = value; }
        }

        private Brightness brightnessType;
        public Brightness BrightnessType
        {
            get { return brightnessType; }
            set { brightnessType = value; }
        }

        private object sourcePeg;
        public object SourcePeg
        {
            get { return sourcePeg; }
            set { sourcePeg = value; }
        }

        private int sourcePegNumber; //This represents which peg the button came from
        public int SourcePegNumber
        {
            get { return sourcePegNumber; }
            set { sourcePegNumber = value; }
        }

        private object pegDestination; //This represents the peg to which the user moved the disk
        public object PegDestination
        {
            get { return pegDestination; }
            set { pegDestination = value; }
        }

        private int destinationPegNumber; //This represents the number of the peg to which the user moved the disk
        public int DestinationPegNumber
        {
            get { return destinationPegNumber; }
            set { destinationPegNumber = value; }
        }

        #region Undo information
        //Variables used to undo a movement (move the disk back to its last position):
        private object lastDisk; 
        public object LastDisk
        {
            get { return lastDisk; }
            set { lastDisk = value; }
        }

        private object lastPeg;
        public object LastPeg
        {
            get { return lastPeg; }
            set { lastPeg = value; }
        }
        #endregion

        private bool move;
        public bool Move
        {
            get { return move; }
            set { move = value; }
        }

        private EventHandler pegclickEvent;
        public EventHandler PegClickEvent
        {
            get { return pegclickEvent; }
            set { pegclickEvent = value; }
        }

        private EventHandler disk1clickEvent;
        public EventHandler Disk1ClickEvent
        {
            get { return disk1clickEvent; }
            set { disk1clickEvent = value; }
        }

        private EventHandler disk2clickEvent;
        public EventHandler Disk2ClickEvent
        {
            get { return disk2clickEvent; }
            set { disk2clickEvent = value; }
        }

        private List<Button> disks;
        public List<Button> Disks
        {
            get { return disks; }
            set { disks = value; }
        }

        private List<Button> disks2;
        public List<Button> Disks2
        {
            get { return disks2; }
            set { disks2 = value; }
        }

        private List<Button> disks3;
        public List<Button> Disks3
        {
            get { return disks3; }
            set { disks3 = value; }
        }

        private Button[] pegs;
        public Button[] Pegs
        {
            get { return pegs; }
            set { pegs = value; }
        }
    }
}
