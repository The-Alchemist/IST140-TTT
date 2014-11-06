using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    class TicTacToe
    {
        String[] slot;
        bool turn; // True = O's turn, False = X's turn
        ConsoleColor borderColor;
        ConsoleColor gridColor;
        String statusMessage;
        String winner;

        public TicTacToe()
        {
            InitGame();
        }
        private void InitGame()
        {
            slot = new String[] { "7", "8", "9",
                                  "4", "5", "6",
                                  "1", "2", "3" };
            turn = false;
            borderColor = ConsoleColor.DarkGreen;
            gridColor = ConsoleColor.DarkYellow;
            statusMessage = "";
            winner = "";
        }
        public void DrawGameBoard()
        {
            Console.WriteLine("Input a number (1-9) to mark your spot. ('q' to quit)\n");

            Console.ForegroundColor = borderColor;
            Console.WriteLine("**************************");
            Console.WriteLine("*                        *");
            Console.WriteLine("*                        *");
            // Top Line
            Console.Write("*\t ");
            // Top Left slot
            DecideSlotColor(slot[0]);
            Console.Write(slot[0]);
            Console.ForegroundColor = gridColor;
            Console.Write(" | ");
            // Top Middle slot
            DecideSlotColor(slot[1]);
            Console.Write(slot[1]);
            Console.ForegroundColor = gridColor;
            Console.Write(" | ");
            // Top Right slot
            DecideSlotColor(slot[2]);
            Console.Write(slot[2]);
            Console.ForegroundColor = borderColor;
            Console.Write("\t *\n");
            Console.Write("*\t");
            Console.ForegroundColor = gridColor;
            Console.Write("---|---|---");
            Console.ForegroundColor = borderColor;
            Console.Write("\t *\n");
            // Middle Line
            Console.Write("*\t ");
            // Middle Left slot
            DecideSlotColor(slot[3]);
            Console.Write(slot[3]);
            Console.ForegroundColor = gridColor;
            Console.Write(" | ");
            // Middle Middle slot
            DecideSlotColor(slot[4]);
            Console.Write(slot[4]);
            Console.ForegroundColor = gridColor;
            Console.Write(" | ");
            // Middle Right slot
            DecideSlotColor(slot[5]);
            Console.Write(slot[5]);
            Console.ForegroundColor = borderColor;
            Console.Write("\t *\n");
            Console.Write("*\t");
            Console.ForegroundColor = gridColor;
            Console.Write("---|---|---");
            Console.ForegroundColor = borderColor;
            Console.Write("\t *\n");
            // Bottom Line
            Console.Write("*\t ");
            // Bottom Left slot
            DecideSlotColor(slot[6]);
            Console.Write(slot[6]);
            Console.ForegroundColor = gridColor;
            Console.Write(" | ");
            // Bottom Middle slot
            DecideSlotColor(slot[7]);
            Console.Write(slot[7]);
            Console.ForegroundColor = gridColor;
            Console.Write(" | ");
            // Bottom Right slot
            DecideSlotColor(slot[8]);
            Console.Write(slot[8]);
            Console.ForegroundColor = borderColor;
            Console.Write("\t *\n");
            // Back to border
            Console.WriteLine("*                        *");
            Console.WriteLine("*                        *");
            Console.WriteLine("**************************\n");

            Console.ResetColor();
            Console.WriteLine(statusMessage + "\n");
            Console.WriteLine("Currently " + (turn ? "O" : "X") + "'s turn.");
            statusMessage = "";
        }
        public void DecideSlotColor(String slot)
        {
            switch (slot)
            {
                case "O":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "X":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case " ":
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
        }
        public void TryInput(String input)
        {

            // Top row, 7 8 9
            if (input.Equals("7"))
            {
                if (IsSlotBlank(0))
                {
                    slot[0] = (turn ? "O" : "X");
                    turn = !turn;
                    CheckEndGame();
                }
                else
                    statusMessage = "Slot already taken!";
            }
            else if (input.Equals("8"))
            {
                if (IsSlotBlank(1))
                {
                    slot[1] = (turn ? "O" : "X");
                    turn = !turn;
                    CheckEndGame();
                }
                else
                    statusMessage = "Slot already taken!";
            }
            else if (input.Equals("9"))
            {
                if (IsSlotBlank(2))
                {
                    slot[2] = (turn ? "O" : "X");
                    turn = !turn;
                    CheckEndGame();
                }
                else
                    statusMessage = "Slot already taken!";
            }
            // Middle row, 4 5 6
            else if (input.Equals("4"))
            {
                if (IsSlotBlank(3))
                {
                    slot[3] = (turn ? "O" : "X");
                    turn = !turn;
                    CheckEndGame();
                }
                else
                    statusMessage = "Slot already taken!";
            }
            else if (input.Equals("5"))
            {
                if (IsSlotBlank(4))
                {
                    slot[4] = (turn ? "O" : "X");
                    turn = !turn;
                    CheckEndGame();
                }
                else
                    statusMessage = "Slot already taken!";
            }
            else if (input.Equals("6"))
            {
                if (IsSlotBlank(5))
                {
                    slot[5] = (turn ? "O" : "X");
                    turn = !turn;
                    CheckEndGame();
                }
                else
                    statusMessage = "Slot already taken!";
            }
            // Bottom row, 1 2 3
            else if (input.Equals("1"))
            {
                if (IsSlotBlank(6))
                {
                    slot[6] = (turn ? "O" : "X");
                    turn = !turn;
                    CheckEndGame();
                }
                else
                    statusMessage = "Slot already taken!";
            }
            else if (input.Equals("2"))
            {
                if (IsSlotBlank(7))
                {
                    slot[7] = (turn ? "O" : "X");
                    turn = !turn;
                    CheckEndGame();
                }
                else
                    statusMessage = "Slot already taken!";
            }
            else if (input.Equals("3"))
            {
                if (IsSlotBlank(8))
                {
                    slot[8] = (turn ? "O" : "X");
                    turn = !turn;
                    CheckEndGame();
                }
                else
                    statusMessage = "Slot already taken!";
            }
            else
            {
                statusMessage = "Invalid Input!";
            }
        }

        private bool IsSlotBlank(int input)
        {
            return slot[input] != "O" && slot[input] != "X";
        }
        private void CheckEndGame()
        {
            bool win = false;
            // Only 8 cases
            // Top row, 0 1 2
            if (slot[0] == slot[1] && slot[1] == slot[2])
            {
                win = true;
                winner = slot[0];
            }
            // Middle row, 3 4 5
            if (slot[3] == slot[4] && slot[4] == slot[5])
            {
                win = true;
                winner = slot[3];
            }
            // Bottom row, 6 7 8
            if (slot[6] == slot[7] && slot[7] == slot[8])
            {
                win = true;
                winner = slot[6];
            }
            // Left column, 0 3 6
            if (slot[0] == slot[3] && slot[3] == slot[6])
            {
                win = true;
                winner = slot[0];
            }
            // Middle column, 1 4 7
            if (slot[1] == slot[4] && slot[4] == slot[7])
            {
                win = true;
                winner = slot[1];
            }
            // Right column, 2 5 8
            if (slot[2] == slot[5] && slot[5] == slot[8])
            {
                win = true;
                winner = slot[2];
            }
            // Forward slash shape  /, 6 4 2
            if (slot[6] == slot[4] && slot[4] == slot[2])
            {
                win = true;
                winner = slot[6];
            }
            // Backword slash shape \, 0 4 8
            if (slot[0] == slot[4] && slot[4] == slot[8])
            {
                win = true;
                winner = slot[0];
            }

            // Did somebody win?
            if (win)
            {
                DisplayWinCongrats();
            }
            // Check for draw
            bool openSlotCheck = CheckDraw();
            // If no empty slots and no win, we have a draw :(
            if (!openSlotCheck)
            {
                Console.WriteLine("Uhoh, we have a draw! Good game, try again :)");
                Console.ReadKey();
                InitGame();
            }

        }

        private bool CheckDraw()
        {
            bool openSlotCheck = false;
            foreach (String s in slot)
            {
                // Is there still an open slot that isn't an X or O?
                if (!s.Equals("X") && !s.Equals("O"))
                {
                    openSlotCheck = true;
                    break;
                }
            }
            return openSlotCheck;
        }
        private void DisplayWinCongrats()
        {
            Random r = new Random();
            DateTime endScrollTime = DateTime.Now.AddSeconds(3);
            // Scroll wild colors for 3 seconds
            while (DateTime.Now < endScrollTime)
            {

                Console.ForegroundColor = (ConsoleColor)r.Next(1, 16);
                Console.Write("****************************************************************************\n");
            }
            Console.ResetColor();
            Console.WriteLine("\n" + winner + " has won the game! Woo!");
            Console.ReadKey();
            InitGame();
        }
    }
}
