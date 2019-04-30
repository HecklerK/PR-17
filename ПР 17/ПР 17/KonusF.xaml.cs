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

namespace ПР_17
{
    /// <summary>
    /// Логика взаимодействия для KonusF.xaml
    /// </summary>
    public partial class KonusF : Window
    {
        public KonusF()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double R = Convert.ToDouble(TBR.Text);
            double H = Convert.ToDouble(TBH.Text);
            double So = System.Math.PI * R * R;
            double Sb = System.Math.PI * R * (R * R + H * H);
            SO.Text = "S осн = " + Convert.ToString(So);
            SB.Text = "S бок = " + Convert.ToString(Sb);
            SOB.Text = "S общ = " + Convert.ToString(So + Sb);
            V.Text = "V = " + Convert.ToString(So + Sb + H);
        }
    }
}
