﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pong.Logic
{
    internal class GameLogic : IGameLogic
    {
        Size area;
        public Racket Racket { get; set; }
        public event EventHandler Changed;
        public Ball Ball { get; set; }


        public GameLogic(int x, int width, int height, Size area)
        {
            Racket = new Racket(x, width, height, area);
            Ball = new Ball(area);
        }
        public void SetupSize(Size area)
        {

        }

        public enum Direction
        {
            Left, Right
        }

        public void Control(Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    Racket.Move(area, -10);
                    break;
                case Direction.Right:
                    Racket.Move(area, 10);
                    break;
                default:
                    break;
            }
        }

        public void TimeStep()
        {
            bool notWall = Ball.Move(area);
            if (!notWall)
            {
                Point p = Ball.Center;
                if (p.X <= 0 +10 +Ball.Radius)
                {

                }
            }

        }
    }
}
