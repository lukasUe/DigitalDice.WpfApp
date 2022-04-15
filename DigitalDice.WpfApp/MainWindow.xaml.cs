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

        Random random = new(DateTime.Now.Millisecond);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if(on)
            {
                int result = random.Next(1, 7);

                ClearMatrix();

                switch(result)
                {
                    case 1:
                        PrintOne();
                        break;
                    case 2:
                        PrintTwo();
                        break;
                    case 3:
                        PrintThree();
                        break;
                    case 4:
                        PrintFour();
                        break;
                    case 5:
                        PrintFive();
                        break;
                    case 6:
                        PrintSix(); 
                        break;
                }
            }

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
                    cell.Height = Matrix.ActualHeight / m - 2.0;
                    cell.Width = Matrix.ActualWidth / n - 2.0;
                    cell.Fill = Brushes.Gray;

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

        private void ClearMatrix()
        {
            for(int i = 0;i < m;i++)
            {
                for (int j = 0; j < n; j++)
                {
                    cells[i, j].Fill = Brushes.Gray;
                }
            }
        }

        private void PrintOne()
        {
            cells[1, 2].Fill = Brushes.DarkGreen;
            cells[1, 3].Fill = Brushes.DarkGreen;
            cells[2, 3].Fill = Brushes.DarkGreen;
            cells[3, 3].Fill = Brushes.DarkGreen;
            cells[4, 3].Fill = Brushes.DarkGreen;
            cells[5, 3].Fill = Brushes.DarkGreen;
        }

        private void PrintTwo()
        {
            cells[1, 1].Fill = Brushes.DarkGreen;
            cells[1, 2].Fill = Brushes.DarkGreen;
            cells[1, 3].Fill = Brushes.DarkGreen;
            cells[2, 3].Fill = Brushes.DarkGreen;
            cells[3, 1].Fill = Brushes.DarkGreen;
            cells[3, 2].Fill = Brushes.DarkGreen;
            cells[3, 3].Fill = Brushes.DarkGreen;
            cells[4, 1].Fill = Brushes.DarkGreen;
            cells[5, 1].Fill = Brushes.DarkGreen;
            cells[5, 2].Fill = Brushes.DarkGreen;
            cells[5, 3].Fill = Brushes.DarkGreen;
        }

        private void PrintThree()
        {
            cells[1, 1].Fill = Brushes.DarkGreen;
            cells[1, 2].Fill = Brushes.DarkGreen;
            cells[1, 3].Fill = Brushes.DarkGreen;
            cells[2, 3].Fill = Brushes.DarkGreen;
            cells[3, 1].Fill = Brushes.DarkGreen;
            cells[3, 2].Fill = Brushes.DarkGreen;
            cells[3, 3].Fill = Brushes.DarkGreen;
            cells[4, 3].Fill = Brushes.DarkGreen;
            cells[5, 1].Fill = Brushes.DarkGreen;
            cells[5, 2].Fill = Brushes.DarkGreen;
            cells[5, 3].Fill = Brushes.DarkGreen;
        }

        private void PrintFour()
        {
            cells[1, 1].Fill = Brushes.DarkGreen;
            cells[1, 3].Fill = Brushes.DarkGreen;
            cells[2, 1].Fill = Brushes.DarkGreen;
            cells[2, 3].Fill = Brushes.DarkGreen;
            cells[3, 1].Fill = Brushes.DarkGreen;
            cells[3, 2].Fill = Brushes.DarkGreen;
            cells[3, 3].Fill = Brushes.DarkGreen;
            cells[4, 3].Fill = Brushes.DarkGreen;
            cells[5, 3].Fill = Brushes.DarkGreen;
        }

        private void PrintFive()
        {
            cells[1, 1].Fill = Brushes.DarkGreen;
            cells[1, 2].Fill = Brushes.DarkGreen;
            cells[1, 3].Fill = Brushes.DarkGreen;
            cells[2, 1].Fill = Brushes.DarkGreen;
            cells[3, 1].Fill = Brushes.DarkGreen;
            cells[3, 2].Fill = Brushes.DarkGreen;
            cells[3, 3].Fill = Brushes.DarkGreen;
            cells[4, 3].Fill = Brushes.DarkGreen;
            cells[5, 1].Fill = Brushes.DarkGreen;
            cells[5, 2].Fill = Brushes.DarkGreen;
            cells[5, 3].Fill = Brushes.DarkGreen;
        }

        private void PrintSix()
        {
            cells[1, 1].Fill = Brushes.DarkGreen;
            cells[1, 2].Fill = Brushes.DarkGreen;
            cells[1, 3].Fill = Brushes.DarkGreen;
            cells[2, 1].Fill = Brushes.DarkGreen;
            cells[3, 1].Fill = Brushes.DarkGreen;
            cells[3, 2].Fill = Brushes.DarkGreen;
            cells[3, 3].Fill = Brushes.DarkGreen;
            cells[4, 1].Fill = Brushes.DarkGreen;
            cells[4, 3].Fill = Brushes.DarkGreen;
            cells[5, 1].Fill = Brushes.DarkGreen;
            cells[5, 2].Fill = Brushes.DarkGreen;
            cells[5, 3].Fill = Brushes.DarkGreen;

        }
    }

}
