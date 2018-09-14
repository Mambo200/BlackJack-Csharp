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
            Console.WriteLine("First thing I should mention:");
            Console.WriteLine("The game becomes more laggy after a while. this is because of the random function c# has.");
            Console.WriteLine("Every time you start a new game, it takes 1 millisecond longer.");
            Console.WriteLine("If it takes too long, you can rust restart the application, but beware, your total score is lost after restarting.");
            Console.WriteLine("So have fun :)");

            Console.ReadKey();

            Game G = new Game();
            G.GameStart();
        }
    }
}
