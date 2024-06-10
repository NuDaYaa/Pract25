using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Практическая_25;

namespace Pract25
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
        WindowApp point1;
        WindowApp2 point2;

        int cheker;

        private void Window_Initialized(object sender, EventArgs e)
        {
            point1 = new WindowApp(100, 100, 100, 100, 100);
            point2 = new WindowApp2(150, 100, 100, 100, 100);



            Canvas1.Children.Add(point1.Figure);
            Canvas1.Children.Add(point2.Figure);

            point1.Hide();
            point2.Hide();

            cheker = 0;
        }


        private void Button_MoveXY(object sender, RoutedEventArgs e)
        {

            bool f1 = int.TryParse(X_TB.Text, out int x);
            bool f2 = int.TryParse(Y_TB.Text, out int y);
            if (cheker == 1)
            {
                if (f1 && f2)
                {
                    if (x <= 480 && y <= 70)
                    {
                        point1.MoveXY(x, y);
                        point2.MoveXY(x, y);

                    }
                    else
                    {
                        MessageBox.Show("Превышено максимальное значение!\nX: 480\nY: 70", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Введенные координаты должны быть целым числом", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Для смены координат, обьект должен быть виден", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }



        private void Button_Show(object sender, RoutedEventArgs e)
        {

            point1.Show();
            point2.Show();

            cheker = 1;

        }

        private void Button_Hide(object sender, RoutedEventArgs e)
        {

            point2.Hide();
            point1.Hide();

            cheker = 0;

            X_TB.Clear();
            Y_TB.Clear();



        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Devoloper(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Тогузов Максим\nГруппа: ИСП-22\nВариант: 9",
                            "Разработчик",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        private void MenuItem_Obout(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант: 9\n\nЗадание:\nВывести на экран объект согласно заданию.\nОбъект: Полукруг",
                            "О программе",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        private void Button_RandomXY(object sender, RoutedEventArgs e)
        {
            if (cheker == 1)
            {
                Random randX = new Random();
                Random randY = new Random();

                int x = randX.Next(0, 480);
                int y = randY.Next(0, 70);

                point1.MoveXY(x, y);
                point2.MoveXY(x+50, y);

                X_TB.Text = x.ToString();
                Y_TB.Text = y.ToString();
            }
            else
            {
                MessageBox.Show("Для смены координат, обьект должен быть виден", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}