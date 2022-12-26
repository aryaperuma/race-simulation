namespace TortoiseandHare
{
    partial class frmTortoiseHare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timerRace = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timerOuch = new System.Windows.Forms.Timer(this.components);
            this.nudTimerSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblChooseSpeed = new System.Windows.Forms.Label();
            this.gbScoreboard = new System.Windows.Forms.GroupBox();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.txtGamesPlayed = new System.Windows.Forms.TextBox();
            this.btnScoreReset = new System.Windows.Forms.Button();
            this.lblHWin = new System.Windows.Forms.Label();
            this.lblTie = new System.Windows.Forms.Label();
            this.lblTWin = new System.Windows.Forms.Label();
            this.txtHWin = new System.Windows.Forms.TextBox();
            this.txtTie = new System.Windows.Forms.TextBox();
            this.txtTWin = new System.Windows.Forms.TextBox();
            this.tcRace = new System.Windows.Forms.TabControl();
            this.tpRace = new System.Windows.Forms.TabPage();
            this.lblOuch = new System.Windows.Forms.Label();
            this.pbH = new System.Windows.Forms.PictureBox();
            this.pbT = new System.Windows.Forms.PictureBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.gbChangeCol = new System.Windows.Forms.GroupBox();
            this.btnChangeColT = new System.Windows.Forms.Button();
            this.btnChangeColH = new System.Windows.Forms.Button();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbDrawMode = new System.Windows.Forms.RadioButton();
            this.rbPicMode = new System.Windows.Forms.RadioButton();
            this.gbTimerSpeed = new System.Windows.Forms.GroupBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.tpStats = new System.Windows.Forms.TabPage();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.lblStatsGamesPlayed = new System.Windows.Forms.Label();
            this.txtStatsTotalGamesPlayed = new System.Windows.Forms.TextBox();
            this.lblStatsHWins = new System.Windows.Forms.Label();
            this.lblStatsTie = new System.Windows.Forms.Label();
            this.lblStatsTWins = new System.Windows.Forms.Label();
            this.txtStatsHareWins = new System.Windows.Forms.TextBox();
            this.txtStatsTies = new System.Windows.Forms.TextBox();
            this.txtStatsTortoiseWins = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TortoiseVsHareChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerSpeed)).BeginInit();
            this.gbScoreboard.SuspendLayout();
            this.tcRace.SuspendLayout();
            this.tpRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbT)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.gbChangeCol.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.gbTimerSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.tpStats.SuspendLayout();
            this.gbStats.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TortoiseVsHareChart)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRace
            // 
            this.timerRace.Interval = 200;
            this.timerRace.Tick += new System.EventHandler(this.timerRace_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 342);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 43);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(146, 342);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(128, 43);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(280, 342);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 43);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timerOuch
            // 
            this.timerOuch.Interval = 1000;
            this.timerOuch.Tick += new System.EventHandler(this.timerOuch_Tick);
            // 
            // nudTimerSpeed
            // 
            this.nudTimerSpeed.Location = new System.Drawing.Point(6, 32);
            this.nudTimerSpeed.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTimerSpeed.Name = "nudTimerSpeed";
            this.nudTimerSpeed.Size = new System.Drawing.Size(120, 22);
            this.nudTimerSpeed.TabIndex = 0;
            this.nudTimerSpeed.ValueChanged += new System.EventHandler(this.nudTimerSpeed_ValueChanged);
            // 
            // lblChooseSpeed
            // 
            this.lblChooseSpeed.AutoSize = true;
            this.lblChooseSpeed.Location = new System.Drawing.Point(3, 16);
            this.lblChooseSpeed.Name = "lblChooseSpeed";
            this.lblChooseSpeed.Size = new System.Drawing.Size(172, 16);
            this.lblChooseSpeed.TabIndex = 6;
            this.lblChooseSpeed.Text = "Timer Speed (Milliseconds)";
            // 
            // gbScoreboard
            // 
            this.gbScoreboard.Controls.Add(this.lblGamesPlayed);
            this.gbScoreboard.Controls.Add(this.txtGamesPlayed);
            this.gbScoreboard.Controls.Add(this.btnScoreReset);
            this.gbScoreboard.Controls.Add(this.lblHWin);
            this.gbScoreboard.Controls.Add(this.lblTie);
            this.gbScoreboard.Controls.Add(this.lblTWin);
            this.gbScoreboard.Controls.Add(this.txtHWin);
            this.gbScoreboard.Controls.Add(this.txtTie);
            this.gbScoreboard.Controls.Add(this.txtTWin);
            this.gbScoreboard.Location = new System.Drawing.Point(198, 6);
            this.gbScoreboard.Name = "gbScoreboard";
            this.gbScoreboard.Size = new System.Drawing.Size(465, 106);
            this.gbScoreboard.TabIndex = 1;
            this.gbScoreboard.TabStop = false;
            this.gbScoreboard.Text = "Scoreboard";
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(6, 58);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(97, 16);
            this.lblGamesPlayed.TabIndex = 8;
            this.lblGamesPlayed.Text = "Games Played";
            // 
            // txtGamesPlayed
            // 
            this.txtGamesPlayed.Enabled = false;
            this.txtGamesPlayed.Location = new System.Drawing.Point(9, 74);
            this.txtGamesPlayed.Name = "txtGamesPlayed";
            this.txtGamesPlayed.ReadOnly = true;
            this.txtGamesPlayed.Size = new System.Drawing.Size(100, 22);
            this.txtGamesPlayed.TabIndex = 1;
            this.txtGamesPlayed.TabStop = false;
            // 
            // btnScoreReset
            // 
            this.btnScoreReset.Location = new System.Drawing.Point(348, 58);
            this.btnScoreReset.Name = "btnScoreReset";
            this.btnScoreReset.Size = new System.Drawing.Size(105, 33);
            this.btnScoreReset.TabIndex = 4;
            this.btnScoreReset.Text = "Reset Scoreboard";
            this.btnScoreReset.UseVisualStyleBackColor = true;
            this.btnScoreReset.Click += new System.EventHandler(this.btnScoreReset_Click);
            // 
            // lblHWin
            // 
            this.lblHWin.AutoSize = true;
            this.lblHWin.Location = new System.Drawing.Point(112, 16);
            this.lblHWin.Name = "lblHWin";
            this.lblHWin.Size = new System.Drawing.Size(70, 16);
            this.lblHWin.TabIndex = 5;
            this.lblHWin.Text = "Hare Wins";
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.Location = new System.Drawing.Point(218, 16);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(34, 16);
            this.lblTie.TabIndex = 4;
            this.lblTie.Text = "Ties";
            // 
            // lblTWin
            // 
            this.lblTWin.AutoSize = true;
            this.lblTWin.Location = new System.Drawing.Point(6, 16);
            this.lblTWin.Name = "lblTWin";
            this.lblTWin.Size = new System.Drawing.Size(90, 16);
            this.lblTWin.TabIndex = 3;
            this.lblTWin.Text = "Tortoise Wins";
            // 
            // txtHWin
            // 
            this.txtHWin.Enabled = false;
            this.txtHWin.Location = new System.Drawing.Point(115, 35);
            this.txtHWin.Name = "txtHWin";
            this.txtHWin.ReadOnly = true;
            this.txtHWin.Size = new System.Drawing.Size(100, 22);
            this.txtHWin.TabIndex = 2;
            this.txtHWin.TabStop = false;
            // 
            // txtTie
            // 
            this.txtTie.Enabled = false;
            this.txtTie.Location = new System.Drawing.Point(221, 35);
            this.txtTie.Name = "txtTie";
            this.txtTie.ReadOnly = true;
            this.txtTie.Size = new System.Drawing.Size(100, 22);
            this.txtTie.TabIndex = 3;
            this.txtTie.TabStop = false;
            // 
            // txtTWin
            // 
            this.txtTWin.Enabled = false;
            this.txtTWin.Location = new System.Drawing.Point(9, 35);
            this.txtTWin.Name = "txtTWin";
            this.txtTWin.ReadOnly = true;
            this.txtTWin.Size = new System.Drawing.Size(100, 22);
            this.txtTWin.TabIndex = 0;
            this.txtTWin.TabStop = false;
            // 
            // tcRace
            // 
            this.tcRace.Controls.Add(this.tpRace);
            this.tcRace.Controls.Add(this.tpStats);
            this.tcRace.Location = new System.Drawing.Point(12, 12);
            this.tcRace.Name = "tcRace";
            this.tcRace.SelectedIndex = 0;
            this.tcRace.Size = new System.Drawing.Size(1033, 434);
            this.tcRace.TabIndex = 0;
            this.tcRace.SelectedIndexChanged += new System.EventHandler(this.tcRace_SelectedIndexChanged);
            // 
            // tpRace
            // 
            this.tpRace.Controls.Add(this.lblOuch);
            this.tpRace.Controls.Add(this.pbH);
            this.tpRace.Controls.Add(this.pbT);
            this.tpRace.Controls.Add(this.gbSettings);
            this.tpRace.Controls.Add(this.gbTimerSpeed);
            this.tpRace.Controls.Add(this.btnReset);
            this.tpRace.Controls.Add(this.gbScoreboard);
            this.tpRace.Controls.Add(this.btnPause);
            this.tpRace.Controls.Add(this.btnStart);
            this.tpRace.Controls.Add(this.pbRaceTrack);
            this.tpRace.Location = new System.Drawing.Point(4, 25);
            this.tpRace.Name = "tpRace";
            this.tpRace.Padding = new System.Windows.Forms.Padding(3);
            this.tpRace.Size = new System.Drawing.Size(1025, 405);
            this.tpRace.TabIndex = 0;
            this.tpRace.Text = "Race";
            this.tpRace.UseVisualStyleBackColor = true;
            // 
            // lblOuch
            // 
            this.lblOuch.AutoSize = true;
            this.lblOuch.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOuch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOuch.Location = new System.Drawing.Point(605, 1);
            this.lblOuch.Name = "lblOuch";
            this.lblOuch.Size = new System.Drawing.Size(190, 62);
            this.lblOuch.TabIndex = 15;
            this.lblOuch.Text = "Ouch!!!";
            // 
            // pbH
            // 
            this.pbH.BackColor = System.Drawing.Color.Transparent;
            this.pbH.Image = global::TortoiseandHare.Properties.Resources.hare;
            this.pbH.Location = new System.Drawing.Point(76, 218);
            this.pbH.Name = "pbH";
            this.pbH.Size = new System.Drawing.Size(50, 50);
            this.pbH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbH.TabIndex = 14;
            this.pbH.TabStop = false;
            // 
            // pbT
            // 
            this.pbT.BackColor = System.Drawing.Color.Transparent;
            this.pbT.Image = global::TortoiseandHare.Properties.Resources.tortoise;
            this.pbT.Location = new System.Drawing.Point(24, 148);
            this.pbT.Name = "pbT";
            this.pbT.Size = new System.Drawing.Size(50, 50);
            this.pbT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbT.TabIndex = 13;
            this.pbT.TabStop = false;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.gbChangeCol);
            this.gbSettings.Controls.Add(this.gbMode);
            this.gbSettings.Location = new System.Drawing.Point(414, 324);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(395, 79);
            this.gbSettings.TabIndex = 5;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // gbChangeCol
            // 
            this.gbChangeCol.Controls.Add(this.btnChangeColT);
            this.gbChangeCol.Controls.Add(this.btnChangeColH);
            this.gbChangeCol.Location = new System.Drawing.Point(6, 19);
            this.gbChangeCol.Name = "gbChangeCol";
            this.gbChangeCol.Size = new System.Drawing.Size(169, 52);
            this.gbChangeCol.TabIndex = 0;
            this.gbChangeCol.TabStop = false;
            this.gbChangeCol.Text = "Change Colour";
            // 
            // btnChangeColT
            // 
            this.btnChangeColT.Location = new System.Drawing.Point(6, 19);
            this.btnChangeColT.Name = "btnChangeColT";
            this.btnChangeColT.Size = new System.Drawing.Size(75, 23);
            this.btnChangeColT.TabIndex = 0;
            this.btnChangeColT.Text = "Tortoise";
            this.btnChangeColT.UseVisualStyleBackColor = true;
            this.btnChangeColT.Click += new System.EventHandler(this.btnChangeColT_Click);
            // 
            // btnChangeColH
            // 
            this.btnChangeColH.Location = new System.Drawing.Point(87, 19);
            this.btnChangeColH.Name = "btnChangeColH";
            this.btnChangeColH.Size = new System.Drawing.Size(75, 23);
            this.btnChangeColH.TabIndex = 1;
            this.btnChangeColH.Text = "Hare";
            this.btnChangeColH.UseVisualStyleBackColor = true;
            this.btnChangeColH.Click += new System.EventHandler(this.btnChangeColH_Click);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbDrawMode);
            this.gbMode.Controls.Add(this.rbPicMode);
            this.gbMode.Location = new System.Drawing.Point(181, 19);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(203, 52);
            this.gbMode.TabIndex = 1;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            // 
            // rbDrawMode
            // 
            this.rbDrawMode.AutoSize = true;
            this.rbDrawMode.Checked = true;
            this.rbDrawMode.Location = new System.Drawing.Point(6, 19);
            this.rbDrawMode.Name = "rbDrawMode";
            this.rbDrawMode.Size = new System.Drawing.Size(97, 20);
            this.rbDrawMode.TabIndex = 0;
            this.rbDrawMode.TabStop = true;
            this.rbDrawMode.Text = "Draw Mode";
            this.rbDrawMode.UseVisualStyleBackColor = true;
            this.rbDrawMode.CheckedChanged += new System.EventHandler(this.rbDrawMode_CheckedChanged);
            // 
            // rbPicMode
            // 
            this.rbPicMode.AutoSize = true;
            this.rbPicMode.Location = new System.Drawing.Point(108, 19);
            this.rbPicMode.Name = "rbPicMode";
            this.rbPicMode.Size = new System.Drawing.Size(107, 20);
            this.rbPicMode.TabIndex = 1;
            this.rbPicMode.Text = "Picture Mode";
            this.rbPicMode.UseVisualStyleBackColor = true;
            this.rbPicMode.CheckedChanged += new System.EventHandler(this.rbPicMode_CheckedChanged);
            // 
            // gbTimerSpeed
            // 
            this.gbTimerSpeed.Controls.Add(this.nudTimerSpeed);
            this.gbTimerSpeed.Controls.Add(this.lblChooseSpeed);
            this.gbTimerSpeed.Location = new System.Drawing.Point(6, 6);
            this.gbTimerSpeed.Name = "gbTimerSpeed";
            this.gbTimerSpeed.Size = new System.Drawing.Size(186, 67);
            this.gbTimerSpeed.TabIndex = 0;
            this.gbTimerSpeed.TabStop = false;
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.Image = global::TortoiseandHare.Properties.Resources.THRoad;
            this.pbRaceTrack.Location = new System.Drawing.Point(12, 118);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(1000, 200);
            this.pbRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceTrack.TabIndex = 0;
            this.pbRaceTrack.TabStop = false;
            this.pbRaceTrack.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRaceTrack_Paint);
            // 
            // tpStats
            // 
            this.tpStats.Controls.Add(this.gbStats);
            this.tpStats.Controls.Add(this.groupBox2);
            this.tpStats.Location = new System.Drawing.Point(4, 25);
            this.tpStats.Name = "tpStats";
            this.tpStats.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats.Size = new System.Drawing.Size(1025, 405);
            this.tpStats.TabIndex = 1;
            this.tpStats.Text = "Statistics";
            this.tpStats.UseVisualStyleBackColor = true;
            // 
            // gbStats
            // 
            this.gbStats.Controls.Add(this.lblStatsGamesPlayed);
            this.gbStats.Controls.Add(this.txtStatsTotalGamesPlayed);
            this.gbStats.Controls.Add(this.lblStatsHWins);
            this.gbStats.Controls.Add(this.lblStatsTie);
            this.gbStats.Controls.Add(this.lblStatsTWins);
            this.gbStats.Controls.Add(this.txtStatsHareWins);
            this.gbStats.Controls.Add(this.txtStatsTies);
            this.gbStats.Controls.Add(this.txtStatsTortoiseWins);
            this.gbStats.Location = new System.Drawing.Point(643, 34);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(126, 194);
            this.gbStats.TabIndex = 2;
            this.gbStats.TabStop = false;
            // 
            // lblStatsGamesPlayed
            // 
            this.lblStatsGamesPlayed.AutoSize = true;
            this.lblStatsGamesPlayed.Location = new System.Drawing.Point(6, 16);
            this.lblStatsGamesPlayed.Name = "lblStatsGamesPlayed";
            this.lblStatsGamesPlayed.Size = new System.Drawing.Size(131, 16);
            this.lblStatsGamesPlayed.TabIndex = 16;
            this.lblStatsGamesPlayed.Text = "Total Games Played";
            // 
            // txtStatsTotalGamesPlayed
            // 
            this.txtStatsTotalGamesPlayed.Location = new System.Drawing.Point(9, 32);
            this.txtStatsTotalGamesPlayed.Name = "txtStatsTotalGamesPlayed";
            this.txtStatsTotalGamesPlayed.ReadOnly = true;
            this.txtStatsTotalGamesPlayed.Size = new System.Drawing.Size(100, 22);
            this.txtStatsTotalGamesPlayed.TabIndex = 0;
            // 
            // lblStatsHWins
            // 
            this.lblStatsHWins.AutoSize = true;
            this.lblStatsHWins.Location = new System.Drawing.Point(6, 103);
            this.lblStatsHWins.Name = "lblStatsHWins";
            this.lblStatsHWins.Size = new System.Drawing.Size(70, 16);
            this.lblStatsHWins.TabIndex = 14;
            this.lblStatsHWins.Text = "Hare Wins";
            // 
            // lblStatsTie
            // 
            this.lblStatsTie.AutoSize = true;
            this.lblStatsTie.Location = new System.Drawing.Point(6, 142);
            this.lblStatsTie.Name = "lblStatsTie";
            this.lblStatsTie.Size = new System.Drawing.Size(34, 16);
            this.lblStatsTie.TabIndex = 13;
            this.lblStatsTie.Text = "Ties";
            // 
            // lblStatsTWins
            // 
            this.lblStatsTWins.AutoSize = true;
            this.lblStatsTWins.Location = new System.Drawing.Point(6, 61);
            this.lblStatsTWins.Name = "lblStatsTWins";
            this.lblStatsTWins.Size = new System.Drawing.Size(90, 16);
            this.lblStatsTWins.TabIndex = 12;
            this.lblStatsTWins.Text = "Tortoise Wins";
            // 
            // txtStatsHareWins
            // 
            this.txtStatsHareWins.Location = new System.Drawing.Point(9, 119);
            this.txtStatsHareWins.Name = "txtStatsHareWins";
            this.txtStatsHareWins.ReadOnly = true;
            this.txtStatsHareWins.Size = new System.Drawing.Size(100, 22);
            this.txtStatsHareWins.TabIndex = 2;
            // 
            // txtStatsTies
            // 
            this.txtStatsTies.Location = new System.Drawing.Point(9, 158);
            this.txtStatsTies.Name = "txtStatsTies";
            this.txtStatsTies.ReadOnly = true;
            this.txtStatsTies.Size = new System.Drawing.Size(100, 22);
            this.txtStatsTies.TabIndex = 3;
            // 
            // txtStatsTortoiseWins
            // 
            this.txtStatsTortoiseWins.Location = new System.Drawing.Point(9, 77);
            this.txtStatsTortoiseWins.Name = "txtStatsTortoiseWins";
            this.txtStatsTortoiseWins.ReadOnly = true;
            this.txtStatsTortoiseWins.Size = new System.Drawing.Size(100, 22);
            this.txtStatsTortoiseWins.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TortoiseVsHareChart);
            this.groupBox2.Location = new System.Drawing.Point(242, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TortoiseVsHareChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TortoiseVsHareChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TortoiseVsHareChart.Legends.Add(legend1);
            this.TortoiseVsHareChart.Location = new System.Drawing.Point(6, 12);
            this.TortoiseVsHareChart.Name = "TortoiseVsHareChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "RaceData";
            this.TortoiseVsHareChart.Series.Add(series1);
            this.TortoiseVsHareChart.Size = new System.Drawing.Size(379, 300);
            this.TortoiseVsHareChart.TabIndex = 0;
            this.TortoiseVsHareChart.Text = "Tortoise vs. Hare Chart";
            // 
            // frmTortoiseHare
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1052, 451);
            this.Controls.Add(this.tcRace);
            this.Name = "frmTortoiseHare";
            this.Text = "Tortoise vs. Hare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTortoiseHare_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerSpeed)).EndInit();
            this.gbScoreboard.ResumeLayout(false);
            this.gbScoreboard.PerformLayout();
            this.tcRace.ResumeLayout(false);
            this.tpRace.ResumeLayout(false);
            this.tpRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbT)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbChangeCol.ResumeLayout(false);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbTimerSpeed.ResumeLayout(false);
            this.gbTimerSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.tpStats.ResumeLayout(false);
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TortoiseVsHareChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Timer timerRace;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timerOuch;
        private System.Windows.Forms.NumericUpDown nudTimerSpeed;
        private System.Windows.Forms.Label lblChooseSpeed;
        private System.Windows.Forms.GroupBox gbScoreboard;
        private System.Windows.Forms.Button btnScoreReset;
        private System.Windows.Forms.Label lblHWin;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.Label lblTWin;
        private System.Windows.Forms.TextBox txtHWin;
        private System.Windows.Forms.TextBox txtTie;
        private System.Windows.Forms.TextBox txtTWin;
        private System.Windows.Forms.TabControl tcRace;
        private System.Windows.Forms.TabPage tpRace;
        private System.Windows.Forms.TabPage tpStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart TortoiseVsHareChart;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.TextBox txtGamesPlayed;
        private System.Windows.Forms.GroupBox gbTimerSpeed;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatsGamesPlayed;
        private System.Windows.Forms.TextBox txtStatsTotalGamesPlayed;
        private System.Windows.Forms.Label lblStatsHWins;
        private System.Windows.Forms.Label lblStatsTie;
        private System.Windows.Forms.Label lblStatsTWins;
        private System.Windows.Forms.TextBox txtStatsHareWins;
        private System.Windows.Forms.TextBox txtStatsTies;
        private System.Windows.Forms.TextBox txtStatsTortoiseWins;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbChangeCol;
        private System.Windows.Forms.Button btnChangeColT;
        private System.Windows.Forms.Button btnChangeColH;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbDrawMode;
        private System.Windows.Forms.RadioButton rbPicMode;
        private System.Windows.Forms.PictureBox pbT;
        private System.Windows.Forms.PictureBox pbH;
        private System.Windows.Forms.Label lblOuch;
    }
}

