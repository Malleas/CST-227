﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilestoneClassLibrary
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool Visited { get; set; }
        public bool Live { get; set; }
        public int Neighbors { get; set; }
        public bool VisitedNeighbor { get; set; }

        public Cell (int row, int column, bool visited, bool live, int neighbors, bool visitedNeighbor)
        {
            Row = row;
            Column = column;
            Visited = visited;
            Live = live;
            Neighbors = neighbors;
            VisitedNeighbor = visitedNeighbor;
        }

        public Cell()
        {
            Row = -1;
            Column = -1;
            Visited = false;
            Live = false;
            Neighbors = 0;
            VisitedNeighbor = false;
        }
    }
}
