using System;
using System.Collections.Generic;
using System.Text;

namespace TTT
{
    /// <summary>
    ///         2-player Tic Tac Toe, written as a simple console app in C#
    /// </summary>
    /// <remarks>
    /// Coded in about 30 minutes while waiting for beginner programmer friend to finish
    ///     Week 1 video lectures in an online intro to game programming class:
    ///     https://www.coursera.org/course/gameprogramming
    ///
    /// Input is simply numbers 1-9 to choose where you want to mark the X or O, and can
    ///     be visualized as the numbers on a numpad.
    /// Author: JK (Aahz)
    /// License: None! use freely, experiment, enjoy :)
    /// 
    /// Source: http://pastebin.com/8Tqyi2Zr
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a game!
            TicTacToe game = new TicTacToe();
            bool done = false;
            String input = "";

            while (!done)
            {
                // Draw the board
                game.DrawGameBoard();

                Console.Write("\n> ");
                // Read the input!
                input = Console.ReadLine();

                // Parse input, check for things
                switch (input)
                {
                    case "q":
                    case "quit":
                        done = true;
                        break;
                    default:
                        // Not quitting, so let's see if the game can use this input
                        game.TryInput(input);
                        break;
                }
                // Refresh console, will redraw the next loop, if there is a next loop
                Console.Clear();
            }
        }
    }
    
}