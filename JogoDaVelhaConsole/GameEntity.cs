using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaConsole
{
    public class GameEntity
    {
  

        public string[] GameBoard { get; set; }
        public string[] Markers { get; set; }
        public string Turn { get; set; }
        public string FirstPlayerName { get; set; }
        public string SecondPlayerName { get; set; }

        public GameEntity()
        {
            GameBoard = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            Markers = new string[2] { " ", " " };
            Turn = "";
            FirstPlayerName = "";
            SecondPlayerName = "";
        }

        public GameEntity(string[] _gameBoard, string[] _markers, string _turn, string _firstPlayerName, string _secondPlayerName)
        {
            GameBoard = _gameBoard;
            Markers = _markers;
            Turn = _turn;
            FirstPlayerName = _firstPlayerName;
            SecondPlayerName = _secondPlayerName;
        }
    }
}
