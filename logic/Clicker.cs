using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace logic
{
    class Clicker
    {
        IGameControler controller;

        public Clicker(IGameControler controller)
        {
            this.controller = controller;
        }

        public void ValidClick(Point p, double windowWidth, double windowHeight)
        {
            controller.Click(windowWidth, windowHeight, p.Y, p.X, 1);
            controller.AIClick(0);
        }
    }
}
