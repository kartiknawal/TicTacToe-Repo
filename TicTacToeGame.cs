using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public void CreateBoard()
        {
            char[] board = new char[10];
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
    }
}


