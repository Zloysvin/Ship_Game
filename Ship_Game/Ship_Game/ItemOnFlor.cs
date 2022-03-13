using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game
{
    class ItemOnFlor
    {
        public int X;
        public int Y;
        public int ItemId;
        public int ID_Spesabl;

        public void GetItemId(int lvl, int i)
        {
            int[] youu = {19,1,2,3,9,11,20,12,13,14,15,16,17,18,21};
            if (lvl >= 1)
            {
                int c =
                ItemId = youu[i];
            }
                
            else if (lvl >= 2)
                ItemId = youu[i];
            else if (lvl >= 3)
                ItemId = youu[i];
            else if (lvl >= 4)
                ItemId = youu[i];
        }
    }
}
