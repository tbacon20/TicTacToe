using System;
using System.Collections;
using System.Collections.Generic;

namespace TicTacToe
{
    class Driver
    {
        static void Main()
        {
            // Display welcome message
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            // Create the board array
            char [] BoardArrayParameter = new char[9];

            // For loop that puts each number from 1 to 9 into the array as a character
            int j = 0;
            for (int i = 0; i < BoardArrayParameter.Length; i++)
            {
                j = i + 1;
                BoardArrayParameter[i] = (char)(j + '0');
               
            }

            // Create instance of the Board class
            Board bd = new Board();

            // Check if still playihng
            bool StillPlaying = true;
            int turnCount = 0;
            char PlayerMarker;
            char PlayerNumber;
            int PlayerTurn;
            List <int> GuessList = new List <int>();

            // Loop that displays the board, prompts for the user to guess, and determines a winner. 
            while (StillPlaying)
            {
                // Call displayBoard method of the board object to display the board.
                bd.displayBoard(BoardArrayParameter);

                // Increment the turn count
                turnCount++;


                if (turnCount % 2 == 1)

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


                // Error message to handle when player guesses a non-vacant spot
                while (GuessList.Contains(PlayerTurn) || PlayerTurn > 9)
                {
                    Console.WriteLine("Please choose a vacant space to go.");
                    PlayerTurn = Convert.ToInt32(Console.ReadLine());
                }

                GuessList.Add(PlayerTurn);

                BoardArrayParameter[PlayerTurn - 1] = PlayerMarker;

                // Call the winnerDetermination method of the board object
                string GameStatus = bd.winnerDetermination(BoardArrayParameter);

                Console.WriteLine(GameStatus);

                if (GameStatus == "Next Turn")
                {
                    StillPlaying = true;
                }
                else
                {
                    // Make the game end
                    StillPlaying = false;
                }

            }

            bd.displayBoard(BoardArrayParameter);

            // Finish the game
            Console.WriteLine("Good game! Play again? (Y/N)");
            char PlayAgain = Convert.ToChar(Console.ReadLine());

            // Ask if player wants to play again
            if (PlayAgain == 'Y' || PlayAgain == 'y')
            {
                Main();
            }
        }
    }
}
