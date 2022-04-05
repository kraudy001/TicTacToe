using System.Windows;

namespace Pong.Logic
{
    internal interface IGameLogic
    {
        Ball Ball { get; set; }
        Racket Racket { get; set; }

        void Control(GameLogic.Direction dir);
        void SetupSize(Size area);
    }
}