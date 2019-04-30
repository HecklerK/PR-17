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

namespace ПР_17
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
            form.Close();
        }

        private void Sfera_Click(object sender, RoutedEventArgs e)
        {
            SferaF form2 = new SferaF();
            form2.Show();
            form.Hide();
        }

        private void Konus_Click(object sender, RoutedEventArgs e)
        {
            KonusF form2 = new KonusF();
            form2.Show();
            form.Hide();
        }

        private void UsechKon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Chelindr_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
