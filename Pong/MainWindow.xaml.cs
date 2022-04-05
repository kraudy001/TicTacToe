﻿using Pong.Logic;
using Pong.Render;
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
using System.Windows.Threading;

namespace Pong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameLogic gameLogic;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                gameLogic.Control(GameLogic.Direction.Left);
            }
            else if (e.Key == Key.Right)
            {
                gameLogic.Control(GameLogic.Direction.Right);
            }

        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            gameLogic.TimeStep();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gameLogic = new GameLogic((int)grid.ActualWidth / 2, 100, 10, new Size(grid.ActualWidth, grid.ActualHeight));
            
            Renderer.SetupModel(gameLogic);

            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromMilliseconds(100);
            dt.Tick += Dt_Tick;
            dt.Start();

            Renderer.SetupSize(new Size(grid.ActualWidth, grid.ActualHeight));
            gameLogic.SetupSize(new Size(grid.ActualWidth, grid.ActualHeight));


        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(gameLogic != null)
            {
                Renderer.SetupSize(new Size(grid.ActualWidth, grid.ActualHeight));
                gameLogic.SetupSize(new Size(grid.ActualWidth, grid.ActualHeight));

            }

        }
    }
}
