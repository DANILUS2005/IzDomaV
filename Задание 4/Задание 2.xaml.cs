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
    /// Логика взаимодействия для Задание_2.xaml
    /// </summary>
    public partial class Задание_2 : Window
    {
        public Задание_2()
        {
            InitializeComponent();
        }
        private void countFactorial_Click(object sender, RoutedEventArgs e) 
        {
            int n = Convert.ToInt32(factorial.Text);
            int i = 1;
            int sum = 1;
            do
            {
                sum *= i;
                i++;
            }while (i <= n);
            
                answerFactorial.Content = $"Факториал числа {n} = {sum}.";
        }

        private void perehod2_Click(object sender, RoutedEventArgs e)
        {
            Задание_3 mainWindow = new Задание_3();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
