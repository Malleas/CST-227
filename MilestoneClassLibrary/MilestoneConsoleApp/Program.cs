using MilestoneClassLibrary;
using System;

//Print fuctions found at the following to format the output
// McDonald, Patrick(2009, May 13) How to: Best way to draw table in console app (C#).  Retrieved from: https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c

namespace MilestoneConsoleApp
{
    class Program
    {
        static int size = 12;
        static int tableWidth = 80;
        static Board board;

        public Board Board
        {
            get => default(Board);
            set
            {
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Please set difficulty 1-100.");
            //todo add validation to ensure number is between 1-100
            int difficulty = int.Parse(Console.ReadLine());
            board = new Board(size, difficulty);

            printBoard();
            
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
                Console.Write("  "+ i + "  |");
                Console.WriteLine();
                PrintLine();

            }

            Console.ReadLine();

        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
    }
}
