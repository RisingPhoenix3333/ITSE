using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictac
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
        }

        public static void PlaceMark(int row, int column)
        {
            board[row][column] = playerTurn;

            changeturn();

            // your code goes here
        }
        public static void changeturn()
        {
            if (playerTurn == "x")
            {
                playerTurn = "o";
            }
            else
            {
                playerTurn = "x";
            }
                
        }

        public static bool CheckForWin()
        {
            // your code goes here

            return false;
        }

        public static bool CheckForTie()
        {
            // your code goes here

            return false;
        }

        public static bool HorizontalWin()
        {
            if (board[0][0] == board[0][1] || board[0][1] == board[0][2])
            // your code goes here

            return false;
        }

        public static bool VerticalWin()
        {
            // your code goes here

            return false;
        }

        public static bool DiagonalWin()
        {
            // your code goes here

            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
    }
}
 