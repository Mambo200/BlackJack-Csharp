using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        Helper h = new Helper();
        int won = 0;
        int countDrawCards = 10;
        int[] card = new int[21];

        public int[] CardReturnArray()
        {
            return card;
        }

        /// <summary>
        /// print cards from player 1 and player 2 (first card of player 2 not shown!)
        /// </summary>
        /// <param name="_player">false: Player 1, true: Player 2</param>
        /// <param name="_count">false: show all cards, true: show all cards exept the first one</param>
        public void CardReturn(bool _player, bool _count)
        {
            // Player 2
            if(_player)
            {
                Console.Write("\nTotal: " + won);
                Console.Write("\nSpieler 2: - ");
                h.ColorText(AmountOfPoints(_count));
            }

            // Player 1
            else
            {
                Console.Write("\nTotal: " + won);
                Console.Write("\nSpieler 1: - ");
                h.ColorText(AmountOfPoints(_count));
            }

            for (int i = 0; i < card.Length; i++)
            {
                if (i == 0 && _count)
                {
                    Console.WriteLine("Karte {0}: ?", i + 1);
                    continue;
                }

                if (card[i] != 0)
                    Console.WriteLine("Karte {0}: {1}", i + 1, card[i]);
                else
                    break;
            }
        }

        /// <summary>
        /// Amounts the of points.
        /// </summary>
        /// <param name="_count">false: count all cards, true: count all cards exept the first one</param>
        /// <returns>amount of points</returns>
        public int AmountOfPoints(bool _count)
        {
            int amount = 0;
            for (int i = 0; i < card.Length; i++)
            {
                if(_count && i == 0)
                {
                    continue;
                }
                amount += card[i];
            }

            return amount;
        }

        /// <summary>
        /// return one real card in hand.
        /// </summary>
        /// <param name="_place">place of the card.</param>
        /// <returns>real card</returns>
        public int CardReturn(int _place)
        {
            if (_place < 0 && _place >= card.Length)
            {
                return -1;
            }
            else
            {
                return card[_place];
            }
        }

        /// <summary>
        /// Sets the card in Hand
        /// </summary>
        /// <param name="_realCard">Card from DrawnCard</param>
        public void SetCard(int _realCard)
        {
            for (int i = 0; i < card.Length; i++)
            {
                if (card[i] == 0)
                {
                    card[i] = _realCard;
                    break;
                }
                else
                    continue;
            }
        }


        public void DrawCard()
        {
            System.Threading.Thread.Sleep(countDrawCards);
            countDrawCards++;
            Random rand = new Random();

            // get random number from 1 to 13
            int random = rand.Next(1, 14);

            // convert drawn card to real card
            int real = DrawnToReal(random);

            // put card into hand
            SetCard(real);

        }

        /// <summary>
        /// convert drawn cards to real cards
        /// </summary>
        /// <param name="_drawnCard">The drawn card.</param>
        /// <returns>real card / number</returns>
        private int DrawnToReal(int _drawnCard)
        {
            /*Drawn card = real Card
             * 1  = 11  // Ass
             * 2  = 2   // Number 2
             * 3  = 3   // Number 3
             * 4  = 4   // Number 4
             * 5  = 5   // Number 5
             * 6  = 6   // Number 6
             * 7  = 7   // Number 7
             * 8  = 8   // Number 8
             * 9  = 9   // Number 9
             * 10 = 10  // Number 10
             * 11 = 10  // Bube
             * 12 = 10  // Dame
             * 13 = 10  // König
             */

            int realCard;
            if (_drawnCard == 1)
                realCard = 11;
            else if (_drawnCard >= 10)
                realCard = 10;
            else
                realCard = _drawnCard;

            return realCard;
        }

        public void AddWinPoints()
        {
            won++;
        }
        public void AddWinPoints(int _amount)
        {
            won += _amount;
        }

        public void WinOut()
        {
            Console.WriteLine(won);
        }

        public void Reset()
        {
            for (int i = 0; i < card.Length; i++)
            {
                card[i] = 0;
            }
        }
    }
}
