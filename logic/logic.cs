using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    class logic : IGameModel, IGameControler
    {
        public int[,] map;

        public logic()
        {
            map = new int[3,3];


        }

        public void Click()
        {

        }

    }
}
