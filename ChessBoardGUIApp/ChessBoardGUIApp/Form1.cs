using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        static public Board board = new Board(8);
        public Button[,] btnGrid = new Button[board.Size, board.Size];
        string input = "";
        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        public void populateGrid()
        {
            
            int buttonSize = gameBoardPanel.Width / board.Size;
            gameBoardPanel.Height = gameBoardPanel.Width; 

            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    btnGrid[row, col] = new Button();

                    btnGrid[row, col].Width = buttonSize;
                    btnGrid[row, col].Height = buttonSize;

                    btnGrid[row, col].Click += Grid_Button_Click;
                    gameBoardPanel.Controls.Add(btnGrid[row, col]);
                    btnGrid[row, col].Location = new Point(buttonSize * row, buttonSize * col);

                    btnGrid[row, col].Text = row.ToString() + "|" + col.ToString();

                    btnGrid[row, col].Tag = row.ToString() + "|" + col.ToString();

                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            string[] strArr = (sender as Button).Tag.ToString().Split('|');
            int row = int.Parse(strArr[0]);
            int col = int.Parse(strArr[1]);

            Cell currentCell = board.theGrid[row, col];
            board.MarkNextLegalMoves(currentCell, input);
            updateButtonLabels();

            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    btnGrid[i, j].BackColor = default(Color);
                }
            }

            (sender as Button).BackColor = Color.Cornsilk;
        }

        public void updateButtonLabels()
        {
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    btnGrid[row, col].Text = "";
                    if (board.theGrid[row, col].CurrentlyOccupied) btnGrid[row, col].Text = input;
                    if (board.theGrid[row, col].LegalNextMove) btnGrid[row, col].Text = "Legal";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pieceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (pieceComboBox.Text)
            {
                case "Knight":
                    input = "Knight";
                    break;

                case "King":
                    input = "King";
                    break;

                case "Rook":
                    input = "Rook";
                    break;

                case "Bishop":
                    input = "Bishop";
                    break;

                case "Queen":
                    input = "Queen";
                    break;

                default:
                    break;
            }
        }
    }
}
