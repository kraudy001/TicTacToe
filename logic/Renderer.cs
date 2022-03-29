using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace logic
{
    public class Renderer : FrameworkElement
    {
        IGameModel model;
        Size size;

        public void Resize(Size size)
        {
            this.size = size;
        }

        public void SetupModel(IGameModel model)
        {
            this.model = model;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (model != null && size.Width > 81 && size.Height > 81)
            {
                double tileWidth = size.Width / 3;
                double tileHeight = size.Height / 3;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        switch (model.map[i,j])
                        {
                            case 0:
                                drawingContext.DrawRectangle(new ImageBrush(new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "X.bmp"), UriKind.RelativeOrAbsolute)),
                                    new Pen(Brushes.Black, 4), new Rect(i * tileWidth, j * tileHeight, tileWidth, tileHeight)));
                                break;
                            case 1:
                                drawingContext.DrawRectangle(new ImageBrush(new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "X.bmp"), UriKind.RelativeOrAbsolute)),
                                    new Pen(Brushes.Black, 4), new Rect(i * tileWidth, j * tileHeight, tileWidth, tileHeight)));
                                break;
                            case 2:
                                drawingContext.DrawRectangle(Brushes.White,
                                    new Pen(Brushes.Black, 4), new Rect(i * tileWidth, j * tileHeight, tileWidth, tileHeight));
                                break;
                            default:
                                break;
                        }
                    }
                }

            }

        }



    }
}
