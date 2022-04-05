using System;
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
                    racket.Move(area, -10);
                    break;
                case Direction.Right:
                    racket.Move(area, 10);
                    break;
                default:
                    break;
            }
        }
    }
}
