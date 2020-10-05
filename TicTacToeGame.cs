using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        char[] board = new char[10];
        public void CreateBoard()
        {

            int i;
            for (i = 1; i <= 9; i++)
            {
                board[i] = ' ';

            }
        }

        public char ChooseLetter()
        {
            Console.WriteLine("Choose between X or O : ");
            char letter = Convert.ToChar(Console.ReadLine());
            return letter;
        }

        public void showBoard()
        {
            Console.WriteLine("The Board: ");
            for (int i = 1; i < board.Length; i++)
            {
                if (i == 1 || i == 4 || i == 7)
                {
                    Console.WriteLine("\n");
                }
                Console.Write(board[i] + " | ");

            }
        }
    }
}