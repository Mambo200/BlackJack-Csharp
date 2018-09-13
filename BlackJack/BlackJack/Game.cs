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
            // turn player 1
            bool dontDrawMore = false;

            // Output new game
            h.StartGameOutput();

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
            dontDrawMore = false;
            while (!dontDrawMore)
            {
                if (P2.AmountOfPoints(false) >= 16 || P2.AmountOfPoints(false) > P1.AmountOfPoints(false))
                {
                    dontDrawMore = true;
                }
                else
                {
                    P2.DrawCard();
                }
            }

            // show final results
            Console.Clear();
            Console.WriteLine("---Final Results----");
            ShowCards(true);

            // Win Lose output
            h.WinLose(P1.AmountOfPoints(false), P2.AmountOfPoints(false));
            Console.ReadKey();
        }

        // ------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// show cards of both players
        /// </summary>
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
    }
}
