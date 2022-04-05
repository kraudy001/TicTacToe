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

        public int Radius;

        public Ball(Size area)
        {
            Center = new Point(area.Width / 2, area.Height / 4);
            Speed = new Vector(1, 1);
            Radius = 3;
        }

        public bool Move(Size area)
        {
            Point newCenter = new Point(Center.X + Speed.X, Center.Y + Speed.Y);
            if (newCenter.X > 0+Radius + 10 
                && newCenter.X < area.Width - Radius - 10 
                && newCenter.Y > 0+ Radius +10 
                && newCenter.Y < area.Height -Radius-10)
            {
                Center = newCenter;
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
