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

namespace DigitalDice.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool on = false;

        const int m = 7, n = 5;
        Rectangle[,] cells = new Rectangle[m,n];

        Random random = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {


        }

        private void OnOffButton_Click(object sender, RoutedEventArgs e)
        {
            if (!on)
                CreateMatrix();
            else
                RemoveMatrix();
        }

        private void CreateMatrix()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Rectangle cell = new();
                    cell.Height = Matrix.ActualHeight / m;
                    cell.Width = Matrix.ActualWidth / n;
                    cell.Fill = Brushes.Red;

                    Matrix.Children.Add(cell);

                    Canvas.SetLeft(cell, j * Matrix.ActualWidth / n);
                    Canvas.SetTop(cell, i * Matrix.ActualHeight / m);

                    cells[i, j] = cell;

                    on = true;
                }
            }
        }

        private void RemoveMatrix()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matrix.Children.Remove(cells[i,j]);
                }
            }

            on = false;
        }
    }
}
