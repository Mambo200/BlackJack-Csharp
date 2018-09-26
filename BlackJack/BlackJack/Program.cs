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
            Console.WriteLine("Welcome to Blackjack.");
            Console.WriteLine("I hope you know the rules of Blackjack ... and so I do.");
            Console.WriteLine("So have fun!");

            Console.ReadKey();

            Game G = new Game();
            G.GameStart();
        }
    }
}
