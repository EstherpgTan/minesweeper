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

        public static Cell[,] Grid { get; private set; }

        static void Main(string[] args)
        {
            // 10 x 10 board, set up for bombs
            int boardSize = 0;
            Board myBoard = new Board(10);

            myBoard.setupBombs();
            myBoard.CalcLiveNeighbors();
            printBoard(myBoard);
        }

//        Boolean gameLost = false;
//        Boolean gameWon = false;
//        while (gameLost == false && gameWon === false)
//        {

//        currentBoard(myBoard);
//        gameLost = myBoard.checkIfLost();
//        gameWon = myBoard.checkIfWon();

//        //If a game is lost or won
//        if (gameLost)
//        {
//            Console.WriteLine("Boom!");
//        }
//        if (gameWon)
//        {
//            Console.WriteLine("You won!");
//        }
//        printBoard(myBoard);
//        }
//        Console.ReadLine();
//}



//Cell currentCell = setCurrentCell();
//printBoard(myBoard);

//private static Cell SetCurrentCell()
//{
//}

// Save integer to a row & column
//    {
//    Console.WriteLine("Enter the current row number");
//    int currentRow = int.Parse(Console.ReadLine());
//    Console.WriteLine("Enter the current column number");
//    int currentColumn = int.Parse(Console.ReadLine());
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


            //Ask the user for an X and Y coordinate where a cell will be selected
            //Cell currentCell = setCurrentCell();
            //printBoard(myBoard);

            // Get X and Y coordinates from user and return a cell location
            //private static Cell SetCurrentCell()
            //{
            //}

            //// Save integer to a row & column
            //Console.WriteLine("Enter the current row number");
            //int currentRow = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the current column number");
            //int currentColumn = int.Parse(Console.ReadLine());

            //myBoard.Grid[currentRow,currentColumn].CurrentlyOccupied = true;
            //return myBoard.Grid[currentRow, currentColumn];

        }
    }
}

        


   
            
        
    


