using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Group Members: Arya Peruma and Luke Robbins

namespace TortoiseandHare
{
    public partial class frmTortoiseHare : Form
    {
        public frmTortoiseHare()
        {
            InitializeComponent();

            // enabling reset and pause btns when start is clicked
            btnReset.Enabled = false;
            btnPause.Enabled = false;

            // hiding picture mode tortoise and hare
            pbH.Hide();
            pbT.Hide();

            // setting default timer speed
            nudTimerSpeed.Value = 200;

            // setting up ouch label
            lblOuch.Parent = pbRaceTrack;
            lblOuch.BackColor = System.Drawing.Color.Transparent;
            lblOuch.Hide();

            // instantiating hare and tortoise objects
            hare = new Hare();
            tortoise = new Tortoise();

            readInfo(); 
        }

        // initializing tortoise and hare scores, ties, and games played to 0
        int scoreH = 0;
        int scoreT = 0;
        int scoreTie = 0;
        int scoreGamesPlayed = 0;

        // initializing stats of tortoise and hare scores, ties, and games played to 0
        int statH = 0;
        int statT = 0;
        int statTie = 0;
        int statsTotalGamesPlayed = 0;

        // creating objects tortoise and hare
        Tortoise tortoise;
        Hare hare;

        // created parent class Contender
        public class Contender
        {
            // created positioning, number of steps and color variables for parent class 
            protected int iPosition;
            protected int iNumberofSteps;
            public Color clr;

            // default Contender constructor
            public Contender()
            {
                //default contructor 
                iPosition = 0;
                iNumberofSteps = 70;
                clr = Color.Black;
            }

            // Contender constructor with variables passed through
            public Contender(int numSteps, int pos, Color clr1)
            {
                //contructor with user defined variables
                setNumSteps(numSteps);
                setPos(pos);
                setColor(clr1);
            }

            // defines original position as 0
            public void setPositionOriginal()
            {
                iPosition = 0;
            }

            // sets number of steps
            public void setNumSteps(int numSteps)
            {
                //sets numsteps to be pos
                if (numSteps < 0)
                {
                    iNumberofSteps = numSteps * (-1);
                }
                else
                {
                    iNumberofSteps = numSteps;
                }
            }

            // sets contender positions
            public void setPos(int pos)
            {
                //sets pos to original
                if (pos < 0)
                {
                    iPosition = 0;
                }
                else
                {
                    iPosition = pos;
                }
            }

            // sets contender colors
            public void setColor(Color clr1)
            {
                //sets colour
                clr = clr1;
            }

            //retrives variables
            public int getNumSteps()
            {
                return iNumberofSteps;
            }
            public int getPos()
            {
                return iPosition;
            }
            public Color getColor()
            {
                return clr;
            }


            //checks if a contender is the winner
            public bool isWinner()
            {
                if (iPosition >= iNumberofSteps)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // child class Tortoise of parent Contender
        public class Tortoise : Contender
        {
            Random rnd;

            public Tortoise()
            {
                //default contructor 
                rnd = new Random();
                iPosition = 0;
                clr = Color.Green;
                iNumberofSteps = 70;
            }
            public Tortoise(Color c, int numSteps, int pos, Random r)
            {
                //contructor with user defined variables
                rnd = r;
                iPosition = pos;
                clr = c;
                iNumberofSteps = numSteps;
            }

            public void UpdatePosition()
            {
                //updates position based on random number
                int rndNum = rnd.Next(0, 100);

                if (rndNum <= 50)
                {
                    iPosition += 3;
                }
                else if (rndNum <= 70)
                {
                    iPosition -= 6;
                }
                else
                {
                    iPosition += 1;
                }

                //makes sure position does not pass number of steps or becomes negative
                if (iPosition < 0)
                {
                    iPosition = 0;
                }

            }

            public void Draw(Graphics g, int yLoc)
            {
                //draws tortoise updated position 
                SolidBrush myBrush = new SolidBrush(clr);
                g.FillEllipse(myBrush, iPosition * 12 + 15, yLoc + 75, 30, 30);
            }
        }

        // child class Hare of parent Contender
        public class Hare : Contender
        {
            Random rnd;

            public Hare()
            {
                //default contructor
                rnd = new Random();
                iPosition = 0;
                clr = Color.SkyBlue;
                iNumberofSteps = 70;
            }
            public Hare(Color c, int numSteps, int pos, Random r)
            {
                //contructor that sets 
                rnd = r;
                iPosition = pos;
                clr = c;
                iNumberofSteps = numSteps;
            }
            public void UpdatePosition()
            {
                //updates position based on random number
                int rndNum = rnd.Next(0, 100);


                if (rndNum <= 20)
                {
                    iPosition += 0;  // sleep
                }
                else if (rndNum <= 40)
                {
                    iPosition += 8;
                }
                else if (rndNum <= 60)
                {
                    iPosition -= 2;
                }
                else if (rndNum <= 90)
                {
                    iPosition += 1;
                }
                else if (rndNum <= 100)
                {
                    iPosition -= 10;
                }
                else
                {
                    iPosition += 1;
                }

                //makes sure position does not pass number of steps or becomes negative
                if (iPosition < 0)
                {
                    iPosition = 0;
                }
            }

            public void Draw(Graphics g, int yLoc)
            {
                //draws hare updated position 
                SolidBrush myBrush = new SolidBrush(clr);
                g.FillRectangle(myBrush, iPosition * 12 + 15, yLoc + 120, 30, 30);
            }
        }

        private void pbRaceTrack_Paint(object sender, PaintEventArgs e)
        {
            //Draws a finish line
            Pen myPen = new Pen(Color.Black, 5);
            e.Graphics.DrawLine(myPen, 855, 0, 855, 200);

            //Either displays the contenders as images or drawn shapes
            if (rbDrawMode.Checked == true)
            {
                pbH.Hide();
                pbT.Hide();

                tortoise.Draw(e.Graphics, 0);
                hare.Draw(e.Graphics, 0);
            }
            else
            {
                pbH.Show();
                pbT.Show();

                pbT.Left = tortoise.getPos() * 12 + 15;
                pbH.Left = hare.getPos() * 12 + 15;
            }
        }

        private void timerRace_Tick(object sender, EventArgs e)
        {
            hare.UpdatePosition();

            tortoise.UpdatePosition();

            pbRaceTrack.Invalidate();

            //If the tortoise lands at the same x position as the hare then say Ouch
            if (tortoise.getPos() == hare.getPos())
            {
                lblOuch.Show();
                timerOuch.Start();
            }

            //If Tie
            if (tortoise.isWinner() && hare.isWinner())
            {
                timerRace.Stop();
                MessageBox.Show("It's a tie.");
                scoreTie += 1;
                txtTie.Text = scoreTie.ToString();
                statTie += 1;
                scoreGamesPlayed += 1;
                statsTotalGamesPlayed += 1;
                UpdateScoreboard();
            }
            //If Hare is winner
            else if (hare.isWinner())
            {
                timerRace.Stop();
                MessageBox.Show("Hare wins. Yuch.");
                scoreH += 1;
                txtHWin.Text = scoreH.ToString();
                statH += 1;
                scoreGamesPlayed += 1;
                statsTotalGamesPlayed += 1;
                UpdateScoreboard();
            }
            //If Tortoise is winner
            else if (tortoise.isWinner())
            {
                timerRace.Stop();
                MessageBox.Show("TORTOISE WINS!!! YAY!!!");
                scoreT += 1;
                txtTWin.Text = scoreT.ToString();
                statT += 1;
                scoreGamesPlayed += 1;
                statsTotalGamesPlayed += 1;
                UpdateScoreboard();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnReset.Enabled = true;

            //Start the race
            timerRace.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnReset.Enabled = false;

            //Reset the race and put contenders back to original positions
            timerRace.Stop();
            tortoise.setPositionOriginal();
            hare.setPositionOriginal();
            pbRaceTrack.Invalidate();
        }

        //Button Counter for displaying pause/play
        public int iButtonCounter = 0;
        private void btnPause_Click(object sender, EventArgs e)
        {
            //Pause Clicked
            if (iButtonCounter == 0)
            {
                btnPause.Text = "Play";
                timerRace.Stop();
                pbRaceTrack.Invalidate();
                iButtonCounter = 1;
            }
            //Play clicked
            else
            {
                btnPause.Text = "Pause";
                timerRace.Start();
                pbRaceTrack.Invalidate();
                iButtonCounter = 0;
            }

        }

        private void btnScoreReset_Click(object sender, EventArgs e)
        {
            //Set all scores back to 0 and the number of games played to 0
            scoreH = 0;
            scoreT = 0;
            scoreTie = 0;
            scoreGamesPlayed = 0;

            UpdateScoreboard();
        }

        public void UpdateScoreboard()
        {
            //Display new scoreboard data in the scoreboard textboxes
            txtHWin.Text = scoreH.ToString();
            txtTWin.Text = scoreT.ToString();
            txtTie.Text = scoreTie.ToString();
            txtGamesPlayed.Text = scoreGamesPlayed.ToString();
        }

        // Second timer for ouch
        private void timerOuch_Tick(object sender, EventArgs e)
        {
            timerOuch.Stop();
            lblOuch.Hide();
        }

        private void nudTimerSpeed_ValueChanged(object sender, EventArgs e)
        {
            //Changes the tick interval of the race timer to whatever the user inputed
            timerRace.Interval = Convert.ToInt32(nudTimerSpeed.Value);
        }

        public void UpdateStats()
        {
            try
            {
                //Clear all the chart so that the values can be readded with updated values
                TortoiseVsHareChart.Series["RaceData"].Points.Clear();

                //Add the data to the chart accordingly
                TortoiseVsHareChart.Series["RaceData"].Points.AddXY("Hare Wins", statH);
                TortoiseVsHareChart.Series["RaceData"].Points.AddXY("Tortoise Wins", statT);
                TortoiseVsHareChart.Series["RaceData"].Points.AddXY("Ties", statTie);

                //Add the numerical values of stats to the textboxes
                txtStatsTotalGamesPlayed.Text = statsTotalGamesPlayed.ToString();
                txtStatsTortoiseWins.Text = statT.ToString();
                txtStatsHareWins.Text = statH.ToString();
                txtStatsTies.Text = statTie.ToString();
            }            
            catch
            {
                MessageBox.Show("Statistics Error");
            }
        }

        private void frmTortoiseHare_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save the new data from the current session to the file
            saveInfo();
        }

        public void readInfo()
        {
            try
            {
                //reads info from text file and puts it into the accessable public variables
                TextReader tr = new StreamReader("TortoiseandHare.txt");
                string strInput;
                string[] splittedInput;

                strInput = tr.ReadLine();
                splittedInput = strInput.Split(',');
                statH = Convert.ToInt32(splittedInput[0]);
                statT = Convert.ToInt32(splittedInput[1]);
                statTie = Convert.ToInt32(splittedInput[2]);
                statsTotalGamesPlayed = Convert.ToInt32(splittedInput[3]);

                tr.Close();
            }
            catch
            {
                MessageBox.Show("Error reading from file");
            }
        }

        // saves info in a text file
        public void saveInfo()
        {
            try
            {
                TextWriter tw = new StreamWriter("TortoiseandHare.txt");

                tw.Write(statH.ToString() + ",");
                tw.Write(statT.ToString() + ",");
                tw.Write(statTie.ToString() + ",");
                tw.WriteLine(statsTotalGamesPlayed.ToString() + ",");

                tw.Close();
            }
            catch
            {
                MessageBox.Show("Error Saving to file");
            }
        }

        private void tcRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When the tab page stats is selected update the chart
            if (tcRace.SelectedTab == tpStats)
            {
                UpdateStats();
            }
        }

        private void rbPicMode_CheckedChanged(object sender, EventArgs e)
        {
            //Disable the change color buttons when picture mode is on
            if (rbDrawMode.Checked == true)
            {
                btnChangeColH.Enabled = true;
                btnChangeColT.Enabled = true;
            }
            else
            {
                btnChangeColH.Enabled = false;
                btnChangeColT.Enabled = false;
            }

            //Make the race track picturebox the parent of the smaller pictureboxes and affect their positions and make them transparent
            pbH.Top = 130;
            pbT.Top = 75;
            pbT.Parent = pbRaceTrack;
            pbH.Parent = pbRaceTrack;
            pbT.BackColor = Color.Transparent;
            pbH.BackColor = Color.Transparent;

            pbRaceTrack.Image = Image.FromFile("meadow.png");

            pbRaceTrack.Invalidate();
        }

        private void btnChangeColT_Click(object sender, EventArgs e)
        {
            try
            {
                //allows user to change colour of the tortoise
                ColorDialog clrDlg = new ColorDialog();

                if (clrDlg.ShowDialog() == DialogResult.OK)
                {
                    tortoise.clr = clrDlg.Color;
                    pbRaceTrack.Invalidate();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnChangeColH_Click(object sender, EventArgs e)
        {
            try
            {
                //allow user to change colour of the hare
                ColorDialog clrDlg = new ColorDialog();

                if (clrDlg.ShowDialog() == DialogResult.OK)
                {
                    hare.clr = clrDlg.Color;
                    pbRaceTrack.Invalidate();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void rbDrawMode_CheckedChanged(object sender, EventArgs e)
        {
            // sets draw mode background to race track
            pbRaceTrack.Image = Image.FromFile("THRoad.jpg");
        }
    }
}