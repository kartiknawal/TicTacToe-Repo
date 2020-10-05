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
        public void PlayerMove(char letter)
        {
            Console.WriteLine("Enter any index location from 1 to 9");

            int position = Convert.ToInt32(Console.ReadLine());
            if (board[position] == ' ')
            {
                board[position] = letter;
            }
            else
            {
                Console.WriteLine("Location already filled");
                PlayerMove(letter);
            }
        }




    }
}

