using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    class Program
    {
        public static object myBoard;

        static void Main(string[] args)
        {
            // 10 x 10 board
            int boardSize = 0;
            Board myBoard = new Board(10);

        //static void Main(string[] args)
        //{

            // Shows the Grid board
        //    printBoard(myBoard);

        //// Ask the user for an X and Y coordinate
        //Cell currentCell = setCurrentCell();
        //printBoard(myBoard);

        // Setting up Grid board for bombs
            //int boardSize = 0;
            //Board myBoard = new Board(boardSize);

            myBoard.setupBombs();
            myBoard.CalcLiveNeighbors();
            printBoard(myBoard);



            // User clicks a square to check a location for a mine
            // Shows 1 or 2 to show adjacent squares that have mines (Can be a number)
            // 



            // Display board for mines surrounding location (Not a requirement)




            // If a mine is selected game is lost, "Boom !"
            // Press home button to start a new game





            // If every non-mine square has been revealed, the game is won, "You have won" 






        }
        // Get X and Y coordinates from user and return a cell location
        //private static Cell setCurrentCell()
        //{
        //    Console.WriteLine("Enter the current row number");
        //    // Save integer to a row & column
        //    int currentRow = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter the current column number");
        //    int currentColumn = int.Parse(Console.ReadLine());

        //    //myBoard.Grid[currentRow, currentColumn];
        //    return myBoard.Grid[currentRow, currentColumn];
        //}

        // Prints the grid board to the console.
        private static void printBoard(Board myBoard)
        {
            // Row
            for (int i = 0; i < myBoard.Size; i++)
            {
                // Draws a divider +---+---+---+---+
                drawDivider(myBoard.Size);

                // Column
                for (int j = 0; j < myBoard.Size; j++)
                {

                    // for each cell, prints a *
                    if (myBoard.Grid[i, j].IsLive)
                    {
                        Console.Write("| * ");
                    }
                    else
                    {
                        Console.Write("| " + myBoard.Grid[i, j].LiveNeighbors + " ");
                    }
                }

                // add ending column divider
                Console.WriteLine("|");
            }
            drawDivider(myBoard.Size);
        }

        private static void drawDivider(int length)
        {
            // Draws this +---+---+---+---+
            for (int i = 0; i < length; i++)
            {
                Console.Write("+---");
            }
            Console.WriteLine("+");



        }
    }
}

   
            
        
    


