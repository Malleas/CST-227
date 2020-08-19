using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public int turnCount = 0;
        public Form2()
        {
            InitializeComponent();
            this.Hide();
           
            populateGrid();
        }

        public void populateGrid()
        {
            int buttonSize = gameBoardPanel.Width / 12;
            gameBoardPanel.Height = gameBoardPanel.Width;

            for (int row = 0; row < 12; row++)
            {
                for (int col = 0; col < 12; col++)
                {
                    buttonGrid[row, col] = new Button();
                    buttonGrid[row, col].Width = buttonSize;
                    buttonGrid[row, col].Height = buttonSize;
                    buttonGrid[row, col].Click += Grid_Button_Click;
                    gameBoardPanel.Controls.Add(buttonGrid[row, col]);
                    buttonGrid[row, col].Location = new Point(buttonSize * row, buttonSize * col);
                    buttonGrid[row, col].Tag = row.ToString() + "|" + col.ToString();
                }


            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            string[] strArr = (sender as Button).Tag.ToString().Split('|');
            int row = int.Parse(strArr[0]);
            int col = int.Parse(strArr[1]);

            buttonGrid[row, col].BackColor = Color.Red;
            turnCount += 1;
            turnsCountLabel.Text = turnCount.ToString();
        }
    }
}
