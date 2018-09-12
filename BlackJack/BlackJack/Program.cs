using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player p1 = new Player();
            //Console.WriteLine(p1.CardReturn().Length);
            //Console.ReadKey();
            Game G = new Game();
            G.GameStart();
        }
    }
}
