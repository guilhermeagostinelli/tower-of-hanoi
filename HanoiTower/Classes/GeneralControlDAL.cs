using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace HanoiTower
{
    class GeneralControlDAL
    {
        enum LocationType   // Used to control disk location when moving it
        {
            defaultLocation,
            nonDefaultLocation
        }

        public void ChangeDiskBrightness(GeneralControl objGC)
        {
            if (objGC.BrightnessType == Brightness.lightened) // Lightening
            {
                Color color = ControlPaint.Light(((Button)objGC.CurrentDisk).BackColor);
                ((Button)objGC.CurrentDisk).BackColor = color;
            }
            else // Darkening
            {
                ((Button)objGC.CurrentDisk).BackColor = objGC.CurrentDiskColor;
            }
        }

        public void RemoveEvents(GeneralControl objGC)
        {
            /* Removing all the Click events and adding the Click2 event as default, while we don't know
             * which button is at the top of the peg:
            */

            foreach (Button bt in objGC.Disks)
            {
                bt.Click -= new System.EventHandler(objGC.Disk1ClickEvent);
                bt.Click += new System.EventHandler(objGC.Disk2ClickEvent);
            }
            foreach (Button bt in objGC.Disks2)
            {
                bt.Click -= new System.EventHandler(objGC.Disk1ClickEvent);
                bt.Click += new System.EventHandler(objGC.Disk2ClickEvent);
            }
            foreach (Button bt in objGC.Disks3)
            {
                bt.Click -= new System.EventHandler(objGC.Disk1ClickEvent);
                bt.Click += new System.EventHandler(objGC.Disk2ClickEvent);
            }
        }

        public void AddEvents(GeneralControl objGC)
        {
            // Adding the Click event and removing the Click2 event from the buttons that are at the top of the peg:

            if (objGC.Disks.Count != 0)
            {
                objGC.Disks[objGC.Disks.Count() - 1].Click -= new System.EventHandler(objGC.Disk2ClickEvent);
                objGC.Disks[objGC.Disks.Count() - 1].Click += new System.EventHandler(objGC.Disk1ClickEvent);
            }
            if (objGC.Disks2.Count != 0)
            {
                objGC.Disks2[objGC.Disks2.Count() - 1].Click -= new System.EventHandler(objGC.Disk2ClickEvent);
                objGC.Disks2[objGC.Disks2.Count() - 1].Click += new System.EventHandler(objGC.Disk1ClickEvent);
            }
            if (objGC.Disks3.Count != 0)
            {
                objGC.Disks3[objGC.Disks3.Count() - 1].Click -= new System.EventHandler(objGC.Disk2ClickEvent);
                objGC.Disks3[objGC.Disks3.Count() - 1].Click += new System.EventHandler(objGC.Disk1ClickEvent);
            }
        }

        private void GetSourcePeg(GeneralControl objGC)
        {
            bool sourcePegFound = false;

            foreach (Button bt in objGC.Disks)
            {
                if (bt == ((Button)objGC.CurrentDisk))
                {
                    objGC.SourcePeg = objGC.Pegs[0];
                    objGC.SourcePegNumber = 0;
                    sourcePegFound = true;
                    break;
                }
            }
            if (sourcePegFound == false)
            {
                foreach (Button bt in objGC.Disks2)
                {
                    if (bt == ((Button)objGC.CurrentDisk))
                    {
                        objGC.SourcePeg = objGC.Pegs[1];
                        objGC.SourcePegNumber = 1;
                        sourcePegFound = true;
                        break;
                    }
                }
            }
            if (sourcePegFound == false)
            {
                foreach (Button bt in objGC.Disks3)
                {
                    if (bt == ((Button)objGC.CurrentDisk))
                    {
                        objGC.SourcePeg = objGC.Pegs[2];
                        objGC.SourcePegNumber = 2;
                        sourcePegFound = true;
                        break;
                    }
                }
            }
        }

        public void MoveDisk(GeneralControl objGC, PositioningAndDrawing objPAD, Records objRec, Preferences objPref)
        {
            // Checking to see whether the source is the same than the destination:
            GetSourcePeg(objGC);

            if (objGC.DestinationPegNumber != objGC.SourcePegNumber)
            {
                // Checking to see if there's already a disk on the peg:
                bool diskOnPeg = CheckDisksOnPeg(objGC);
                
                if (diskOnPeg)
                {
                    // Checking to see if there's a smaller disk below:
                    bool smallDiskBelow = CheckSmallDiskBelow(objGC);

                    if (!smallDiskBelow)
                    {
                        SetDiskLocation(objGC, objPAD, objPref, LocationType.nonDefaultLocation);
                    }
                    else
                    {
                        throw new CustomExceptions("There's a smaller ring below the one you're trying to move.\n");
                    }
                }
                else
                {
                    // Default location based on the size of the disk:
                    SetDiskLocation(objGC, objPAD, objPref, LocationType.defaultLocation);
                }

                // Remove the disk from the source button list and add it to the destination list:
                ListModifying(objGC);
                
                DisableDisk(objGC);
            }
            else // It's the same peg, so it will be kept at the same position:
            {
                DisableDisk(objGC);
            }
        }

        private bool CheckDisksOnPeg(GeneralControl objGC) // Check to see if there's already a disk on the peg
        {
            bool diskOnPeg = false;

            switch (objGC.DestinationPegNumber)
            {
                case 0:
                    {
                        if (objGC.Disks.Count() != 0)
                        {
                            diskOnPeg = true;
                        }
                    }
                    break;
                case 1:
                    {
                        if (objGC.Disks2.Count() != 0)
                        {
                            diskOnPeg = true;
                        }
                    }
                    break;
                default: //case 2
                    {
                        if (objGC.Disks3.Count() != 0)
                        {
                            diskOnPeg = true;
                        }
                    }
                    break;
            }

            return diskOnPeg;
        }

        private bool CheckSmallDiskBelow(GeneralControl objGC) // Check to see if there's a smaller disk below
        {
            bool smallDiskBelow = false;

            switch (objGC.DestinationPegNumber)
            {
                case 0:
                    {
                        foreach (Button bt in objGC.Disks)
                        {
                            if (bt.Width < ((Button)objGC.CurrentDisk).Width)
                            {
                                smallDiskBelow = true;
                                break;
                            }
                        }
                    }
                    break;
                case 1:
                    {
                        foreach (Button bt in objGC.Disks2)
                        {
                            if (bt.Width < ((Button)objGC.CurrentDisk).Width)
                            {
                                smallDiskBelow = true;
                                break;
                            }
                        }
                    }
                    break;
                default: //case 2
                    {
                        foreach (Button bt in objGC.Disks3)
                        {
                            if (bt.Width < ((Button)objGC.CurrentDisk).Width)
                            {
                                smallDiskBelow = true;
                                break;
                            }
                        }
                    }
                    break;
            }

            return smallDiskBelow;
        }

        private void SetDiskLocation(GeneralControl objGC, PositioningAndDrawing objPAD, Preferences objPref, LocationType locationType)
        {
            int totalWidth, space, posX, posY;

            if (locationType == LocationType.defaultLocation)
            {
                // Getting the difference between the size of the button and the peg:
                totalWidth = ((Button)objGC.CurrentDisk).Width - ((Button)objGC.PegDestination).Width;

                // Dividing it by 2, 'cause it's an intent here to let the button centered:
                space = totalWidth / 2;

                posX = ((Button)objGC.PegDestination).Location.X - space;

                posY = objPAD.DiskHeight * objPref.NumberOfDisks + objPAD.CorrectionFactor;
            }
            else
            {
                // Getting the difference between the size of the button and the peg:
                totalWidth = ((Button)objGC.CurrentDisk).Width - ((Button)objGC.PegDestination).Width;

                // Dividing it by 2, 'cause it's an intent here to let the button centered:
                space = totalWidth / 2;

                posX = ((Button)objGC.PegDestination).Location.X - space;

                posY = GetHighestHeight(objGC) - objPAD.DiskHeight;
            }

            // Adding information about the current movement, so it's possible to undo it:
            objGC.LastDisk = objGC.CurrentDisk;
            objGC.LastPeg = objGC.SourcePeg;

            // Setting the disk's location:
            ((Button)objGC.CurrentDisk).Location = new Point(posX, posY);
        }

        private int GetHighestHeight(GeneralControl objGC) // Get the highest disk height from the peg the player is trying to move the disk to
        {
            int highestHeight = 0;
            switch (objGC.DestinationPegNumber)
            {
                case 0:
                    {
                        highestHeight = objGC.Disks[objGC.Disks.Count() - 1].Location.Y;
                    }
                    break;
                case 1:
                    {
                        highestHeight = objGC.Disks2[objGC.Disks2.Count() - 1].Location.Y;

                    }
                    break;
                default: //case 2
                    {
                        highestHeight = objGC.Disks3[objGC.Disks3.Count() - 1].Location.Y;
                    }
                    break;
            }

            return highestHeight;
        }

        private void ListModifying(GeneralControl objGC)
        {
            // Removing the disk from the source peg list:
            switch (objGC.SourcePegNumber)
            {
                case 0:
                    objGC.Disks.Remove((Button)objGC.CurrentDisk);
                    break;
                case 1:
                    objGC.Disks2.Remove((Button)objGC.CurrentDisk);
                    break;
                default: //case 2
                    objGC.Disks3.Remove((Button)objGC.CurrentDisk);
                    break;
            }
            // Adding it to the destination list:
            switch (objGC.DestinationPegNumber)
            {
                case 0:
                    objGC.Disks.Add((Button)objGC.CurrentDisk);
                    break;
                case 1:
                    objGC.Disks2.Add((Button)objGC.CurrentDisk);
                    break;
                default: //case 2
                    objGC.Disks3.Add((Button)objGC.CurrentDisk);
                    break;
            }
        }
    
        public int AddOneMovement(Records objRec)
        {
            objRec.PlayerScore += 1;

            return objRec.PlayerScore; // Returns to the label the score to be add
        }

        public int DeleteOneMovement(Records objRec)
        {
            objRec.PlayerScore -= 1;

            return objRec.PlayerScore; // Returns to the label the score to be decreased
        }

        public void DisableDisk(GeneralControl objGC)
        {
            if (objGC.CurrentDisk != null)
            {
                objGC.BrightnessType = Brightness.darkened;
                ChangeDiskBrightness(objGC);
                objGC.CurrentDisk = null;
                objGC.Move = false;
            }
        }
    }
}
