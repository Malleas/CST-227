using System;

//GeeksforGeeks (2019, October 10) Warnsdorff's algorithm for Knights tour problem.  Retrieved from: https://www.geeksforgeeks.org/warnsdorffs-algorithm-knights-tour-problem/
//While there was no direct C# example of this, i inturpreted the Java example to C# to complete this exercise and updated some of the variable so i could write the code, understand it
//and ultimately trouble shoot it.

namespace KnightTour
{
    class Program
    {
        static int BoardSize = 8;
        static int attemptedMoves = 0;
        static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };
        static int[,] boardGrid = new int[BoardSize, BoardSize];
        static Random random = new Random();
       
        static void Main(string[] args)
        {
            Console.WriteLine("STart");
            while (!FindClosedTour())
            {
                ;
            }
            Console.ReadLine();

        }


        static void print(int[] inputArray)
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write("{0}{1}", "| ", inputArray[j * BoardSize + i] + " " );
                  
                }
                Console.WriteLine(" |");
                Console.WriteLine();
            }
        }

        static bool neighbor(int currX, int currY, int startingX, int startingY)
        {
            for (int i = 0; i < BoardSize; i++)
            {
                if (((currX + xMove[i])==startingX) && (currY + yMove[i]) == startingY)
                {
                    return true;
                }

            }
            return false;
        }

        static bool isSquareSafe(int x, int y)
        {
            return (x >= 0 && x < BoardSize && y >= 0 && y < BoardSize);
        }

        static bool isEmpty(int[] inputArray, int x, int y)
        {
            return (isSquareSafe(x, y)) && (inputArray[y * BoardSize + x] < 0);
        }

        static int getDegree(int[] inputArray, int nextX, int nextY)
        {
            int count = 0;
            for (int i = 0; i < BoardSize; i++)
                if (isEmpty(inputArray, (nextX + xMove[i]), (nextY + yMove[i])))
            count++;
            return count;
        }

        static Cell nextMove(int[] inputArray, Cell cell)
        {
            int min_degree_index = -1;
            int c;
            int min_degree = (BoardSize + 1);
            int nextX;
            int nextY;

            int start = random.Next(1000) % BoardSize;
            for (int count = 0; count < BoardSize; count++)
            {
                int i = (start + count) % BoardSize;
                nextX = cell.X + xMove[i];
                nextY = cell.Y + yMove[i];
                if(isEmpty(inputArray, nextX, nextY) && (c = getDegree(inputArray, nextX, nextY)) < min_degree)
                {
                    min_degree_index = i;
                    min_degree = c;
                }
            }

            if (min_degree_index == -1)
                return null;

            nextX = cell.X + xMove[min_degree_index];
            nextY = cell.Y + yMove[min_degree_index];

            inputArray[nextY * BoardSize + nextX] = inputArray[(cell.Y) * BoardSize + (cell.X)] + 1;

            cell.X = nextX;
            cell.Y = nextY;

            return cell;
        }

        static bool FindClosedTour()
        {
            int[] spaceNumbers = new int[BoardSize * BoardSize];
            for (int i = 0; i < BoardSize * BoardSize; i++)
                spaceNumbers[i] = -1;
            
            int startingX = random.Next() % BoardSize;
            int startingY = random.Next() % BoardSize;

            Cell cell = new Cell(startingX, startingY);

            //sets starting cell position to one in the spaces array
            spaceNumbers[cell.Y * BoardSize + cell.X] = 1;

            Cell current = null;

            for (int i = 0; i < BoardSize * BoardSize - 1; i++)
            {
                current = nextMove(spaceNumbers, cell);
                if (current == null)
                    return false;
            }
            if (!neighbor(current.X, current.Y, startingX, startingY))
                return false;

            
            
            print(spaceNumbers);
            return true;
        }

    }
}
