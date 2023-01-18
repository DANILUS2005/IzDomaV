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
    /// Логика взаимодействия для Задание_6.xaml
    /// </summary>
    public partial class Задание_6 : Window
    {
        public Задание_6()
        {
            InitializeComponent();
        }

        private void k6_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(factorial6.Text);
            int i = 1;
            int sum = 1;
        LB1: if (i <= n)
            {
                sum *= i;
                i++;
                goto LB1;
            }
            else
                answerFactorial6.Content = $"Факториал числа {n} = {sum}.";
        }
    }
}
