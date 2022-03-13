using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game
{
    class Actor
    {
        public int X;
        public int Y;
        public int x1;
        public int y1;
        public Queue<int> puttX = new Queue<int>();
        public Queue<int> puttY = new Queue<int>();
        public int HP;
        public int HPMAX;
        public int armour;
        public int armourMAX;
        public int ID;
        public string symb;
        public int level;
        public int exp;
        public int livingLvl;
        public bool imposible = false;
        public int strenght;
        public int agility;
        public int endurance;
        public int luck;
        public int getting_exp;
        public int exp_to_new_lvl;
        public static Ppoint[,] sht = new Ppoint[30, 30];
        public bool put_gen = false;
        public Actor()
     {
            
            //HP = 0;
     }
        public void super_algoritm(string[,] map)
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    sht[i, j] = new Ppoint();
                }
            }
            sht[Y, X].exist = true;
            bool[] uroven = new bool[30];
            uroven[Y] = true;
            int numoftych = 0;
            while (!sht[y1, x1].exist)
            {
                for (int i = 0; i < 30; i++)
                {
                    if (uroven[i])
                    {
                        for (int j = 0; j < 30; j++)
                        {
                            if (sht[i, j].exist)
                            {
                                if (i - 1 >= 0 && map[i - 1, j] == "." && !sht[i - 1, j].exist)
                                {
                                    sht[i - 1, j].spidoznik = true;
                                    sht[i - 1, j].yZhg = i;
                                    sht[i - 1, j].xZhg = j;
                                    uroven[i - 1] = true;
                                }
                                if (i + 1 < 30 && map[i + 1, j] == "." && !sht[i + 1, j].exist)
                                {
                                    sht[i + 1, j].spidoznik = true;
                                    sht[i + 1, j].yZhg = i;
                                    sht[i + 1, j].xZhg = j;
                                    uroven[i + 1] = true;
                                }
                                if (j - 1 >= 0 && map[i, j - 1] == "." && !sht[i, j - 1].exist)
                                {
                                    sht[i, j - 1].spidoznik = true;
                                    sht[i, j - 1].yZhg = i;
                                    sht[i, j - 1].xZhg = j;
                                    uroven[i] = true;
                                }
                                if (j + 1 < 30 && map[i, j + 1] == "." && !sht[i, j + 1].exist)
                                {
                                    sht[i, j + 1].spidoznik = true;
                                    sht[i, j + 1].yZhg = i;
                                    sht[i, j + 1].xZhg = j;
                                    uroven[i] = true;
                                }

                            }
                            else if (sht[i, j].spidoznik)
                            {
                                sht[i, j].spidoznik = false;
                                sht[i, j].exist = true;
                            }
                            if (j + 1 < 30)
                            {
                                if (sht[i, j].spidoznik && map[i, j + 1] != ".")
                                {
                                    numoftych++;
                                    break;
                                }
                            }
                            numoftych++;
                        }
                    }
                }
                if (numoftych > 9999999)
                {
                    imposible = true;
                    break;
                }
                    
            }
            if (!imposible)
            {
                Queue<int> XX = new Queue<int>();
                Queue<int> YY = new Queue<int>();
                int xxx = x1;
                int yyy = y1;
                while (xxx != X || yyy != Y)
                {
                    XX.Enqueue(xxx);
                    YY.Enqueue(yyy);
                    int yyyy = sht[yyy, xxx].yZhg;
                    int xxxx = sht[yyy, xxx].xZhg;
                    xxx = xxxx;
                    yyy = yyyy;
                }
                /*XX.Enqueue(x);
                YY.Enqueue(y);*/
                int[] mX = new int[XX.Count * 2];
                int[] mY = new int[YY.Count * 2];
                XX.CopyTo(mX, XX.Count);
                Array.Reverse(mX);
                YY.CopyTo(mY, YY.Count);
                Array.Reverse(mY);
                for (int i = 0; i < XX.Count; i++)
                {
                    puttX.Enqueue(mX[i]);
                    puttY.Enqueue(mY[i]);
                }
                put_gen = true;
            }
            else
                put_gen = true;
                
            
        }
    }
   
}
