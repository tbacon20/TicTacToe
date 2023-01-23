using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        int turnCount = 0;
        //public Board(string[] boardarray)
        //{
        //}

        public void displayBoard(char[] currentBoard)
        {
            
            // This Creates the Board and loads the values from the array into the board
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}    |  {1}  |  {2}  ", currentBoard[0], currentBoard[1], currentBoard[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}    |  {1}  |  {2}  ", currentBoard[3], currentBoard[4], currentBoard[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}    |  {1}  |  {2}  ", currentBoard[6], currentBoard[7], currentBoard[8]);
            Console.WriteLine("     |     |    ");

        }

        public string winnerDetermination(char[] currentBoard)
        {
            string winMsg = "";
            // Horizontal Winning Combinations
            if ((currentBoard[0] == currentBoard[1]) && (currentBoard[1] == currentBoard[2]))
            {
                if (currentBoard[0] == 'X')
                {
                    winMsg = "Player 1 wins!";
                }
                else
                {
                    winMsg = "Player 2 wins!";
                }
            }
            else if ((currentBoard[3] == currentBoard[4]) && (currentBoard[4] == currentBoard[5]))
            {
                if (currentBoard[3] == 'X')
                {
                    winMsg = "Player 1 wins!";
                }
                else
                {
                    winMsg = "Player 2 wins!";
                }
            }
            else if ((currentBoard[6] == currentBoard[7]) && (currentBoard[7] == currentBoard[8]))
            {
                if (currentBoard[6] == 'X')
                {
                    winMsg = "Player 1 wins!";
                }
                else
                {
                    winMsg = "Player 2 wins!";
                }
            }

            //Vertical Winning Combinations
            if ((currentBoard[0] == currentBoard[3]) && (currentBoard[3] == currentBoard[6]))
            {
                if (currentBoard[0] == 'X')
                {
                    winMsg = "Player 1 wins!";
                }
                else
                {
                    winMsg = "Player 2 wins!";
                }
            }
            else if ((currentBoard[1] == currentBoard[4]) && (currentBoard[4] == currentBoard[7]))
            {
                if (currentBoard[1] == 'X')
                {
                    winMsg = "Player 1 wins!";
                }
                else
                {
                    winMsg = "Player 2 wins!";
                }
            }
            else if ((currentBoard[2] == currentBoard[5]) && (currentBoard[5] == currentBoard[8]))
            {
                if (currentBoard[2] == 'X')
                {
                    winMsg = "Player 1 wins!";
                }
                else
                {
                    winMsg = "Player 2 wins!";
                }
            }

            //Diagonal Winning Combinations
            if ((currentBoard[2] == currentBoard[4]) && (currentBoard[4] == currentBoard[6]))
            {
                if (currentBoard[2] == 'X')
                {
                    winMsg = "Player 1 wins!";
                }
                else
                {
                    winMsg = "Player 2 wins!";
                }
            }
            else if ((currentBoard[0] == currentBoard[4]) && (currentBoard[4] == currentBoard[8]))
            {
                if (currentBoard[0] == 'X')
                {
                    winMsg = "Player 1 wins!";
                }
                else
                {
                    winMsg = "Player 2 wins!";
                }
            }
            else
            {
                if (turnCount == 9)
                {
                    winMsg = "It's a Draw";
                }
                else
                {
                    winMsg = "Next Turn";
                }
                turnCount++;
            }


            return winMsg;
        }
    }
}
