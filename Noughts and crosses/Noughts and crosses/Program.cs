using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noughts_and_crosses
{
    class Program
    {
        static Random rng = new Random();//Creates a random number generator 

        static string[] Board = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };//Creates the board array
        static void Main(string[] args)
        {
            Title();
            DrawBoard();
            //Name();
            while (true)
            {
                PlayerMove(0);
                DrawBoard();
                if (WinCheck(0) == 0)
                {

                }
                else if (WinCheck(1) == 1)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else if (WinCheck(2) == 2)
                {
                    Console.WriteLine("You Lose!");
                    break;
                }
                else if (WinCheck(3) == 3)
                {
                    Console.WriteLine("Draw");
                    break;

                }
                ComputerMove(0);
                DrawBoard();
                if (WinCheck(0) == 0)
                {
                    
                }
                else if (WinCheck(1) == 1)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else if (WinCheck(2) == 2)
                {
                    Console.WriteLine("You Lose!");
                    break;
                }
                else if (WinCheck(3) == 3)
                {
                    Console.WriteLine("Draw");
                    break;
                
                }
            
            }

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        static void DrawBoard()
        {
            Console.WriteLine(" {0} | {1} | {2} ", Board[0], Board[1], Board[2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", Board[3], Board[4], Board[5]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", Board[6], Board[7], Board[8]);
            Console.WriteLine("");
            //Draws the array and defines the postitions
        }

        static void Name()
        {
            Console.WriteLine("Your Name");//Prints your name
        }

        static void Print(string StrPrompt)
        {
            Console.WriteLine(StrPrompt);//Allows console.write to be written as print
        }

        static void Title()
        {
            Console.WriteLine("Welcome to noughts and crosses");
            Console.WriteLine("");
            Console.WriteLine("You will be given a prompt to select a sector");
            Console.WriteLine("You need to get three x's in a row to win");
            Console.WriteLine("and stop the computer from getting three o's in a row");
            Console.WriteLine("");
            //Displays the title and instructions of the game
        }

        static int IntAdd(int num1, int num2)
        {
            int Total = num1 + num2;//Adds two numbers together
            return Total;
        }

        static int PlayerMove(int Move)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Where do you want to move? (0 top left - 8 bottom right)");//Asks the position in the array the user wants to assign as X
                    Move = Convert.ToInt32(Console.ReadLine());
                    if (Board[Move] == " ")//Checks to see if the value in the array is empty
                    {
                        Board[Move] = "X";//Changes empty value to X
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Position taken");//The value is taken and returns to question
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Value not a int or invalid location");
                }

            }

            return Move;
        }

        static int ComputerMove(int CompMove)
        {
            while (true)
            {
                //Reused the code from PlayerMove and deleted unnecessary outputs and inputs from user
                CompMove = rng.Next(0, 8);
                try
                {
                    if (Board[CompMove] == " ")
                    {
                        Board[CompMove] = "O";
                        break;
                    }
                    else 
                    {

                    }

                }
                catch (Exception e)
                {

                }

            }

            return CompMove;
        }

        static int WinCheck(int Win)
        {
            //Yes this is super long and unoptomised and i'll do it again... maybe
            //Returns win
            if (Board[0] == "X" && Board[1] == "X" && Board[2] == "X" || Board[3] == "X" && Board[4] == "X" && Board[5] == "X" || Board[6] == "X" && Board[7] == "X" && Board[8] == "X" || Board[0] == "X" && Board[3] == "X" && Board[6] == "X" || Board[1] == "X" && Board[4] == "X" && Board[7] == "X" || Board[2] == "X" && Board[5] == "X" && Board[8] == "X" || Board[0] == "X" && Board[4] == "X" && Board[8] == "X" || Board[2] == "X" && Board[4] == "X" && Board[6] == "X")
            {
                Win = 1;
            }
            //Returns loss
            else if (Board[0] == "O" && Board[1] == "O" && Board[2] == "O" || Board[3] == "O" && Board[4] == "O" && Board[5] == "O" || Board[6] == "O" && Board[7] == "O" && Board[8] == "O" || Board[0] == "O" && Board[3] == "O" && Board[6] == "O" || Board[1] == "O" && Board[4] == "O" && Board[7] == "O" || Board[2] == "O" && Board[5] == "O" && Board[8] == "O" || Board[0] == "O" && Board[4] == "O" && Board[8] == "O" || Board[2] == "O" && Board[4] == "O" && Board[6] == "O")
            {
                Win = 2;
            }
            //Returns draw
            else if ((Board[0] == "X" || Board[0] == "O") && (Board[1] == "X" || Board[1] == "O") && (Board[2] == "X" || Board[2] == "O") && (Board[3] == "X" || Board[3] == "O") && (Board[4] == "X" || Board[4] == "O") && (Board[5] == "X" || Board[5] == "O") && (Board[6] == "X" || Board[6] == "O") && (Board[7] == "X" || Board[7] == "O") && (Board[8] == "X" || Board[8] == "O"))
            {
                Win = 3;
            }

            return Win;
        }

    }
}
