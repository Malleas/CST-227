using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilestoneClassLibrary;

namespace MilestoneGUI
{
    public partial class Form3 : Form
    {
        List<PlayerStats> statsList = new List<PlayerStats>();
        List<PlayerStats> inputFeed = new List<PlayerStats>();
        BindingSource playerStatsBinding = new BindingSource();
        static public TimeSpan timespan;
        public Form3()
        {

            InitializeComponent();
            setBindings();
            populateHighScores();
        }

        private void setBindings()
        {
            playerStatsBinding.DataSource = statsList;
            highScoreListBox.DataSource = playerStatsBinding;
            highScoreListBox.DisplayMember = "Display";
            highScoreListBox.ValueMember = "Display";
        }

        private void populateHighScores()
        {
            string filepath = @"C:\demos\MilestonePlayerStats2.txt";
            if (!File.Exists(filepath))
            {
                using (FileStream fs = File.Create(filepath)) ;
            }
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                PlayerStats stats = new PlayerStats();
                stats.playerInitials = entries[0];
                stats.gameDifficulty = entries[1];
                stats.timeElapsed = entries[2];
                stats.score = int.Parse(entries[3]);
                inputFeed.Add(stats);
                

            }

            var highScoresHard =
                (from stats in inputFeed
                where stats.gameDifficulty.Equals("Hard")
                orderby stats.score descending
                select stats).Take(5);
            foreach(PlayerStats stats in highScoresHard)
            {
                statsList.Add(stats);
            }
            var highScoresMedium =
                (from stats in inputFeed
                 where stats.gameDifficulty.Equals("Medium")
                 orderby stats.score
                 select stats).Take(5);
            foreach (PlayerStats stats in highScoresMedium)
            {
                statsList.Add(stats);
            }
            var highScoresEasy =
                (from stats in inputFeed
                 where stats.gameDifficulty.Equals("Easy")
                 orderby stats.score
                 select stats).Take(5);
            foreach (PlayerStats stats in highScoresEasy)
            {
                statsList.Add(stats);
            }
            statsList.Sort();

            playerStatsBinding.ResetBindings(true);
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveScoreBtn_Click(object sender, EventArgs e)
        {
            PlayerStats player = new PlayerStats();
            try
            {
                if (playerInitialsTextBox.Text.Equals(""))
                {
                    throw new Exception("Player initials can not be blank if you want to record your score, please re enter.");
                }
                else
                {
                    player.playerInitials = playerInitialsTextBox.Text;
                    int playerScore = 0;
                    int totalSeconds = 0;

                    switch (Form1.Difficulty)
                    {
                        case 33:
                            player.gameDifficulty = "Easy";
                            totalSeconds = (timespan.Minutes * 60) + (60 - timespan.Seconds);
                            playerScore = totalSeconds * 10;
                            break;

                        case 66:
                            player.gameDifficulty = "Medium";
                            totalSeconds = (timespan.Minutes * 60) + (60 - timespan.Seconds);
                            playerScore = totalSeconds * 20;

                            break;

                        case 99:
                            player.gameDifficulty = "Hard";
                            totalSeconds = (timespan.Minutes * 60) + (60 - timespan.Seconds);
                            playerScore = totalSeconds * 50;
                            break;

                        default:
                            break;

                    }
                    player.timeElapsed = string.Format("{0:00}{1:00}", timespan.Minutes, timespan.Seconds);
                    player.score = playerScore;
                    statsList.Add(player);
                    playerStatsBinding.ResetBindings(false);
                    saveScoreBtn.Hide();

                    List<string> outputLines = new List<string>();
                    foreach (PlayerStats stats in statsList)
                    {
                        outputLines.Add(stats.playerInitials + "," + stats.gameDifficulty + "," + stats.timeElapsed + "," + stats.score);
                    }
                    string outPath = @"C:\demos\MilestonePlayerStats.txt";
                    File.WriteAllLines(outPath, outputLines);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
