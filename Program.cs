using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    class Program
    {
        // 10 x 10 board
        static Board myBoard = new Board(10);

        static void Main(string[] args)
        {

            // Shows the Grid board
            printBoard(myBoard);




        // 10 Mines randomly generated
        //https://docs.microsoft.com/en-us/dotnet/api/system.random?view=net-6.0

            // How is the grid set up.
            // Select a random number that fits inside the grid.
            // Generates 10 random lines. Generate 1 random line.
            // A number for x & y twice to get the coordinates.

            // "Enter a row number"
            // "Enter a column number"


            // User clicks a square to check a location for a mine
            // Shows 1 or 2 to show adjacent squares that have mines (Can be a number)
            // 
            


            // Display board for mines surrounding location (Not a requirement)
            // 



            // If a mine is selected game is lost, "Boom !"
            // Press home button to start a new game





            // If every non-mine square has been revealed, the game is won, "You have won" 






        }

        // Prints the grid board to the console.
        private static void printBoard(Board myBoard)
        {
            // Row
            for(int i = 0; i < myBoard.Size; i++)
            {
                // Column
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    Console.WriteLine("    1   2   3   4   5   6   7   8   9   10 ");
                    Console.WriteLine("+=====+===+===+===+===+===+===+===+===+===+");
                    Console.WriteLine("1 |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("2 |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("3 |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("4 |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("5 |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("6 |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("7 |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("8 |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("9 |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("10|   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("  |   |   |   |   |   |   |   |   |   |   |");
                    Console.WriteLine("+=====+===+===+===+===+===+===+===+===+===+");
                }
            }
        }
    }
}

