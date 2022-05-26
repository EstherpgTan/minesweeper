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
            Boolean guess = false;
            Board myBoard = new Board(10);

            myBoard.setupBombs();
            myBoard.CalcLiveNeighbors();
            printBoard(myBoard);
            bombs(myBoard, guess);
        }

       
        private static void bombs(Board myBoard,Boolean guess)
        {
            while (guess == false)
            {
                Console.WriteLine("Select a Row number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Select a Column number:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine(myBoard.Grid[x, y].hasBomb);
                if (myBoard.Grid[x, y].hasBomb == false)
                {
                    Console.WriteLine("Have another guess!");
                    myBoard.Grid[x, y].IsVisited = true;
                    printBoard(myBoard);

                }
                else
                { 
                //if (myBoard.Grid[x, y].hasBomb) ;
                //{
                    Console.WriteLine("Bomb!");
                   guess = true;
                }
                
            }
           
        }

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
                    if (!myBoard.Grid[i,j].IsVisited)
                    {
                        Console.Write("| . ");
                    }
                    else
                    if(myBoard.Grid[i, j].IsLive && !myBoard.Grid[i, j].hasBomb)
                    {
                        Console.Write("| * ");
                    }
                    else if (!myBoard.Grid[i, j].hasBomb)
                    {
                        Console.Write("| " + myBoard.Grid[i, j].LiveNeighbors + " ");
                    }
                    else
                    {
                        Console.Write("| b ");
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

        


   
            
        
    


