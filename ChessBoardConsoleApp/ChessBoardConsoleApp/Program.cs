using System;
using ChessBoardModel;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board board = new Board(8);
        static string piece = "";
        static void Main(string[] args)
        {
            
           //show the empty chess board
           printGrid(board);
           //get the location of the chess piece
           Cell myLocation = setCurrentCell();
            //calculate and mark the cells where legal moves are possible.
            Console.Out.WriteLine("Please select which piece you would like to use.  IE: Knight, Rook, King etc");

            while (string.IsNullOrEmpty(piece)) {
                try
                {
                    piece = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine(e.Message);
                }
            }

            
           board.MarkNextLegalMoves(myLocation, piece);
           //show the chessboard. Use "." for an empty square and "X" for the piece location and  "+" for possible legal moves.
           printGrid(board, myLocation.RowNumber, myLocation.ColumnNumber);
           //wait for another return key to end the program
           Console.ReadLine();

        }

        static public void printGrid(Board board)
        {
            Console.WriteLine("+---+---+---+---+---+---+---+---+");
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    if (board.theGrid[i, j].CurrentlyOccupied)
                    {
                        Console.Write("{0} {1}","|", "X ");
                    }else if (board.theGrid[i, j].LegalNextMove)
                    {
                        Console.Write("{0} {1}", "|", "+ ");
                    }
                    else
                    {
                        Console.Write("{0} {1}", "| ", " ");
                        
                        

                    }
                }
                Console.WriteLine("|");
                Console.WriteLine("+---+---+---+---+---+---+---+---+");
            }
            
        }

        static public void printGrid(Board board, int row, int col)
        {
            Console.WriteLine("You have chosen to put a " + piece.ToUpper() + " at (" + row + "," + col + ")");
            Console.WriteLine("Here are the legal moves you can make.");
            Console.WriteLine("+---+---+---+---+---+---+---+---+");
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    if (board.theGrid[i, j].CurrentlyOccupied)
                    {
                        Console.Write("{0} {1}", "|", "X ");
                    }
                    else if (board.theGrid[i, j].LegalNextMove)
                    {
                        Console.Write("{0} {1}", "|", "+ ");
                    }
                    else
                    {
                        Console.Write("{0} {1}", "| ", " ");



                    }
                }
                Console.WriteLine("|");
                Console.WriteLine("+---+---+---+---+---+---+---+---+");
            }

        }

        static public Cell setCurrentCell()
        {
            int currentRow = -1;
            int currentCol = -1;

            while (currentRow < 0 || currentRow > 7) {
                Console.Out.Write("Enter your current row number.  Please enter a number between 0 - 7:  ");
                currentRow = int.Parse(Console.ReadLine());
            }
            while (currentCol < 0 || currentCol > 7) {
                Console.Out.Write("Enter your current column number.  Please enter a number between 0 - 7:  ");
                currentCol = int.Parse(Console.ReadLine());
            }

            board.theGrid[currentRow, currentCol].CurrentlyOccupied = true;

            return board.theGrid[currentRow, currentCol];
        }
    }
}
