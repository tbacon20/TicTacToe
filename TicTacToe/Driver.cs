using System;

namespace TicTacToe
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            char [] BoardArrayParameter = new char[9];

            for (int i = 0, i < BoardArrayParameter.Length, i++)
            {
                BoardArrayParameter[i] = (char)i;
            }


            Console.WriteLine(BoardArrayParameter);
            //new Board = bd(BoardArrayParameter);

            //bd.displayBoard();

            //Console.WriteLine('Player 1: Where would you like to go?');
        }
    }
}
