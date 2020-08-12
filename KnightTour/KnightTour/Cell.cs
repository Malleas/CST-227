using System;
using System.Collections.Generic;
using System.Text;

namespace KnightTour
{
    class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Cell()
        {
            X = 0;
            Y = 0;
        }
    }

    
}
