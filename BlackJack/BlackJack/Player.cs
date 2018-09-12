using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        int[] card = new int[21];

        public int[] CardReturn()
        {
            return card;
        }

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
            //card = _realCard;
        }
    }
}
