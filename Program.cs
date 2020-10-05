using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Problem");
            TicTacToeGame TicTacToe = new TicTacToeGame();
            TicTacToe.CreateBoard();
            char player_Letter = TicTacToe.ChooseLetter();
            char compuer_Letter = TicTacToe.ChooseLetter();
            TicTacToe.showBoard();
        }
    }
}
