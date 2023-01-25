using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        //Initiate a turn count variable so when the board fills up you can call a draw
        int turnCount = 0;

        //Method to display the tictactoe board, doesn't return a variable, just returns board
        public void displayBoard(char[] currentBoard)
        {
            
            // This Creates the Board and loads the values from the array into the board
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", currentBoard[0], currentBoard[1], currentBoard[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", currentBoard[3], currentBoard[4], currentBoard[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", currentBoard[6], currentBoard[7], currentBoard[8]);
            Console.WriteLine("     |     |    ");

        }


        /*
        //Method to determine if there is a winner is based off of the current board from the last selection
        public string winnerDetermination(char[] currentBoard)
        {
            // variable to hold the message that will say if there was a winner of if its someone's turn
            string winMsg = "";

            // Horizontal Winning Combinations
            //increment the turn count
            turnCount++;

            //if the board is full call it a draw
            if (turnCount == 9)
            {
                winMsg = "It's a Draw";
                return winMsg;
            }

            // if the game is won horizontally, see which player wins, and return that message
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
            //If a player wins vertically display which player wins
            else if ((currentBoard[0] == currentBoard[3]) && (currentBoard[3] == currentBoard[6]))
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
            //check If a player wins diagonally, display the winner
            else if ((currentBoard[2] == currentBoard[4]) && (currentBoard[4] == currentBoard[6]))
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
            // if there were no winners, just display next turn
            else
            {
                winMsg = "Next Turn";
            }

            //return the winning message
            return winMsg;
        }

        */

        //Method to determine if there is a winner is based off of the current board from the last selection
        public string winnerDetermination(char[] currentBoard)
        {
            // variable to hold the message that will say if there was a winner of if its someone's turn
            string winMsg;
            bool win;
            int i;

            // Horizontal Winning Combinations
            //increment the turn count
            turnCount++;

            //if the board is full call it a draw
            if (turnCount == 9)
            {
                winMsg = "It's a Draw";
                return winMsg;
            }

            // Check for Diagonal Wins
            i = 0;
            win = CheckWin(currentBoard, 0, 4);
            if (!win)
            {
                win = CheckWin(currentBoard, 3, 2);
            }
            winMsg = WinMsg(currentBoard, i);

            // Check for horizontal wins
            i = 0;
            while (!win && i < 9)
            {
                win = CheckWin(currentBoard, i, 1);
                winMsg = WinMsg(currentBoard, i);
                i = i + 3;
            }

            // Check for vertical wins
            i = 0;
            while (!win && i < 4)
            {
                win = CheckWin(currentBoard, i, 3);
                winMsg = WinMsg(currentBoard, i);
                i++;
            }

            //return the winning message
            if (win) return winMsg;
            else return "Next Turn";
        }

        private bool CheckWin(char[] board, int start, int iterator)
        {
            bool win = false;

            if ((board[start] == board[start + iterator]) && (board[start + iterator] == board[start + (iterator * 2)]))
                win = true;

            return win;
        }

        private string WinMsg(char[] board, int winSpace)
        {
            string winMsg;

            if (board[winSpace] == 'X')
            {
                winMsg = "Player 1 wins!";
            }
            else
            {
                winMsg = "Player 2 wins!";
            }

            return winMsg;
        }
    }
}
