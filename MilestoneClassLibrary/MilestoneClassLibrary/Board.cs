using System;
using System.Collections.Generic;
using System.Text;

namespace MilestoneClassLibrary
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] Grid { get; set; }
        public int Difficulty { get; set; }

        public Board(int size, int difficulty)
        {
            Size = size;
            //for each location on the grid, create a new cell and set the row/column to current index location.  Set live and visited to false.  Neighbors can be set to the number of neighboring cells that are not live.
            // if [0,0] has three neighbors and all are not live, neighbors would be set to 3.
            Grid = new Cell[size, size];

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Cell cell = new Cell();
                    cell.Row = i;
                    cell.Column = j;
                    cell.Live = false;
                    cell.Visited = false;
                    cell.Neighbors = 0;
                    Grid[i, j] = cell;
                }
            }

            SetupLiveNeighbors(difficulty);

            foreach(var cell in Grid)
            {
                calculateLIveNeighbors(cell.Row, cell.Column);
            }

           
        }

       

        public void SetupLiveNeighbors(int difficulty)
        {
            Random rand = new Random();

            for (int i = 0; i <= difficulty; i++)
            {
                int randomRow = rand.Next(0, 11);
                int randomColumn = rand.Next(0, 11);
                               
                    Grid[randomRow, randomColumn].Live = true; 

            }
            //initialize the a random grid with "live" bombs.  Pick cells at randome based on the created grid and set cells live() from false to true
            //use difficulty to make a certain % of the cells live based on difficulty input.  Difficulty == #ofCells / difficulty = % of cells that are live (round up)
        }

        public void calculateLIveNeighbors(int row, int column)
        {

          
            if (Grid[row, column].Live)
            {
                Grid[row, column].Neighbors += 1;
            }
            Grid[row, column].Neighbors += checkTopLeft(row, column);
            Grid[row, column].Neighbors += checkTopCenter(row, column);
            Grid[row, column].Neighbors += checkTopRight(row, column);
            Grid[row, column].Neighbors += checkCenterLeft(row, column);
            Grid[row, column].Neighbors += checkCenterRight(row, column);
            Grid[row, column].Neighbors += checkBottomLeft(row, column);
            Grid[row, column].Neighbors += checkBottomCenter(row, column);
            Grid[row, column].Neighbors += checkBottomRight(row, column);
            
            //need to know current location.
            //  eval current location and the surrounding squares.  if location is 2,2  you can draw a square around it.  Use current and move through each surrounding sqare to see if is is live or not.  if live, += live,
            // return live and use it to update the value for Neighbors for each cell
        

            //A cell can have 0-8 live neighbors.  if the cell itself is live, the value can be set to 9
        }

        public int checkTopLeft(int row, int col)
        {
            int calcRow = row - 1;
            int calcCol = col - 1;
            int calcLive = 0;
            if(calcRow < 0 || calcCol < 0)
            {
                calcLive = 0;
            }
            else if (Grid[calcRow, calcCol].Live)
            {
                calcLive = 1;
            }
            return calcLive;
       
        }
        public int checkTopCenter(int row, int col)
        {
            int calcRow = row - 1;
            int calcLive = 0;
            if (calcRow < 0)
            {
                calcLive = 0;
            }
            else if(Grid[row - 1, col].Live)
            {
                calcLive = 1;
            }
            return calcLive;
        }

        public int checkTopRight(int row, int col)
        {
            int calcRow = row - 1;
            int calcCol = col + 1;
            int calcLive = 0;
            if (calcRow < 0 || calcCol > 11)
            {
                calcLive = 0;
            }
            else if (Grid[row - 1, col + 1].Live)
            {
                calcLive = 1;
            }
            return calcLive;
        }

        public int checkCenterLeft(int row, int col)
        {
           
            int calcCol = col - 1;
            int calcLive = 0;
            if (calcCol < 0)
            {
                calcLive = 0;
            }
            else if (Grid[row, col - 1].Live)
            {
                calcLive = 1;
            }
            return calcLive;
        }

        public int checkCenterRight(int row, int col)
        {
            int calcCol = col + 1;
            int calcLive = 0;
            if (calcCol > 11)
            {
                calcLive = 0;
            }
            else if (Grid[row, col + 1].Live)
            {
                calcLive = 1;
            }
            return calcLive;
        }
        public int checkBottomLeft(int row, int col)
        {
            int calcRow = row + 1;
            int calcCol = col - 1;
            int calcLive = 0;
            if (calcRow > 11 || calcCol < 0)
            {
                calcLive = 0;
            }
            else if(Grid[row + 1, col - 1].Live)
            {
                calcLive = 1;
            }
            return calcLive;
        }
        public int checkBottomCenter(int row, int col)
        {
            int calcRow = row + 1;
            int calcLive = 0;
            if (calcRow > 11)
            {
                calcLive = 0;
            }
            else if (Grid[row + 1, col].Live)
            {
                calcLive = 1;
            }
            return calcLive;
        }
        public int checkBottomRight(int row, int col)
        {
            int calcRow = row + 1;
            int calcCol = col + 1;
            int calcLive = 0;
            if (calcRow > 11 || calcCol > 11)
            {
                calcLive = 0;
            }
            else if (Grid[row + 1, col + 1].Live)
            {
                calcLive = 1;
            }
            return calcLive;
        }

    }
}
