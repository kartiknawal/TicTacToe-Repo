using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public void UC1_CreateBoard()
        {
            char[] board = new char[10];
            int i;
            for (i = 1; i <= 9; i++)
            {
                board[i] = ' ';

            }
        }
    }
}