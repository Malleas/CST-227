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
        static Board board = new Board(size);
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please set difficulty 1-100.");
            //todo add validation to ensure number is between 1-100
            int difficulty = int.Parse(Console.ReadLine());
      

            board.SetupLiveNeighbors(difficulty);

            printBoard();
            
        }

        static void printBoard()
        {
            Console.Clear();
            PrintLine();
            PrintRow("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12");
            foreach (var cell in board.Grid)
            {
                if (cell.Live)
                {
                    PrintRow("*");
                }
                PrintRow(cell.Neighbors.ToString());
            }
            
            PrintLine();
            PrintRow("", "", "", "", "", "", "", "", "", "", "", "", "1");
            //PrintRow("", "", "", "");
            PrintLine();
            PrintRow("", "", "", "", "", "", "", "", "", "", "", "", "2");
            Console.ReadLine();


        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";
            foreach(string column in columns)
            {
                row += AlignCenter(column, width) + "|";
            }
            Console.WriteLine(row);
        }

        static string AlignCenter(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
