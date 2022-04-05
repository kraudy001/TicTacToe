using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pong.Logic
{
    internal class Racket
    {
        public Point Center { get; set; }
        int racketWidth;
        int racketHeight;
        Size area;

        public Racket(int xCenter, int racketWidth, int racketHeight, Size area)
        {
            //Center = new Point(area.Width / 2, area.Height - 20);
            Center = new Point(xCenter, area.Height-(racketHeight+10));

        }

        public void Move(Size area, int diff)
        {
            Point newCenter = new Point(Center.X + diff, Center.Y);
            if (newCenter.X > racketWidth+10 && newCenter.X < area.Width-racketWidth-10)
            {
                Center = newCenter;
            }

        }
    }
}
