using MilestoneClassLibrary;
using System;

//Print fuctions found at the following to format the output
// McDonald, Patrick(2009, May 13) How to: Best way to draw table in console app (C#).  Retrieved from: https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c

namespace MilestoneConsoleApp
{
    class Program
    {
        static int size = 12;
        static Board board;
        static bool done = false;
        static int[] rowMove = { -1, 0, 1, 1, 1, 0, -1, -1 };
        static int[] colMove = { -1, -1, -1, 0, 1, 1, 1, 0 };


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


                floodFill(row, col);
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
                    else if (board.Grid[i, j].Visited  && !board.Grid[i, j].Live)
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
            if (board.Grid[row, col].Neighbors == 0 )
            {
                
                floodFill(row + 1, col);
                floodFill(row - 1, col);
                floodFill(row, col + 1);
                floodFill(row, col - 1);
            }

        }

    }
}
