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
    /// Логика взаимодействия для Задание_3.xaml
    /// </summary>
    public partial class Задание_3 : Window
    {
        public Задание_3()
        {
            InitializeComponent();
        }
        private void count2_Click(object sender, RoutedEventArgs e) 
        {
            for (int i = 10; i <= 20; i++)
            {
                answer3.Content += $"{Math.Pow(i, 2)};  ";
            }

        }

        private void perehod3_Click(object sender, RoutedEventArgs e)
        {
            Задание_444 mainWindow = new Задание_444();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
