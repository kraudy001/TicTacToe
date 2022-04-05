using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pong.Logic
{
    public class GameLogic : IGameLogic
    {
        Size area;
        Racket racket;
        Point Center;

        public GameLogic(int x, int width, int height, Size area)
        {
            racket = new Racket(x, width, height, area);
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
