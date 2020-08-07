using MilestoneClassLibrary;
using System;

//Print fuctions found at the following to format the output
// McDonald, Patrick(2009, May 13) How to: Best way to draw table in console app (C#).  Retrieved from: https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c

namespace MilestoneConsoleApp
{
    class Program : Board
    {
        static int size = 12;
        static int tableWidth = 80;
        static Board board;
        static bool done = false;


        static void Main(string[] args)
        {
            int difficulty = -1;
            while (difficulty < 0 || difficulty > 100)
            {
                Console.WriteLine("Please set difficulty 1-100.");
                difficulty = int.Parse(Console.ReadLine());
            }
            board = new Board(size, difficulty);
            PrintBoardDuringGame(board);
            while (!done)
            {
                int row = -1;
                int col = -1;

                //ask the user for a row and column number

                Console.WriteLine("To play this game, you will need to provide two numbers indicating the Row and Column in which you would like to select an available location.");

                while (row < 0 || row > 11)
                {
                    Console.WriteLine("Please provide a row number between 0 and 11:");
                    row = int.Parse(Console.ReadLine());
                }

                while (col < 0 || col > 11)
                {
                    Console.WriteLine("Please provide a column number between 0 and 11:");
                    col = int.Parse(Console.ReadLine());
                }

                Cell myLocation = setCurrentCell(row, col);

                setVisitedNeighbors(row, col);
                //print the grid
                PrintBoardDuringGame(board);

                //If the grid contains a bomb at the chosen cell (row, column) then set done to true, display a failure msg
                if (board.Grid[row, col].Live)
                {
                    Console.WriteLine("***BOOM!!!  Game over!***");
                    Console.WriteLine("Press enter to exit the game.");
                    Console.ReadLine();
                    done = true;
                }
                //if all of the non bomb cells have been revealed then set the endgame condition to true, display a success message
                else
                {
                    int remainingToVisited = 144;
                    int totalBombs = 0;
                    foreach (var cell in board.Grid)
                    {

                        if (cell.Live)
                        {
                            totalBombs += 1;
                        }
                        if (cell.Visited)
                        {
                            remainingToVisited -= 1;
                        }

                    }
                    if (remainingToVisited == totalBombs)
                    {
                        Console.WriteLine("***Congrats, you have won!!!***");
                        Console.WriteLine("Press enter to exit the game");
                        Console.ReadLine();
                        done = true;
                    }

                }
            }

        }

        static void printBoard()
        {
            string[] row = new string[12];
            Console.WriteLine("  0  |  1  |  2  |  3  |  4  |  5  |  6  |  7  |  8  |  9  |  10  |  11  |");
            PrintLine();
            for (int i = 0; i < board.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < board.Grid.GetLength(1); j++)
                {
                    if (board.Grid[i, j].Live)
                    {
                        row[i] = "*";
                    }
                    else
                    {
                        row[i] = board.Grid[i, j].Neighbors.ToString();
                    }
                    Console.Write("  {0}  |", row[i]);


                }
                Console.Write("  " + i + "  |");
                Console.WriteLine();
                PrintLine();

            }

            Console.ReadLine();

        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintBoardDuringGame(Board board)
        {
            for (int i = 0; i < board.Grid.GetLongLength(0); i++)
            {
                for (int j = 0; j < board.Grid.GetLongLength(1); j++)
                {
                    if (board.Grid[i, j].Visited && board.Grid[i, j].Live)
                    {
                        Console.Write("{0}{1}", "|", "* ");

                    }
                    else if (board.Grid[i, j].Visited && !board.Grid[i, j].Live)
                    {

                        if (board.Grid[i, j].Neighbors == 0)
                        {
                            Console.Write("{0}{1}", "|", "  ");
                        }
                        else
                        {
                            Console.Write("{0}{1}", "|", board.Grid[i, j].Neighbors.ToString() + " ");
                        }
                    }
                    else if (board.Grid[i, j].VisitedNeighbor)
                    {
                        if (board.Grid[i, j].Neighbors == 0)
                        {
                            Console.Write("{0}{1}", "|", "  ");
                        }
                        else
                        {
                            Console.Write("{0}{1}", "|", board.Grid[i, j].Neighbors.ToString() + " ");
                        }
                    }
                    else
                    {
                        Console.Write("{0}{1}", "|", "? ");

                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }



        static public Cell setCurrentCell(int row, int col)
        {
            board.Grid[row, col].Visited = true;
            return board.Grid[row, col];
        }

        static public void setVisitedNeighbors(int row, int col)
        {
            int currentRow = row;
            int currentCol = col;
            if (currentRow - 1 >= 0 && currentCol - 1 >= 0)
            {
                board.Grid[row - 1, col - 1].VisitedNeighbor = true;
            }
            if (currentCol - 1 >= 0)
            {
                board.Grid[row, col - 1].VisitedNeighbor = true;
            }
            if (currentRow + 1 < size && currentCol - 1 >= 0)
            {
                board.Grid[row + 1, col - 1].VisitedNeighbor = true;
            }
            if (currentRow + 1 < size)
            {
                board.Grid[row + 1, col].VisitedNeighbor = true;
            }
            if (currentRow + 1 < size && currentCol + 1 < size)
            {
                board.Grid[row + 1, col + 1].VisitedNeighbor = true;
            }
            if (currentCol + 1 < size)
            {
                board.Grid[row, col + 1].VisitedNeighbor = true;
            }
            if (currentRow - 1 >= 0 && currentCol + 1 < size)
            {
                board.Grid[row - 1, col + 1].VisitedNeighbor = true;
            }
            if (currentRow - 1 >= 0)
            {
                board.Grid[row - 1, col].VisitedNeighbor = true;
            }

        }
    }
}
