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
            int x = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(board[x] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}


