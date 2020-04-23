using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace JogoDaVelhaConsole
{
    public static class Methods
    {
        ///Fazer Matriz do jogo da velha
        public static void drawBoard(string[] _board)
        {
            Console.WriteLine(" " + _board[0] + " " + "|" + " " + _board[1] + " " + "|" + " " + _board[2]);
            Console.WriteLine("--- --- ---");
            Console.WriteLine(" " + _board[3] + " " + "|" + " " + _board[4] + " " + "|" + " " + _board[5]);
            Console.WriteLine("--- --- ---");
            Console.WriteLine(" " + _board[6] + " " + "|" + " " + _board[7] + " " + "|" + " " + _board[8]);
        }
        ///verificar posicao se esta errada ou ja foi utilizada
      

        public static string[] placeMarker(string[] _board, string _marker, int _position)
        {
            while ((_position - 1 > 8 || _position - 1 < 0) || _board[_position - 1] != " ")
            {
                Console.WriteLine("Posição errada...");
                Console.Write("Sua próxima posição: ");
                _position = Convert.ToInt32(Console.ReadLine());
            }
            _board[_position - 1] = _marker;
            return _board;
        }


        public static int checkIntPosition(string _name)
        {
            int position = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(_name + ", Por favor, digite sua posição: ");
                success = int.TryParse(Console.ReadLine(), out position);
            }
            return position;
        }

  
        /// Escolher aletoriamente quem vai jogar primeiro
   
        public static string firstTurn(string _firstName, string _secondName)
        {
            var rnd = new Random();
            var choise = rnd.Next(2);

            if (choise == 0)
                return _firstName;
            else
                return _secondName;
        }



        public static string[] fillMarkers(string[] _markers, string _name)
        {
            var temp = "";
            while (!(temp == "X" || temp == "O"))
            {
                Console.Write(_name + ": Qual você escolhe  X ou O? --> ");
                temp = Console.ReadLine().ToUpper();
            }
            if (temp == "X")
            {
                _markers[0] = "X";
                _markers[1] = "O";
            }
            else
            {
                _markers[0] = "O";
                _markers[1] = "X";
            }

            return _markers;
        }

        public static bool spaceCheck(string[] _board, int _position)
        {
            return _board[_position] == " ";
        }


        public static bool fullBoardCheck(string[] _board)
        {
            for (int i = 0; i < _board.Length; i++)
                if (spaceCheck(_board, i))
                    return false;
            return true;
        }

        /// Checar se o jogador venceu
        public static bool winCheck(string[] _board, string _marker)
        {
            return ((_board[0] == _marker && _board[1] == _marker && _board[2] == _marker) ||
                    (_board[3] == _marker && _board[4] == _marker && _board[5] == _marker) ||
                    (_board[6] == _marker && _board[7] == _marker && _board[8] == _marker) ||
                    (_board[0] == _marker && _board[4] == _marker && _board[8] == _marker) ||
                    (_board[2] == _marker && _board[4] == _marker && _board[6] == _marker) ||
                    (_board[0] == _marker && _board[3] == _marker && _board[6] == _marker) ||
                    (_board[1] == _marker && _board[4] == _marker && _board[7] == _marker) ||
                    (_board[2] == _marker && _board[5] == _marker && _board[8] == _marker));
        }

        /// Opcao de escolaha para jogar novamente S (Sim) ou N (Nao)

        public static bool simOuNao(string _choise)
        {
            switch (_choise)
            {
                case "JogarDeNovo":
                    Console.Write("Gostaria de Jogar Novamente (S/N): ");
                    break;

            }
            var answer = Console.ReadLine();
            return answer.Substring(0, 1) == "S" || answer.Substring(0, 1) == "s";
        }
       
    }
}
