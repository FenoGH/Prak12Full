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
using SolutionLib; 

namespace Prak12Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a = 1;
        double b = 0.96;
        double c = 0.80;


        public MainWindow()
        {
            InitializeComponent();
            TablIteamScore.Text = "Задание 1";
            Window1.Title = ($"Практическая 12 (Задание 1 )");
            MainGrid.Background = new SolidColorBrush(ColorUtils.GetRgb(a, b, c));
            MainStatus.Background = new SolidColorBrush(ColorUtils.GetRgb(a, b, c));



        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
            DispatcherTimer timerc = new DispatcherTimer();
            timerc.Tick += Timerс_Tick;
            timerc.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timerc.IsEnabled = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            Date.Text = d.ToString("dd.MM.yyyy");
            Time.Text = d.ToString("HH:mm");
            

        }
        private void Timerс_Tick(object sender, EventArgs e)
        {
            if (c < 1)
            {
                c += 0.02;
                b -= 0.02;

            }
            else
            {
                c -= 0.2;
                b += 0.2;
            }






            MainGrid.Background = new SolidColorBrush(ColorUtils.GetRgb(a, b, c));
            MainStatus.Background = new SolidColorBrush(ColorUtils.GetRgb(a, b, c));
        }

        private void Solution_Click(object sender, RoutedEventArgs e)
        {
            if (Tab1.IsSelected == true)
            {
                double.TryParse(R1.Text, out double r1); double.TryParse(R2.Text, out double r2);
                if (r1 > r2)
                {
                    double s1 = 0; double s2 = 0; double s3;
                    Task1.Sqare(r1, out s1);
                    Task1.Sqare(r2, out s2);
                    Task1.Rinsqare(s1, s2, out s3);
                    Res.Text = ($"Площадь круга 1 = {s1} \nПлощадь круга 2 = {s2}\nПлощадь кольца = {s3}");
                }
                else
                {
                    MessageBox.Show("Радиус r1 должен быть больше радиуса r2");
                }
                R1.Focus();
            }
            else
            {
                int.TryParse(Year.Text, out int year);
                if (year > 0 && year != 0)
                {
                    Task2.Сentury(year, out int century);
                    if (century > 1)
                    {
                        Result.Text = ($"{Convert.ToString(century)} век");
                    }
                    else
                    {
                        Result.Text = ($"1 век");
                    }
                    Year.Focus();
                }
                else
                {
                    MessageBox.Show("Введите правльный год нашэй эры");
                }


            }

        }

        private void TabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            TablIteamScore.Text = "Задание 2";
            Window1.Title = ($"Практическая 12 (Задание 2 )");
        }

        private void TabItem_GotFocus_1(object sender, RoutedEventArgs e)
        {
            TablIteamScore.Text = "Задание 1";
            Window1.Title = ($"Практическая 12 (Задание 1 )");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Task_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Борькин Иван ИСП-31 Вариант 8\nРеализовать расчет задачи:\n• Даны два круга с общим центром и радиусами R1 и R2(R1 > R2).Найти площади этих кругов S1 и S2, а также площадь S3 кольца, внешний радиус которого равен R1, внутренний радиус равен R2: S1 = PI * (R1)2 , S2 = PI * (R2)2 , S3 = S1 – S2.В качестве значения PI использовать 3.14.\n• Дан номер некоторого года(целое положительное число).Определить соответствующий ему номер столетия, учитывая, что, к примеру, началом 20 столетия был 1901 год");
        }

        private void R1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Res.Clear();
        }

        private void R2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Res.Clear();
        }

        private void Year_TextChanged(object sender, TextChangedEventArgs e)
        {
            Result.Clear();
        }
    }
}
