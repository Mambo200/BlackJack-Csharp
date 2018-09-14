using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Game
    {
        Helper h = new Helper();
        Player P1 = new Player();
        Player P2 = new Player();

        public void GameStart()
        {
            P1.Reset();
            P2.Reset();

            while (true)
            {


                // turn player 1
                bool dontDrawMore = false;                

                // player 1 and 2 draw two cards
                P1.DrawCard();
                P2.DrawCard();
                P1.DrawCard();
                P2.DrawCard();

                // show cards
                while (!dontDrawMore)
                {
                    Console.Clear();
                    ShowCards(false);

                    if (P1.AmountOfPoints(false) >= 21)
                    {
                        dontDrawMore = true;
                    }
                    else
                    {
                        string drawcard = Console.ReadLine().ToLower();
                        if (drawcard == "y")
                        {
                            P1.DrawCard();
                        }
                        else if (drawcard == "n")
                        {
                            dontDrawMore = true;
                        }
                    }
                }

                // Turn Player 2
                if (P1.AmountOfPoints(false) > 21)
                    dontDrawMore = true;
                else
                    dontDrawMore = false;
                while (!dontDrawMore)
                {
                    if (P2.AmountOfPoints(false) > P1.AmountOfPoints(false) || P2.AmountOfPoints(false) == 21)
                    {
                        dontDrawMore = true;
                    }
                    else
                    {
                        P2.DrawCard();
                    }
                }

                //zwischenergebnis
                Console.Clear();
                Console.WriteLine("---Interim Result----");
                ShowCards(false, true);
                Console.ReadKey();

                // show final results
                Console.Clear();
                Console.WriteLine("---Final Result----");
                ShowCards(true);

                // Win Lose output
                switch (h.WinLose(P1.AmountOfPoints(false), P2.AmountOfPoints(false)))
                {
                    case 1:
                        P1.AddWinPoints();
                        break;
                    case 2:
                        P2.AddWinPoints();
                        break;
                }
                //P1.WinOut();
                //P2.WinOut();
                P1.Reset();
                P2.Reset();
                Console.ReadKey();
            }
        }

        // ------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// show cards of both players
        /// </summary>
        /// <param name="_final">false: with "Draw Card" text, show all cards Player2 exept the first one; true: without text, show all cards Player2</param>
        void ShowCards(bool _final)
        {

            P1.CardReturn(false, false);

            if (_final)
            {
                P2.CardReturn(true,false);
            }
            else
            {
                P2.CardReturn(true, true);
            }

            if(!_final)
                Console.WriteLine("\n\n\nDraw Card? (y/n)");

        }

        /// <summary>
        /// show cards of both players
        /// </summary>
        /// <param name="_final">false: show all cards Player2 exept the first one, true: show all cards Player2</param>
        /// <param name="_interimResult">false: with "Draw Card" text, true: without text</param>
        void ShowCards(bool _final, bool _interimResult)
        {
            P1.CardReturn(false, false);

            if (_final)
            {
                P2.CardReturn(true, false);
            }
            else
            {
                P2.CardReturn(true, true);
            }

            if (!_interimResult)
                Console.WriteLine("\n\n\nDraw Card? (y/n)");

        }
    }
}
