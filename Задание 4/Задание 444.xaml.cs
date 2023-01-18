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
using System.Windows.Shapes;

namespace Задание_4
{
    /// <summary>
    /// Логика взаимодействия для Задание_444.xaml
    /// </summary>
    public partial class Задание_444 : Window
    {
        public Задание_444()
        {
            InitializeComponent();
        }
        private void count3_Click(object sender, RoutedEventArgs e) 
        {
            int n = Convert.ToInt32(number1.Text);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            answer4.Content = sum;
        }

        private void perehod4_Click(object sender, RoutedEventArgs e)
        {
            Задание_5 mainWindow = new Задание_5();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
