using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
	public class Cell
	{
		public int RowNumber { get; set; }
		public int ColumnNumber { get; set; }
		public int LiveNeighbors { get; set; }
		public bool IsVisited { get; set; }
		public bool IsFlagged { get; set; }
		public bool IsLive { get; set; }
        public bool hasBomb { get; set; }


        //public Cell(int x, int y)
        public Cell()
		{
			//RowNumber = x;
			//ColumnNumber = y;
			this.RowNumber = -1;
			this.ColumnNumber = -1;
			this.LiveNeighbors = 0;
			this.IsVisited = false;
			this.IsFlagged = false;
			this.hasBomb = false;
		}

		public Cell(int i, int j)
		{
			RowNumber = i;
			ColumnNumber = j;
			LiveNeighbors = 0;
			IsVisited = false;
			IsFlagged = false;
			//IsLive = false;
			hasBomb = false;
		}
	}
}


