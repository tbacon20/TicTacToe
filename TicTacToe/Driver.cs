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

            int j = 0;
            for (int i = 0; i < BoardArrayParameter.Length; i++)
            {
                j = i + 1;
                BoardArrayParameter[i] = (char)(j + '0');
               
            }

            Board bd = new Board();

            bool StillPlaying = true;
            int turnCount = 0;
            char PlayerMarker;
            char PlayerNumber;
            int PlayerTurn;
            List <int> GuessList = new List <int>();

            while (StillPlaying)
            {
                bd.displayBoard(BoardArrayParameter);

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



                while (GuessList.Contains(PlayerTurn) || PlayerTurn > 9)
                {
                    Console.WriteLine("Please choose a vacant space to go.");
                    PlayerTurn = Convert.ToInt32(Console.ReadLine());
                }

                GuessList.Add(PlayerTurn);

                BoardArrayParameter[PlayerTurn - 1] = PlayerMarker;

                string GameStatus = bd.winnerDetermination(BoardArrayParameter);

                Console.WriteLine(GameStatus);

                if (GameStatus == "Next Turn")
                {
                    StillPlaying = true;
                }
                else
                {
                    StillPlaying = false;
                }

            }

            bd.displayBoard(BoardArrayParameter);
            Console.WriteLine("Good game! Play again? (Y/N)");
            char PlayAgain = Convert.ToChar(Console.ReadLine());

            if (PlayAgain == 'Y' || PlayAgain == 'y')
            {
                Main();
            }
        }
    }
}
