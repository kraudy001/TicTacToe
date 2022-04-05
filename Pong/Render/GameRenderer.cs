using Pong.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Pong.Render
{
    internal class GameRenderer : FrameworkElement
    {
        IGameLogic logic;
        Size size;

        public void SetupSize(Size newSize)
        {
            this.size = newSize;
            InvalidateVisual();
        }

        public void SetupModel(IGameLogic gameLogic)
        {
            this.logic = gameLogic;
            InvalidateVisual();
        }

        public Brush Fild
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "fild.bmp"), UriKind.RelativeOrAbsolute)));
            }
        }

        public Brush Ball
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "ball.bmp"), UriKind.RelativeOrAbsolute)));
            }
        }

        public Brush RECT
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "54272.bmp"), UriKind.RelativeOrAbsolute)));
            }
        }


        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (size.Width > 0 && size.Height > 0 && logic != null)
            {
                drawingContext.DrawRectangle(Fild, null, new Rect(0, 0, size.Width, size.Height));
                drawingContext.DrawEllipse(Ball, null, logic.Ball.Center, logic.Ball.Radius, logic.Ball.Radius);

                drawingContext.DrawRectangle(RECT, null, new Rect(logic.Racket.Center.X + logic.Racket.racketWidth,
                    logic.Racket.Center.Y + logic.Racket.racketHeight, logic.Racket.racketWidth, logic.Racket.racketHeight));
                
            }
        }
    }
}
