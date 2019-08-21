using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MdiHelper;


namespace HanoiTower
{
    public partial class frmGame : MdiParent
    {
        private enum Visibility
        {
            visible,
            invisible
        };

        Stopwatch stopWatch = new Stopwatch();

        PositioningAndDrawing objPAD = new PositioningAndDrawing();
        PositioningAndDrawingDAL objPADDAL = new PositioningAndDrawingDAL();

        GeneralControl objGC = new GeneralControl();
        GeneralControlDAL objGCDAL = new GeneralControlDAL();

        Preferences objPref = new Preferences();
        PreferencesDAL objPrefDAL = new PreferencesDAL();

        Records objRec = new Records();
        RecordsDAL objRecDAL = new RecordsDAL();

        ToolTip ToolTipReturn = new ToolTip();
        ToolTip ToolTipPause = new ToolTip();
        ToolTip ToolTipUndo = new ToolTip();

        bool undoStatus = false; // Used to control the enable property of the undo button

        internal frmGame(Preferences objPref)
        {
            InitializeComponent();
            this.objPref = objPref;

            #region Modifying Fonts
            HelperClass.AllocFont(lblElapsedTime, 11);
            HelperClass.AllocFont(lblElapsedTimeCounter, 11);
            HelperClass.AllocFont(lblMovement, 11);
            HelperClass.AllocFont(lblMovementCounter, 11);
            #endregion

            // Changing the background color and setting the MouseClick event of this MDI form:
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.MouseClick += frmGame_MouseClick;
                    control.BackColor = default(Color);
                    break;
                }
            }

        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            // Preventing the user from resizing the form:
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            // Default values:
            objGC.CurrentDisk = null;
            objGC.SourcePegNumber = 0;
            objGC.Move = false;
            objRec.ElapsedPlayingTime = "00:00";
            objRec.PlayerScore = 0;

            // Initializing List of Disks:
            objGC.Disks = new List<Button>();
            objGC.Disks2 = new List<Button>();
            objGC.Disks3 = new List<Button>();

            objPADDAL.PositionAdjustment(objPAD, objPref);

            #region Disks
            objGC.Disk1ClickEvent = new System.EventHandler(btn_Click);
            objGC.Disk2ClickEvent = new System.EventHandler(btn_Click2);
            objPAD.DiskColor = new Color[11]; // Defining array position (here it's limited to only 10 disks)
            objPAD.DiskColor = objPref.DiskColors;
            objGC.Disks = objPADDAL.CreateButtons(objPAD, objGC, objPref);
            // Adding disks to form:
            for (int i = 0; i < objGC.Disks.Count(); i++)
            {
                this.Controls.Add(objGC.Disks[i]);
            }
            #endregion

            #region Pegs
            objGC.PegClickEvent = new System.EventHandler(btn_peg_Click);
            objGC.Pegs = new Button[3];
            // Adding Pegs to form:
            for (int i = 0; i < 3; i++)
            {
                this.Controls.Add(objPADDAL.DrawPegs(objPAD, objGC, i));
            }
            #endregion

            btnUndo.Visible = objPref.UndoButton;

            stopWatch.Start();
        }

        private void btn_Click(object sender, EventArgs e) // Event that gets fired by the disks at the top
        {
            HelperClass.PlaySound(objPref);

            objGC.BrightnessType = Brightness.darkened;
            if (objGC.CurrentDisk != null)
                objGCDAL.ChangeDiskBrightness(objGC);
            objGC.Move = true;
            objGC.CurrentDisk = sender;

            objGC.CurrentDiskColor = ((Button)objGC.CurrentDisk).BackColor;
            objGC.BrightnessType = Brightness.lightened;
            objGCDAL.ChangeDiskBrightness(objGC);
        }

        private void btn_Click2(object sender, EventArgs e) // Event that gets fired by the disks that aren't at the top
        {
            objGCDAL.DisableDisk(objGC);
        }

        private void btn_peg_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            if (objGC.Move)
            {
                objGC.Move = false;
                objGC.PegDestination = sender;
                objGC.DestinationPegNumber = int.Parse(((Button)objGC.PegDestination).Name.Substring(7, 1).ToString());

                try
                {
                    objGCDAL.MoveDisk(objGC, objPAD, objRec, objPref);
                    lblMovementCounter.Text = objGCDAL.AddOneMovement(objRec).ToString();
                    btnUndo.Enabled = true;
                    btnUndo.BackgroundImage = HanoiTower.Properties.Resources.Return_Arrow;
                }
                catch (CustomExceptions customEx)
                {
                    MessageBox.Show(customEx.Message, "Invalid Movement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                CheckVictory();
                objGCDAL.RemoveEvents(objGC);
                objGCDAL.AddEvents(objGC);
            }
        }

        private void frmGame_MouseClick(object sender, MouseEventArgs e)
        {
            objGC.Move = false;
            if (objGC.CurrentDisk != null)
            {
                objGC.BrightnessType = Brightness.darkened;
                objGCDAL.ChangeDiskBrightness(objGC);
                objGC.CurrentDisk = null;
            }
        }

        private void CheckVictory() // Check to see if the tower has been completed
        {
            if (objGC.Disks3.Count() == objPref.NumberOfDisks)
            {
                objPref.NumberOfDisksDesired = objPref.NumberOfDisks;

                stopWatch.Stop();
                tmr_time.Enabled = false;

                if(objRecDAL.BestSolutionCheck(objRec, objPref))
                    MessageBox.Show("Tower of Hanoi has been completed successfully!\nYou've done the best solution: " + objRec.PlayerScore + " moves", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Tower of Hanoi has been completed successfully!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Calling frmWinner:
                frmWinner frmWin = new frmWinner(objRec, objPref);
                frmWin.ShowDialog();

                // After saving, return to main screen:
                this.Close();
            }
        }

        private void tmr_time_Tick(object sender, EventArgs e)
        {
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed; // Getting the elapsed time as a TimeSpan value
            string elapsedTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds); // Formatting and displaying the TimeSpan value
            objRec.ElapsedPlayingTime = elapsedTime.ToString();
            lblElapsedTimeCounter.Text = objRec.ElapsedPlayingTime;

            stopWatch.Start();
        }

        private void ChangeGeneralVisibility(Visibility visibilityType)
        {
            if (visibilityType == Visibility.visible)
            {
                foreach (var btn in this.Controls.OfType<Button>())
                {
                    btn.Visible = true;
                }
            }
            else
            {
                foreach (var btn in this.Controls.OfType<Button>())
                {
                    btn.Visible = false;
                }
            }
        }

        public override void ForceReleaseOfControls()
        {
            base.ForceReleaseOfControls();

            ChangeGeneralVisibility(Visibility.visible);
            btnUndo.Enabled = undoStatus; // Keeping the enable property after resuming the game
            btnUndo.Visible = objPref.UndoButton; // It will also keep the visible property of the button
            tmr_time.Enabled = true; // Restarting timer
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            stopWatch.Stop();
            tmr_time.Enabled = false;

            undoStatus = btnUndo.Enabled; // It will keep the enable property of the button to be used after resuming the game
            ChangeGeneralVisibility(Visibility.invisible);

            // Calling frmPause
            frmPause frmPause = new frmPause(objRec.PlayerScore, objRec.ElapsedPlayingTime, objPref);
            ShowChildDialog(frmPause);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            this.Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            HelperClass.PlaySound(objPref);

            //Putting disk back to its last position:

            try
            {
                // Changing brightness of possible selected disk:
                objGC.BrightnessType = Brightness.darkened;
                if (objGC.CurrentDisk != null)
                    objGCDAL.ChangeDiskBrightness(objGC);

                // Setting neccessary information to undo the movement:
                objGC.CurrentDisk = objGC.LastDisk;
                objGC.CurrentDiskColor = ((Button)objGC.CurrentDisk).BackColor;
                objGC.PegDestination = objGC.LastPeg;
                objGC.DestinationPegNumber = int.Parse(((Button)objGC.LastPeg).Name.Substring(7, 1).ToString());
                
                objGCDAL.MoveDisk(objGC, objPAD, objRec, objPref);

                objGCDAL.RemoveEvents(objGC);
                objGCDAL.AddEvents(objGC);

                // Decreasing 1 movement:
                lblMovementCounter.Text = objGCDAL.DeleteOneMovement(objRec).ToString();

                // Undo button can only be used one time:
                btnUndo.Enabled = false;
                btnUndo.BackgroundImage = HanoiTower.Properties.Resources.Return_Arrow___disabled;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region ToolTips
        private void btnReturn_MouseHover(object sender, EventArgs e)
        {
            ToolTipReturn.SetToolTip(this.btnReturn, "Return to main screen");
        }

        private void btnPause_MouseHover(object sender, EventArgs e)
        {
            ToolTipPause.SetToolTip(this.btnPause, "Pause the game");
        }

        private void btnUndo_MouseHover(object sender, EventArgs e)
        {
            ToolTipUndo.SetToolTip(this.btnUndo, "Undo movement");
        }
        #endregion
    }
}
