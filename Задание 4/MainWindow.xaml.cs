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

namespace Задание_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void count_Click(object sender, RoutedEventArgs e) 
        {
            int A = Convert.ToInt32(a.Text);
            int B = Convert.ToInt32(b.Text);
            int sum = 0;
            for (int i = A + 1; i < B; i++)
            {
                sum += i;
            }
            answer.Content = sum;

            for (int i = A + 1; i < B; i++)
            {
                if (i % 2 == 1)
                {
                    answer2.Content += $"{i}; ";
                }
            }

        }

        private void perehod_Click(object sender, RoutedEventArgs e)
        {
            Задание_2  mainWindow = new Задание_2();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
