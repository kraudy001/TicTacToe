using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pong.Logic
{
    class Ball
    {
        public Point Center { get; set; }

        public Vector Speed { get; set; }

        public Ball(Size area)
        {
            Center = new Point(area.Width / 2, area.Height / 4);
            Speed = new Vector(1, 1);
        }
    }
}
