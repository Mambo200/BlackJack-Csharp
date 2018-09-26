using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BlackJack
{
    class Helper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_player1">Player 1 amount of points</param>
        /// <param name="_player2">Player 2 amount of points</param>
        public int WinLose(int _player1, int _player2)
        {
            // 1 = Player1 win | 2 = Player2 win | 3 = tied
            int whoWon = 0;

            // one player has more than 21 points
            // tied
            if (_player1 > 21 && _player2 > 21)
            {
                whoWon = 3;
            }

            // Player 2 has too many points
            else if (_player1 > 21)
            {
                whoWon = 2;
            }

            // Player 1 has too many points
            else if (_player2 > 21)
            {
                whoWon = 1;
            }

            if (whoWon == 0)
            {
                // both players have less than or equal 21 points
                // Player 1 has more points than Player 2
                if (_player1 > _player2)
                {
                    whoWon = 1;
                }

                // Player 2 has more points than Player 1
                else if (_player2 > _player1)
                {
                    whoWon = 2;
                }

                // both Player have the same amount of points
                else
                {
                    whoWon = 3;
                }
            }

            Console.WriteLine();

            // output
            switch (whoWon)
            {
                case 1:
                    ColorText("Player 1 wins!", ConsoleColor.Green, true);
                    break;

                case 2:
                    ColorText("Player 2 wins!", ConsoleColor.Green, true);
                    break;

                case 3:
                    ColorText("Tied!", ConsoleColor.Yellow, true);
                    break;

                default:
                    throw new WinException
                        ("Bei der Rechnung ist etwas schief gelaufen. Die Variable 'whoWon' darf nicht kleiner als 1 oder mehr als 3 sein.\nwhoWon = " + whoWon + ".");
            }

            return whoWon;
        }

        /// <summary>
        /// Coloring the text.
        /// </summary>
        /// <param name="_text">The text.</param>
        /// <param name="_color">The color.</param>
        public void ColorText(string _text, ConsoleColor _color, bool _writelineOn)
        {
            Console.ForegroundColor = _color;
            if (_writelineOn)
                Console.WriteLine(_text);
            else
                Console.Write(_text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Coloring the text. Color depents on _points
        /// </summary>
        /// <param name="_points">The points.</param>
        public void ColorText(int _points)
        {
            Console.ForegroundColor = ColoringText(_points);
            Console.WriteLine(_points.ToString());
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Coloring the _points text depents on how high _points is.
        /// </summary>
        /// <param name="_points">The points.</param>
        /// <returns>Color</returns>
        private ConsoleColor ColoringText(int _points)
        {
            if (_points <= 10)
                return ConsoleColor.Blue;
            else if (_points > 10 && _points <= 16)
                return ConsoleColor.Yellow;
            else if (_points < 21)
                return ConsoleColor.DarkYellow;
            else if (_points == 21)
                return ConsoleColor.Green;
            else
                return ConsoleColor.Red;
        }
    }
}