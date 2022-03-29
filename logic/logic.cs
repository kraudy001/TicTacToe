using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    class logic : IGameModel, IGameControler
    {
        public int[,] map { get; set; }

        public logic()
        {
            map = new int[3,3];
        }

        public void Click(double With,double hight, double clickWertical, double clcickHorisontal, int DOWHAT)
        {
            map[(int)(With/clcickHorisontal*3),(int)(hight/clickWertical*3)] = DOWHAT;
            if (WIN())
            {
                map = new int[3, 3];
            }

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
