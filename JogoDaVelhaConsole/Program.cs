using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JogoDaVelhaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t ~~ Bem-Vindo ao Jogo Da Velha Cosole  ~~");
            Console.WriteLine("\t\t\t ~~ Esse Jogo Foi feito como trabalho para faculdade Multivix  ~~");
            Console.WriteLine("\t\t\t ~~ Aluno: Rhuan De Souza Hianc  ~~");

            string[] board = new string[9];
            var firstPlayerName = "";
            var secondPlayerName = "";
            string[] markers = new string[2];
            var firstMarker = "";
            var secondMarker = "";
            var turn = "";
            bool gameIniciar = true;
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadLine();

            while (true)
            
            {
                if (gameIniciar)
                {
                    board = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };

                    Console.Clear();
                    Console.Write("Nome do primeiro jogador: ");
                    firstPlayerName = Console.ReadLine();

                    Console.Write("Nome do segundo jogador: ");
                    secondPlayerName = Console.ReadLine();

                    markers = new string[2];

                    Methods.fillMarkers(markers, firstPlayerName);
                    firstMarker = markers[0];
                    secondMarker = markers[1];

                    turn = Methods.firstTurn(firstPlayerName, secondPlayerName);
                    Console.WriteLine(turn + " Você vai primeiro.");
                    Console.Write("Por favor, pressione Enter... ");
                    Console.ReadLine();
                }
                else
                {

                }


                bool gameOn = true;
                while (gameOn)
                {
                    if (turn == firstPlayerName)
                    {
                        Console.Clear();
                        Methods.drawBoard(board);



                        int position = Methods.checkIntPosition(firstPlayerName);
                        Methods.placeMarker(board, firstMarker, position);

                        if (Methods.winCheck(board, firstMarker))
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t !!! Parabéns !!! " + firstPlayerName + " !!! Venceu !!!");
                            Methods.drawBoard(board);
                            gameOn = false;
                        }
                        else
                        {
                            if (Methods.fullBoardCheck(board))
                            {
                                Console.Clear();
                                Console.WriteLine("Deu empate ...");
                                Methods.drawBoard(board);
                                break;
                            }
                            else
                                turn = secondPlayerName;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Methods.drawBoard(board);

                        int position = Methods.checkIntPosition(secondPlayerName);
                        Methods.placeMarker(board, secondMarker, position);

                        if (Methods.winCheck(board, secondMarker))
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t !!! Parabéns !!! " + secondPlayerName + "!!! Venceu !!!");
                            Methods.drawBoard(board);
                            gameOn = false;
                        }
                        else
                        {
                            if (Methods.fullBoardCheck(board))
                            {
                                Console.WriteLine("Deu empate ...");
                                Methods.drawBoard(board);
                                break;
                            }
                            else
                                turn = firstPlayerName;
                        }
                    }
                }

                if (!Methods.simOuNao("JogarDeNovo"))
                   
                break;

                Console.WriteLine();
            }
        }
    }
}
