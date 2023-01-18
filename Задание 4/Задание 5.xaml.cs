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
    /// Логика взаимодействия для Задание_5.xaml
    /// </summary>
    public partial class Задание_5 : Window
    {
        public Задание_5()
        {
            InitializeComponent();
        }
        private void countPrize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Age = Convert.ToInt32(age.Text);
                if (Age < 5 && Age > 0)
                    answerPrize.Content = "Премия составляет 10% от заработной платы.";
                else if (Age >= 5 && Age < 10)
                    answerPrize.Content = "Премия составляет 15% от заработной платы.";
                else if (Age >= 10 && Age < 15)
                    answerPrize.Content = "Премия составляет 25% от заработной платы.";
                else if (Age >= 15 && Age < 20)
                    answerPrize.Content = "Премия составляет 35% от заработной платы.";
                else if (Age >= 20 && Age < 25)
                    answerPrize.Content = "Премия составляет 45% от заработной платы.";
                else if (Age >= 25)
                    answerPrize.Content = "Премия составляет 50% от заработной платы.";
                else if (Age < 0)
                    answerPrize.Content = "Выслуга лет не может быть отрицательной.";
            }
            catch
            {
                answerPrize.Content = "Error";
            }

        }

        private void perehod5_Click(object sender, RoutedEventArgs e)
        {
            Задание_6 mainWindow = new Задание_6();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
