using MilestoneClassLibrary;
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

namespace MilestoneGUI
{
    public partial class Form2 : Form
    {
        public Button[,] buttonGrid = new Button[12, 12];
        static public int size = 12;
        static Board board;
        public int turnCount = 0;
        private Stopwatch watch = new Stopwatch();
        static int liveCount = 0;
        static int visitedCount = 0;
        string elapsedTime = "";
        
        public Form2()
        {
            InitializeComponent();
            this.Hide();

            populateGrid();
        }

        public void populateGrid()
        {
            int buttonSize = gameBoardPanel.Width / size;
            gameBoardPanel.Height = gameBoardPanel.Width;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    board = new Board(size, Form1.Difficulty);

                    buttonGrid[row, col] = new Button();
                    buttonGrid[row, col].Width = buttonSize;
                    buttonGrid[row, col].Height = buttonSize;
                    buttonGrid[row, col].MouseDown += button_MouseDown;
                    gameBoardPanel.Controls.Add(buttonGrid[row, col]);
                    buttonGrid[row, col].Location = new Point(buttonSize * row, buttonSize * col);
                    buttonGrid[row, col].Tag = row.ToString() + "|" + col.ToString();
                }


            }
        }

     

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                string[] strArr = (sender as Button).Tag.ToString().Split('|');
                int row = int.Parse(strArr[0]);
                int col = int.Parse(strArr[1]);
                board.Grid[row, col].Visited = false;
                buttonGrid[row, col].BackgroundImage = gameImageList.Images[1];
                buttonGrid[row, col].BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                watch.Start();
                gameTimer.Enabled = true;


                string[] strArr = (sender as Button).Tag.ToString().Split('|');
                int row = int.Parse(strArr[0]);
                int col = int.Parse(strArr[1]);



                if (board.Grid[row, col].Live)
                {
                    foreach (var cell in board.Grid)
                    {
                        cell.Visited = true;
                        buttonGrid[cell.Row, cell.Column].BackColor = Color.LightBlue;
                        if (cell.Live)
                        {
                            buttonGrid[cell.Row, cell.Column].BackgroundImage = gameImageList.Images[0];
                            buttonGrid[cell.Row, cell.Column].BackgroundImageLayout = ImageLayout.Center;
                        }
                        else if (cell.Neighbors > 0)
                        {
                            buttonGrid[cell.Row, cell.Column].Text = cell.Neighbors.ToString();
                        }
                        else
                        {
                            buttonGrid[cell.Row, cell.Column].Text = "";
                        }

                    }
                    watch.Stop();
                    gameTimer.Enabled = false;
                    DialogResult dialogResult = MessageBox.Show("Game over!", "", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {

                        Form3 f3 = new Form3();
                        this.Close();
                        f3.Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                    gameTimer.Enabled = false;
                }
                else
                {
                    floodFill(row, col);
                }

                foreach (var cell in board.Grid)
                {
                    if (cell.Live)
                    {
                        liveCount += 1;
                    }
                    if (cell.Visited)
                    {
                        visitedCount += 1;
                        buttonGrid[cell.Row, cell.Column].BackColor = Color.LightBlue;
                        if (cell.Neighbors > 0)
                        {
                            buttonGrid[cell.Row, cell.Column].Text = cell.Neighbors.ToString();
                        }
                        else
                        {
                            buttonGrid[cell.Row, cell.Column].Text = "";
                        }
                    }
                }
                turnCount += 1;
                turnsCountLabel.Text = turnCount.ToString();
                if (visitedCount == (144 - liveCount))
                {
                    foreach (var cell in board.Grid)
                    {
                        if (cell.Live && !cell.Visited)
                        {
                            buttonGrid[cell.Row, cell.Column].BackgroundImage = gameImageList.Images[1];
                            buttonGrid[cell.Row, cell.Column].BackgroundImageLayout = ImageLayout.Center;
                            watch.Stop();
                            gameTimer.Enabled = false;
                            DialogResult dialogResult = MessageBox.Show("You've Won!!" + "\n" + "Your total game time was: " + elapsedTime, "", MessageBoxButtons.OKCancel);
                            if (dialogResult == DialogResult.OK)
                            {

                                Form3 f3 = new Form3();
                                this.Close();
                                f3.Show();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        static bool isValid(int row, int col)
        {
            if (row >= 0 && row < size && col >= 0 && col < size)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static public void floodFill(int row, int col)
        {

            if (!isValid(row, col) || board.Grid[row, col].Visited)
            {
                return;
            }
            board.Grid[row, col].Visited = true;
            if (board.Grid[row, col].Neighbors == 0)
            {

                floodFill(row + 1, col);
                floodFill(row - 1, col);
                floodFill(row, col + 1);
                floodFill(row, col - 1);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = watch.Elapsed;
            Form3.timespan = ts;
            elapsedTime = string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            displayTimerLabel.Text = elapsedTime;
        }
    }
}
