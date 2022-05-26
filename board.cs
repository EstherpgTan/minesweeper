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

			int bombCount = 0;
			while (bombCount <= 10)
			{
				int x = random.Next(0, 9);
				int y = random.Next(0, 9);
				if (Grid[x, y].hasBomb == false)
				{
					Grid[x, y].hasBomb = true;
					bombCount++;
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
					if (Grid[i, j].hasBomb && Grid[i, j].IsVisited)
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
					if (Grid[i, j].IsVisited == false && Grid[i, j].hasBomb == false)
					{
						// If a cell is not visited and does not have a bomb			then the game continues.
						won = false;
					}
					if (Grid[i, j].hasBomb == true && Grid[i, j].IsFlagged == false)
					{
						// If a cell is not visited and does not have a bomb then the game continues.
						won = false;
					}
				}
				if (!won) ;
			}
			return won;
		}



		// Showing user the cells they have selected
		public void cellSelected(int x, int y)
		{
			// Sets the current cell visited to true
			Grid[x, y].IsVisited = true;

			// If a current cell has a live neighbor, then  stop.
			if (Grid[x, y].LiveNeighbors > 0)

				// If a cell has been selected
				if (x - 1 >= 0 && Grid[x - 1, y].IsVisited == false)
				{
					Console.WriteLine("*");
				}

			// W
			if (y - 1 >= 0 && Grid[x, y - 1].IsVisited == false)
			{
				Console.WriteLine("*");
			}

			// E
			if (y + 1 < Size && Grid[x, y + 1].IsVisited == false)
			{
				Console.WriteLine("*");
			}

			// NW
			if (x - 1 >= 0 && y - 1 >= 0 && Grid[x - 1, y - 1].IsVisited == false)
			{
				Console.WriteLine("*");
			}

			// NE
			if (x - 1 >= 0 && y + 1 < Size && Grid[x - 1, y + 1].IsVisited == false)
			{
				Console.WriteLine("*");
			}

			// SW
			if (x + 1 < Size && y - 1 >= 0 && Grid[x + 1, y - 1].IsVisited == false)
			{
				Console.WriteLine("*");
			}

			// SE
			if (x + 1 < Size && y + 1 < Size && Grid[x + 1, y + 1].IsVisited == false && Grid[x, y].LiveNeighbors == 0)
			{
				Console.WriteLine("*");
			}
		}
	}
}




// is revealed = false
// coordinates: has bomb if not is revealed is true
// isVisited = false
// isVisited = true, print something .
// input check neighbours for that square
// If number liveneigbours is more than 0 print number in cell
// If 0 check the next cell
// Set cells to hasBeenRevealed/hasVisited = true
// Check square revealed, if 90 then user wins
// Empty board(not revealed)
// If is revealed print board with neigbours around it







