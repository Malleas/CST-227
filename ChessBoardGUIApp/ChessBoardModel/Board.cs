using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] theGrid;

        public Board (int s)
        {
            Size = s;
            theGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chesspiece)
        {
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    theGrid[r, c].LegalNextMove = false;
                    theGrid[r, c].CurrentlyOccupied = false;
                }
            }

            

            switch (chesspiece.ToUpper())
            {
                case "KNIGHT":
                    currentCell.CurrentlyOccupied = true;
                    if (currentCell.RowNumber -2 >= 0 && currentCell.ColumnNumber -1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 2 < Size)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber + 2 < Size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 2 < Size && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 2 < Size && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber - 2 >= 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 2 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }

                    
                                       
                    break;

                case "KING":
                    currentCell.CurrentlyOccupied = true;
                    //-1,-1
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 1 >= 0) {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    //0,-1
                    if (currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    //+1,-1
                    if (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    //+1,0
                    if (currentCell.RowNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    //+1,+1
                    if (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    //0,+1
                    if (currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    //-1.+1
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    //-1,0
                    if (currentCell.RowNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                   
                    break;

                case "ROOK":
                    currentCell.CurrentlyOccupied = true;
                    //Get current location.
                    // rightHorizontalTravel == the amount of spaces to move to the right of current location.  this  == Size - currentCell.ColumnNumber
                    // leftHorizontalTravel == the amount of spaces to the left of the current location the piece can move.  this == currentCell.ColumnNumber -1
                    // upperVerticalTravel == the amount of spaces the piece can move in the direction of up (towards player).  This == size - currentCell.RowNumber
                    //  lowerVerticalTravel == the amount of spaces the piece can move in the direction of down (away from player).  this == currentCell.RowNumber - 1
                    // use for loops as long as i < LHT, RHT, LVT or UHT, update legal move to true
                    int rightHorizontalTravel = (Size - 1) - currentCell.ColumnNumber;
                    int leftHorizontalTravel = currentCell.ColumnNumber;
                    int lowerVerticalTravel = (Size - 1) - currentCell.RowNumber;
                    int upperVerticalTravel = currentCell.RowNumber;

                    for (int i = 1; i <= rightHorizontalTravel; i++)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    for (int i = 1; i <= leftHorizontalTravel; i++)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    for (int i = 1; i <= upperVerticalTravel; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    for (int i = 1; i <= lowerVerticalTravel; i++)
                    {
                        theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                    }

                    break;

                case "BISHOP":
                    currentCell.CurrentlyOccupied = true;
                    //These checks need to continue to run while something is not false.  Use a while loop to check the conditions do not run out of bounds and while that is true, set legal move to true         
                    int originalRow = currentCell.RowNumber;
                    int originalCol = currentCell.ColumnNumber;
                    
                    // -1 , -1
                    while(currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                        currentCell.RowNumber = currentCell.RowNumber - 1;
                        currentCell.ColumnNumber = currentCell.ColumnNumber - 1;
                    }
                    //reset current col/row bat to original
                    currentCell.RowNumber = originalRow;
                    currentCell.ColumnNumber = originalCol;
                    // +1 , -1
                    while(currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber > 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                        currentCell.RowNumber = currentCell.RowNumber + 1;
                        currentCell.ColumnNumber = currentCell.ColumnNumber - 1;
                    }
                    //reset current col/row bat to original
                    currentCell.RowNumber = originalRow;
                    currentCell.ColumnNumber = originalCol;

                    // +1 , +1
                    while (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                        currentCell.RowNumber = currentCell.RowNumber + 1;
                        currentCell.ColumnNumber = currentCell.ColumnNumber + 1;
                    }
                    //reset current col/row bat to original
                    currentCell.RowNumber = originalRow;
                    currentCell.ColumnNumber = originalCol;

                    // -1 , +1
                    while (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                        currentCell.RowNumber = currentCell.RowNumber - 1;
                        currentCell.ColumnNumber = currentCell.ColumnNumber + 1;
                    }
                    currentCell.RowNumber = originalRow;
                    currentCell.ColumnNumber = originalCol;
                    break;

                case "QUEEN":
                    currentCell.CurrentlyOccupied = true;
                    // Use Rook and Bishop to set legal moves.
                    int queenRightHorizontalTravel = (Size - 1) - currentCell.ColumnNumber;
                    int queenLeftHorizontalTravel = currentCell.ColumnNumber;
                    int queenLowerVerticalTravel = (Size - 1) - currentCell.RowNumber;
                    int queenUpperVerticalTravel = currentCell.RowNumber;

                    for (int i = 1; i <= queenRightHorizontalTravel; i++)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    for (int i = 1; i <= queenLeftHorizontalTravel; i++)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    for (int i = 1; i <= queenUpperVerticalTravel; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    for (int i = 1; i <= queenLowerVerticalTravel; i++)
                    {
                        theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                    }

                 
                    int queenOriginalRow = currentCell.RowNumber;
                    int queenOriginalCol = currentCell.ColumnNumber;

                    // -1 , -1
                    while (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                        currentCell.RowNumber = currentCell.RowNumber - 1;
                        currentCell.ColumnNumber = currentCell.ColumnNumber - 1;
                    }
                    //reset current col/row bat to original
                    currentCell.RowNumber = queenOriginalRow;
                    currentCell.ColumnNumber = queenOriginalCol;
                    // +1 , -1
                    while (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber > 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                        currentCell.RowNumber = currentCell.RowNumber + 1;
                        currentCell.ColumnNumber = currentCell.ColumnNumber - 1;
                    }
                    //reset current col/row bat to original
                    currentCell.RowNumber = queenOriginalRow;
                    currentCell.ColumnNumber = queenOriginalCol;

                    // +1 , +1
                    while (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                        currentCell.RowNumber = currentCell.RowNumber + 1;
                        currentCell.ColumnNumber = currentCell.ColumnNumber + 1;
                    }
                    //reset current col/row bat to original
                    currentCell.RowNumber = queenOriginalRow;
                    currentCell.ColumnNumber = queenOriginalCol;

                    // -1 , +1
                    while (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                        currentCell.RowNumber = currentCell.RowNumber - 1;
                        currentCell.ColumnNumber = currentCell.ColumnNumber + 1;
                    }
                    currentCell.RowNumber = queenOriginalRow;
                    currentCell.ColumnNumber = queenOriginalCol;
                    break;

                default:
                    Console.WriteLine("Input of " + chesspiece + " is not a valid chess piece, no moves to show");
                    break;
            }
        }
    }
}
