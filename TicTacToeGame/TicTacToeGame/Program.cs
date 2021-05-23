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