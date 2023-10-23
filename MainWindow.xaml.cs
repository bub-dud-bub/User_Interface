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

namespace WPF_Lab_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Chose(object sender, RoutedEventArgs e)
        {
            FilmChose filmChose = new FilmChose();
            Close();
            filmChose.Show();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
            

        }

        private void Tiger_Design(object sender, RoutedEventArgs e)
        {
           
            Background = new SolidColorBrush(Colors.Orange);



        }

        private void Usual_Design(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.White);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Today_Click(object sender, RoutedEventArgs e)
        {
            Tommorow.IsChecked=false;
        }

        private void Tommorow_Click(object sender, RoutedEventArgs e)
        {
            Today.IsChecked=false;
        }

        private void Sto_Click(object sender, RoutedEventArgs e)
        {
            AllGrid2.Height = 723;
            AllGrid2.Width = 1173;

            AllGrid.ScaleX = 1;
            AllGrid.ScaleY = 1;
            PoltorSto.IsChecked = false;
            DveSto.IsChecked = false;
        }

        private void PoltorSto_Click(object sender, RoutedEventArgs e)
        {
            AllGrid2.Height = 1085;
            AllGrid2.Width = 1760;

            AllGrid.ScaleX = 1.5;
            AllGrid.ScaleY = 1.5;
            Sto.IsChecked=false;
            DveSto.IsChecked = false;
        }

        private void DveSto_Click(object sender, RoutedEventArgs e)
        {
            AllGrid2.Height = 1446;
            AllGrid2.Width = 2346;

            AllGrid.ScaleX = 2;
            AllGrid.ScaleY = 2;
            PoltorSto.IsChecked = false;
            Sto.IsChecked = false;
        }
    }   

}
