using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Game
    {
        public void GameStart()
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

            for (int i = 0; i < P1.CardReturn().Length; i++)
            {
                Console.WriteLine(P1.CardReturn(i));
            }
            Console.ReadKey();

        }
    }
}
