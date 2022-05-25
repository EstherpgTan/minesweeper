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

			List<int> possibleValues = new List<int>();
			possibleValues.AddRange(1,3);
			possibleValues.AddRange(2, 5);
			possibleValues.AddRange(3, 8);
			possibleValues.AddRange(4, 3);
			possibleValues.AddRange(5, 10);
			possibleValues.AddRange(6, 4);
			possibleValues.AddRange(7, 7);
			possibleValues.AddRange(8, 6);
			possibleValues.AddRange(9, 5);
			possibleValues.AddRange(10, 2);

			for (int i = 0; i < 100; i++)
			{
				possibleValues[i] = i;
			}

			List<int> result = new List<int>();

			Random r = new Random();
			int numberOfBombs = 10;

			for (int i = 0; i < numberOfBombs; i++)
			{
				int indice = r.Next(possibleValues.Count);
				int value = possibleValues[indice];

				possibleValues.Remove(value);
				result.Add(value);
			}

			// 2 dimensional array
			//int[,] bombs = new int[,] { { 1, 1 },{ 1, 2 },{ 1, 3 } };
			// Empty array
			// Generating number between 1-10
			// Check if array already has number
			// Don't repeat same coordinates
			// check if numbers exist in my array of coordinates


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
					if (i - 1 >= 0 && Grid[i - 1, j].IsLive) Grid[i, j].LiveNeighbors++;


					// NE
					if (i - 1 >= 0 && j + 1 < Size && Grid[i - 1, j + 1].IsLive) Grid[i, j].LiveNeighbors++;

					// W
					if (j - 1 >= 0 && Grid[i, j - 1].IsLive) Grid[i, j].LiveNeighbors++;

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

