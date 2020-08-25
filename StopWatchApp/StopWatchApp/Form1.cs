using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace StopWatchApp
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        static private int score = 0;
        private int misses = 0;
        private int highScore = 0;
        private int difficulty = 0;
        static private int tBtnHeight = 100;
        static private int tBtnWidth = 100;
        string[] imageArray = new string[5] { @"C:\Users\xxxfa\Dropbox\GCU Work\CST-227\CST-227\StopWatchApp\StopWatchApp\Images\mole.png", 
            @"C:\Users\xxxfa\Dropbox\GCU Work\CST-227\CST-227\StopWatchApp\StopWatchApp\Images\cap.png",
            @"C:\Users\xxxfa\Dropbox\GCU Work\CST-227\CST-227\StopWatchApp\StopWatchApp\Images\hulk.png",
            @"C:\Users\xxxfa\Dropbox\GCU Work\CST-227\CST-227\StopWatchApp\StopWatchApp\Images\download.png",
            @"C:\Users\xxxfa\Dropbox\GCU Work\CST-227\CST-227\StopWatchApp\StopWatchApp\Images\1up.jpg" };
        static private int level = 0;
        

        public Form1()
        {
            
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            watch.Start();
            gameTimer.Enabled = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            watch.Stop();
            gameTimer.Enabled = false;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            levelLabel.Text = "Level: " + (level + 1).ToString();
            //Microsoft Doccumentation (n.d.) Stopwatch.Elapsed Property.  Retrieved from: https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch.elapsed?view=netcore-3.1
            //Dropping milliseconds.
            TimeSpan ts = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            displayTimerLabel.Text = elapsedTime;
            gameBoardBtn.BackgroundImage = new Bitmap(imageArray[level]);
            gameBoardBtn.BackgroundImageLayout = ImageLayout.Center;
            

            if (gameTimer.Enabled && random.Next(0, 10) < 5)
            {
               
               
                int randomColor = random.Next(0, 4);
                

                if (randomColor > 0)
                {
                    targetBtn.Height = tBtnHeight;
                    targetBtn.Width = tBtnWidth;
                    targetBtn.Left = random.Next(0, (gameBoardBtn.Width - targetBtn.Width));
                    targetBtn.Top = random.Next(0, (gameBoardBtn.Height - targetBtn.Height));
                    targetBtn.BackColor = Color.Green;
                    targetBtn.Text = "Click Me!!";
                    if (targetBtn.Left < 0)
                    {
                        targetBtn.Left = 0;
                    }

                    if (targetBtn.Top < 0)
                    {
                        targetBtn.Top = 0;
                    }
                    targetBtn.Visible = true;
                }
                else
                {
                    targetBtn.BackColor = Color.Red;
                    targetBtn.Text = "It's a Bomb!!";
                }
                
                checkConditions(ts);
            }

        }

        private void targetBtn_Click(object sender, EventArgs e)
        {
            
            if (targetBtn.BackColor.Equals(Color.Green) && (tBtnHeight > 20 && tBtnWidth > 20) )
            {
                targetBtn.Visible = false;
                score += 1;
                difficulty = score * 5;
                scoreValueLabel.Text = score.ToString();
                tBtnHeight = tBtnHeight - difficulty;
                tBtnWidth = tBtnWidth - difficulty;
            }
            else if(targetBtn.BackColor.Equals(Color.Green) && (tBtnHeight < 20 && tBtnWidth < 20))
            {
                targetBtn.Visible = false;
                score += 1;
            }
            else
            {
                targetBtn.Visible = false;
                score -= 5;
                difficulty = score * 5;
                scoreValueLabel.Text = score.ToString();
                tBtnHeight = tBtnHeight + (difficulty * -1);
                tBtnWidth = tBtnWidth + (difficulty * -1);
            }
            
        }

        private void gameBoardBtn_Click(object sender, EventArgs e)
        {
            score -= 1;
            misses += 1;
            scoreValueLabel.Text = score.ToString();
        }

        private void checkConditions(TimeSpan ts)
        {
            if (ts.Minutes > 0)
            {
                gameTimer.Enabled = false;
                targetBtn.Visible = false;
                MessageBox.Show("Game Over" + "\n" + "Your high score was: " + score);
                playAgainBtn.Visible = true;

            }
            else if (misses > 3)
            {
                gameTimer.Enabled = false;
                targetBtn.Visible = false;
                MessageBox.Show("Game Over" + "\n" + "Your high score was: " + score);
                playAgainBtn.Visible = true;
            }
            else if (score == 50)
            {
                gameTimer.Enabled = false;
                targetBtn.Visible = false;
                level += 1;
                MessageBox.Show("Congratulations, you've won!!" + "\n" + "Your high score was: " + score);
                playAgainBtn.Visible = true;
            }else if(tBtnHeight <= 20 && tBtnWidth <= 20)
            {
                gameTimer.Enabled = false;
                targetBtn.Visible = false;
                level += 1;
                MessageBox.Show("Congratulations, you've won!!" + "\n" + "Your high score was: " + score);
                playAgainBtn.Visible = true;
            }



        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            playAgainBtn.Visible = false;
            watch.Reset();
            TimeSpan ts = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            displayTimerLabel.Text = elapsedTime;
            score = 0;
            misses = 0;
            tBtnHeight = 100;
            tBtnWidth = 100;
            if(score > highScore)
            {
                highScore = score;
                highScoreValueLabel.Text = highScore.ToString();
            }
        }
    }
}
