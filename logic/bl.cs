using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    class bl : IGameModel, IGameControler
    {
        public int[,] map { get; set; }
        public bl()
        {
            map = new int[3,3];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = 2;
                }
            }
        }

        public void Click(double With,double hight, double clickWertical, double clcickHorisontal, int DOWHAT)
        {
            if (FreeSpace())
            {
                int x = (int)(clcickHorisontal / With * 3);
                int y = (int)(clickWertical / hight * 3);
                map[(int)(clcickHorisontal / With * 3), (int)(clickWertical / hight * 3)] = DOWHAT;
                if (WIN())
                {
                    map = new int[3, 3];
                }
            }
            else
            {
                map = new int[3, 3];
            }

        }

        public void AIClick(int DOWHAT)
        {
            if (FreeSpace())
            {
                var rand = new Random();
                bool IS = true;
                while (IS)
                {
                    int with = rand.Next(0, 3);
                    int hight = rand.Next(0, 3);
                    if (map[with, hight] == 2)
                    {
                        map[with, hight] = DOWHAT;
                        IS = false;
                    }
                }
                if (WIN())
                {
                    map = new int[3, 3];
                }
            }
            else
            {
                map = new int[3, 3];
            }
        }

        private bool FreeSpace()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if(map[i, j] == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool WIN()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (map[i,0] == map[i,1] && map[i,0] == map[i, 2])
                {
                    return true;
                }
            }


            for (int i = 0; i < map.GetLength(1); i++)
            {
                if (map[0, i] == map[1, i] && map[0, i] == map[2, i])
                {
                    return true;
                }
            }

            if (map[1, 1] == map[2, 2] && map[2, 2] == map[3, 3] || map[3, 1] == map[2, 2] && map[2, 2] == map[1, 3])
            {
                return true;
            }


            return false;
        }
    }
}
