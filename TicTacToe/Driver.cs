using System;

namespace TicTacToe
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            char [] BoardArrayParameter = new char[9];

            for (int i = 1; i <= BoardArrayParameter.Length; i++)
            {
                BoardArrayParameter[i] = (char)(i + '0');
            }

            //Board bd = new Board(BoardArrayParameter);

            //bd.displayBoard();

            //Console.WriteLine('Player 1: Where would you like to go?');
        }
    }
}
