using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace logic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Clicker clickController;
        public MainWindow()
        {
            InitializeComponent();
            bl blogic = new bl();
            renderer.SetupModel(blogic);
            clickController = new Clicker(blogic);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            renderer.Resize(new Size(grid.ActualWidth, grid.ActualHeight));
            renderer.InvalidateVisual();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            renderer.Resize(new Size(grid.ActualWidth, grid.ActualHeight));
            renderer.InvalidateVisual();


        }

        private void grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //to do mouse pointer, click meghívás és kinda kész?
            Point p = Mouse.GetPosition(Application.Current.MainWindow);            
            if (p.X <= this.ActualWidth && p.Y <= this.ActualHeight)
            {
                clickController.ValidClick(p, this.ActualWidth, this.ActualHeight);
                
            }
            

        }
    }
}
