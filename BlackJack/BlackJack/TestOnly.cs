using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class TestOnly
    {
        public void Output()
        {
            Player P1 = new Player();
            Player P2 = new Player();

            P1.SetCard(2);
            P1.SetCard(3);
            P1.SetCard(5);
            P1.SetCard(4);
            P1.SetCard(7);
            P1.SetCard(78);
            P1.SetCard(1);
            P1.SetCard(5);
            P1.SetCard(8);
            P1.SetCard(9);

            for (int i = 0; i < P1.CardReturnArray().Length; i++)
            {
                Console.WriteLine(P1.CardReturn(i));
            }
            Console.ReadKey();
        }

        public void Output (int _number)
        {
            Player P1 = new Player();
            Player P2 = new Player();

            P1.DrawCard();
            P2.DrawCard();
            P1.DrawCard();
            P2.DrawCard();

            int[] cardsP1 = P1.CardReturnArray();
            int[] cardsP2 = P2.CardReturnArray();

            P1.CardReturn(false, false);
            P2.CardReturn(true, true);
        }
    }
}
