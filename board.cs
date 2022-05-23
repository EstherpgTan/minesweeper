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

		// Select a random number that fits inside the grid.
		// Generates 10 random lines. Generate 1 random line.

		// Setting up of Bombs
		public void setupBombs()
		{
			// Random number generator for calculating bomb placement
			Random random = new Random();

			// Looping through entire grid //
			for (int i = 0; i < Size; i++)
			{
				for (int j = 0; j < Size; j++)
				{
					
				}
			}

		}

		// Calculate how many neighbors are live / bombs
		public void CalcLiveNeighbors()
		{
			for (int i = 0; i < Size; i++)
			{
				for (int j = 0; j < Size; j++)
				{

                    // NW of current square
                    if (i - 1 >= 0 && j - 1 >= 0 && Grid[i - 1, j - 1].IsLive) Grid[i, j].LiveNeighbors++;

					// N
					if (r - 1 >= 0 && Grid[r - 1, c].IsLive) Grid[r, c].LiveNeighbors++;


					// NE
					if (i - 1 >= 0 && j + 1 < Size && Grid[i - 1, j + 1].IsLive) Grid[i, j].LiveNeighbors++;

					// W
					if (i - 1 >= 0 && Grid[i, j - 1].IsLive) Grid[i, j].LiveNeighbors++;

					// E
					if (j + 1 < Size && Grid[i, j + 1].IsLive) Grid[i, j].LiveNeighbors++;

					// SW
					if (i + 1 < Size && j - 1 >= 0 && Grid[i + 1, j - 1].IsLive) Grid[i, j].LiveNeighbors++;

					// S
					if (i + 1 < Size && Grid[i + 1, j].IsLive) Grid[i, j].LiveNeighbors++;

					// SE
					if (i + 1 < Size && j + 1 < Size && Grid[i + 1, j + 1].IsLive) Grid[i, j].LiveNeighbors++;

				}
			}
		}




	}
}


