using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class WinException:Exception
    {
        public WinException() { }

        public WinException(string _message)
            :base(_message)
        {
        }
            
    }
}
