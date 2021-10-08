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

namespace TRPO_WPF_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            TB1.Text =  "Введите целое число, используя только цифры. Число не должно превышать 10 знаков.";
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             int chis, sum = 0;
            chis = Convert.ToInt32(vvod.Text);
                while(chis>0)
                {
                    sum += chis % 10;
                    chis /= 10;
                }
            TB1.Text = "Вы ввели число: " + vvod.Text + "\n";
            if (chis % 3 == 0) TB1.Text += "Это число кратно трём.\n";
            else TB1.Text += "Это число не кратно трём.\n";
            if (chis % 2 == 0) TB1.Text += "Это число чётное.\n";
            else TB1.Text += "Это число не чётное.\n";
            TB1.Text = TB1.Text + "Сумма цифр, составляющих это число равна: " + sum;
                sum = 0;
            }
            catch(Exception)
            {
                TB1.Text = "Ошибка ввода:\n" +
                    "Введите целое число, используя только цифры. Число не должно превышать 10 знаков.";
            }
        }
    }
}
