using System;
using System.Collections;
using System.Collections.Generic;

namespace TicTacToe
{
    class Driver
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            char [] BoardArrayParameter = new char[9];

            for (int i = 1; i <= BoardArrayParameter.Length; i++)
            {
              
               BoardArrayParameter[i] = (char)(i + '0');
               
            }

            Console.WriteLine(BoardArrayParameter);

            new Board = bd(BoardArrayParameter);

            bool StillPlaying = true;
            int turnCount = 0;
            char PlayerMarker;
            char PlayerNumber;
            int PlayerTurn;
            List <int> GuessList = new List <int>();

            while (StillPlaying)
            {
                bd.displayBoard();

                turnCount++;

                if (turnCount % 2 ==1)

                {
                    PlayerNumber = '1';
                    PlayerMarker = 'X';
                }
                else
                {
                    PlayerNumber = '2';
                    PlayerMarker = 'O';
                }

               

                Console.WriteLine("Player " + PlayerNumber + ": Where would you like to go?");
                PlayerTurn = Convert.ToInt32(Console.ReadLine());



                while (GuessList.Contains(PlayerTurn))
                {
                    Console.WriteLine("Please choose a vacant space to go.");
                    PlayerTurn = Convert.ToInt32(Console.ReadLine());
                }

                GuessList.Add(PlayerTurn);

                BoardArrayParameter[PlayerTurn - 1] = PlayerMarker;

                bd.displayBoard(BoardArrayParameter);

                string GameStatus = bd.determineWinner();

                Console.WriteLine(GameStatus);

                if (GameStatus == "Next Turn:")
                {
                    StillPlaying = true;
                }
                else
                {
                    StillPlaying = false;
                }

            }

            Console.WriteLine("Good game! Play again? (Y/N)");
            char PlayAgain = Convert.ToChar(Console.ReadLine());

            if (PlayAgain == 'Y')
            {
                Main();
            }




        }
    }
}
