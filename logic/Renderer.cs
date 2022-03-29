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
                        ImageBrush brush = new ImageBrush();
                        switch (model.map[i,j])
                        {
                            
                            case 0:;
                                brush = new ImageBrush(new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "O.bmp"), UriKind.RelativeOrAbsolute)));
                                break;
                            case 1:
                                brush = new ImageBrush(new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "X.bmp"), UriKind.RelativeOrAbsolute)));
                                break;
                            case 2:
                                drawingContext.DrawRectangle(Brushes.White,
                                    new Pen(Brushes.Black, 4), new Rect(i * tileWidth, j * tileHeight, tileWidth, tileHeight));
                                break;
                            default:
                                break;
                        }

                        drawingContext.DrawRectangle(brush, new Pen(Brushes.Black, 3), new Rect(0, 0, size.Width, size.Height));
                    }
                }

            }

        }



    }
}
