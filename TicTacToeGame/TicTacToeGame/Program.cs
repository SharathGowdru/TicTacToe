using System;

namespace TicTacToeGame
{
    class Program
    {
        public static void CreateEmptyBoard()
        {
            Char[] board = new char[10];
            for(int i=0; i < 10 ; i++)
            {
                board[i] = ' ';
            }
            Console.WriteLine(" {0}  |  {1}   |  {2} ", board[1], board[2], board[3]);
            Console.WriteLine("____|______|____");
            Console.WriteLine("    |      |    ");
            Console.WriteLine(" {0}  |  {1}   |   {2}  ", board[4], board[5], board[6]);
            Console.WriteLine("____|______|____");
            Console.WriteLine("    |      |    ");
            Console.WriteLine(" {0}  |  {1}   |   {2}  ", board[7], board[8], board[9]);
           
        }
        public static void ChooseLetter()
        {
            string computerChoice;
            Console.WriteLine("Please enter your X/O : ");
            string userChoice = Console.ReadLine();
            while(true)
            {
                if( userChoice == "X" || userChoice == "x" )
                {
                    Console.WriteLine("computerChoice = O ");
                    break;
                }
                else if(userChoice == "O" || userChoice == "o")
                {
                    Console.WriteLine("computerChoice = X ");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, Please try again");
                }


            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe GAME in C#");
            CreateEmptyBoard();
            ChooseLetter();
        }
    }
}