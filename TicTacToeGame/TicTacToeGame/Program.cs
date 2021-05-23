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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe GAME in C#");
            CreateEmptyBoard();
        }
    }
}