using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.AddRange(System.Collections.Generic.IEnumerable<T> collection);

namespace minesweeper
{
	public class Board
	{
		// Size of board. 
		public int Size { get; set; }

		// Cell, X & Y coordinates. Grid is a 2d array of cells.
		public Cell[,] Grid { get; set; }

		// Constructor
		public Board(int s)
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


		// Setting up of Bombs
		public void setupBombs()
		{
			// Random number generator for calculating bomb placement
			Random random = new Random();

			int bombCount = 0;
			while (bombCount <= 10)
			{ int x = random.Next(0, 9);
				int y = random.Next(0, 9);
				if (Grid[x, y].hasBomb == false)
				{
					Grid[x, y].hasBomb = true;
					bombCount++;
                }

			}
		}
		// Rerender board when there are new coordinates
		// Display 


        // cooordinates hasBomb is set to true then

		// while loop (for cooordinates entry)
		// .hasBomb true if not break out of loop


		// print updated board (revealed/not a revealed square)

		// Counting bombs around the neighbours

		// Check cell, are there any bombs around it ?
			
			



			


			// Looping through entire grid //
		//	for (int i = 0; i < Size; i++)
		//	{
		//		for (int j = 0; j < Size; j++)
		//		{

		//		}
		//	}

		//}

		// Calculate how many neighbors are live / bombs
		public void CalcLiveNeighbors()
		{
			for (int i = 0; i < Size; i++)
			{
				for (int j = 0; j < Size; j++)
				{

					// NW of current square
					if (i - 1 >= 0 && j - 1 >= 0 && Grid[i - 1, j - 1].hasBomb) Grid[i, j].LiveNeighbors++;

					// N
					if (i - 1 >= 0 && Grid[i - 1, j].hasBomb) Grid[i, j].LiveNeighbors++;


					// NE
					if (i - 1 >= 0 && j + 1 < Size && Grid[i - 1, j + 1].hasBomb) Grid[i, j].LiveNeighbors++;

					// W
					if (j - 1 >= 0 && Grid[i, j - 1].hasBomb) Grid[i, j].LiveNeighbors++;

					// E
					if (j + 1 < Size && Grid[i, j + 1].hasBomb) Grid[i, j].LiveNeighbors++;

					// SW
					if (i + 1 < Size && j - 1 >= 0 && Grid[i + 1, j - 1].hasBomb) Grid[i, j].LiveNeighbors++;

					// S
					if (i + 1 < Size && Grid[i + 1, j].hasBomb) Grid[i, j].LiveNeighbors++;

					// SE
					if (i + 1 < Size && j + 1 < Size && Grid[i + 1, j + 1].hasBomb) Grid[i, j].LiveNeighbors++;

				}
			}
		}

		// Display to user
		//  . * what user has already clicked on

		// Shows 1 or 2 to show adjacent squares that have mines 


		// If game is lost
		internal bool checkIfLost()
		{
			bool lost = false;
			// Row
			for (int i = 0; i < Size; i++)
			{
				// Column
				for (int j = 0; j < Size; j++)
				{
					if (Grid[i, j].IsLive && Grid[i, j].IsVisited)
					{
						lost = true;
					}
				}
			}
			return lost;
		}

		// If game is won

		internal bool checkIfWon()
		{
			bool won = true;
			// Row
			for (int i = 0; i < Size; i++)
			{
				// Column
				for (int j = 0; j < Size; j++)
				{
					if (Grid[i, j].IsVisited == false && Grid[i, j].IsLive == false)
					{
						// If a cell is not visited and does not have a bomb			then the game continues.
						won = false;
					}
					if (Grid[i, j].IsLive == true && Grid[i, j].IsFlagged == false)
					{
						// If a cell is not visited and does not have a bomb			then the game continues.
						won = false;
					}
				}
				if (!won);
			}
			return won;
		}
	}
}

