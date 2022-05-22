using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
	public class Board
	{ 
		// Size of board. 
		public int Size { get; set; }

		// Cell, X & Y coordinates. Grid is a 2d array of cells.
		public Cell[,] Grid { get; set; }

		// Constructor
		public Board (int s)
        {
			// Initial size of the board defined by s
			Size = s;

			// Creating a new cell
			Grid = new Cell[Size, Size];

			// Initialising the array
			// Row
			for (int i = 0; i < Size; i++)
            {
				// Column
				for (int j = 0; j < Size; j++)
                {
					// New cell created in array with x & y coordinate
					Grid[i, j] = new Cell(i, j);
                }
            }
        }

		
	}
}


