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

namespace WpfLab4
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
            double rateDollar = Convert.ToDouble(RateDollar.Text);
            double sumDollar = Convert.ToDouble(SumDollar.Text);
            double resDollar = rateDollar * sumDollar;
            ResDollar.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(RateEuro.Text);
            double sumEuro = Convert.ToDouble(SumEuro.Text);
            double resEuro = rateEuro * sumEuro;
            ResEuro.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateUah = Convert.ToDouble(RateUah.Text);
            double sumUah = Convert.ToDouble(SumUah.Text);
            double resUah = rateUah * sumUah;
            ResUah.Text = resUah.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateAmd = Convert.ToDouble(RateAmd.Text);
            double sumAmd = Convert.ToDouble(SumAmd.Text);
            double resAmd = rateAmd * sumAmd;
            ResAmd.Text = resAmd.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double foot = Convert.ToDouble(Foot.Text);
            double resFoot = foot * 0.3048;
            ResFoot.Text = resFoot.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double @in = Convert.ToDouble(In.Text);
            double resIn = @in * 0.0254;
            ResIn.Text = resIn.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double mi = Convert.ToDouble(Mi.Text);
            double resMi = mi * 1609.343998;
            ResMi.Text = resMi.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double nm = Convert.ToDouble(Nm.Text);
            double resNm = nm * 1852;
            ResNm.Text = resNm.ToString();
        }
    }
}
