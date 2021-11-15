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
using System.Runtime.InteropServices;


namespace ComputerClub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nRightRect,
        int nTopRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeigthEllipse
        );
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // О нас
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Бронь места
        {
            MainFrame.Navigate(new Page1());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // Прайс
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // ЗАКРЫТЬ
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(new Page1());
        }
    }
}
