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
            //#region Test Only
            //TestOnly T = new TestOnly();
            //T.Output(5);
            //Console.ReadKey();
            //#endregion

            Game G = new Game();
            G.GameStart();
        }
    }
}
