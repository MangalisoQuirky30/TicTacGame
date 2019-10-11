using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }


        public void Run()
        {
            char[] plyrXPos = new char[] {' ' , ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
            char[] plyrOPos = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };


            for (int plays = 0; plays < 10; plays++)
            {
                if (plays == 0 || plays % 2 != 0)
                {
                    // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
                    Console.SetCursorPosition(2, 19);
                    Console.Write("Player X");

                    Console.SetCursorPosition(2, 20);
                    Console.Write("Please Enter Row: ");
                    var row = int.Parse(Console.ReadLine());

                    Console.SetCursorPosition(2, 22);
                    Console.Write("Please Enter Column: ");
                    var column = int.Parse(Console.ReadLine());

                    // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)

                    for (int i = 0; i < plyrXPos.Length; i++)
                    {
                        if (plyrOPos[i] == ' ' && plyrXPos[i] == ' ')
                        {
                            _boardRenderer.AddMove(row, column, PlayerEnum.X, true);
                        }
                    }



                    if (row == 0 && column == 0)
                    {
                        plyrXPos[0] = 'x';
                    }
                    if (row == 0 && column == 1)
                    {
                        plyrXPos[1] = 'x';
                    }
                    if (row == 0 && column == 2)
                    {
                        plyrXPos[2] = 'x';
                    }
                    if (row == 1 && column == 0)
                    {
                        plyrXPos[3] = 'x';
                    }
                    if (row == 1 && column == 1)
                    {
                        plyrXPos[4] = 'x';
                    }
                    if (row == 1 && column == 2)
                    {
                        plyrXPos[5] = 'x';
                    }
                    if (row == 2 && column == 0)
                    {
                        plyrXPos[6] = 'x';
                    }
                    if (row == 2 && column == 1)
                    {
                        plyrXPos[7] = 'x';
                    }
                    if (row == 2 && column == 2)
                    {
                        plyrXPos[8] = 'x';
                    }

                    if(plyrXPos[0] == 'x' && plyrXPos[1] == 'x' && plyrXPos[2] == 'x' )
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER x WON!!!!!");
                        break;
                    }
                    if (plyrXPos[3] == 'x' && plyrXPos[4] == 'x' && plyrXPos[5] == 'x')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER x WON!!!!!");
                        break;
                    }
                    if (plyrXPos[6] == 'x' && plyrXPos[7] == 'x' && plyrXPos[8] == 'x')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER x WON!!!!!");
                        break;
                    }

                    if (plyrXPos[0] == 'x' && plyrXPos[3] == 'x' && plyrXPos[6] == 'x')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER x WON!!!!!");
                        break;
                    }
                    if (plyrXPos[1] == 'x' && plyrXPos[4] == 'x' && plyrXPos[7] == 'x')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER x WON!!!!!");
                        break;
                    }
                    if (plyrXPos[2] == 'x' && plyrXPos[5] == 'x' && plyrXPos[8] == 'x')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER x WON!!!!!");
                        break;
                    }

                    if (plyrXPos[0] == 'x' && plyrXPos[4] == 'x' && plyrXPos[8] == 'x')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER x WON!!!!!");
                        break;
                    }
                    if (plyrXPos[2] == 'x' && plyrXPos[4] == 'x' && plyrXPos[6] == 'x')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER x WON!!!!!");
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                }


                if (plays % 2 == 0)
                {
                    // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
                    Console.SetCursorPosition(35, 19);
                    Console.Write("Player O");

                    Console.SetCursorPosition(35, 20);
                    Console.Write("Please Enter Row: ");
                    var row = int.Parse(Console.ReadLine());

                    Console.SetCursorPosition(35, 22);
                    Console.Write("Please Enter Column: ");
                    var column = int.Parse(Console.ReadLine());

                    // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)

                    for (int i = 0; i < plyrXPos.Length; i++)
                    {
                        if (plyrOPos[i] == ' ' && plyrXPos[i] == ' ')
                        {
                            _boardRenderer.AddMove(row, column, PlayerEnum.O, true);
                        }
                    }

                    if (row == 0 && column == 0)
                    {
                        plyrOPos[0] = 'O';
                    }
                    if (row == 0 && column == 1)
                    {
                        plyrOPos[1] = 'O';
                    }
                    if (row == 0 && column == 2)
                    {
                        plyrOPos[2] = 'O';
                    }
                    if (row == 1 && column == 0)
                    {
                        plyrOPos[3] = 'O';
                    }
                    if (row == 1 && column == 1)
                    {
                        plyrOPos[4] = 'O';
                    }
                    if (row == 1 && column == 2)
                    {
                        plyrOPos[5] = 'O';
                    }
                    if (row == 2 && column == 0)
                    {
                        plyrOPos[6] = 'O';
                    }
                    if (row == 2 && column == 1)
                    {
                        plyrOPos[7] = 'O';
                    }
                    if (row == 2 && column == 2)
                    {
                        plyrOPos[8] = 'O';
                    }


                    if (plyrOPos[0] == 'O' && plyrOPos[1] == 'O' && plyrOPos[2] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER O WON!!!!!");
                        break;
                    }
                    if (plyrOPos[3] == 'O' && plyrOPos[4] == 'O' && plyrOPos[5] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER O WON!!!!!");
                        break;
                    }
                    if (plyrOPos[6] == 'O' && plyrOPos[7] == 'O' && plyrOPos[8] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER O WON!!!!!");
                        break;
                    }

                    if (plyrOPos[0] == 'O' && plyrOPos[3] == 'O' && plyrOPos[6] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER O WON!!!!!");
                        break;
                    }
                    if (plyrOPos[1] == 'O' && plyrOPos[4] == 'O' && plyrOPos[7] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER O WON!!!!!");
                        break;
                    }
                    if (plyrOPos[2] == 'O' && plyrOPos[5] == 'O' && plyrOPos[8] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER O WON!!!!!");
                        break;
                    }

                    if (plyrOPos[0] == 'O' && plyrOPos[4] == 'O' && plyrOPos[8] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER O WON!!!!!");
                        break;
                    }
                    if (plyrOPos[2] == 'O' && plyrOPos[4] == 'O' && plyrOPos[6] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("PLAYER O WON!!!!!");
                        break;
                    }


                    
                }
            }
        }

    }
}
