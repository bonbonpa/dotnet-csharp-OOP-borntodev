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

namespace BornToDev_Static_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double price = double.Parse(priceTextBox.Text);
            double vat = double.Parse(VatTextBox.Text);

            double totalPrice = VatCaculator.TotalPrice(price, vat);
            double vatCalculate = VatCaculator.VatCalculate(price, vat);

            MessageBox.Show("Price Products : " + price + " bath vat :" + vat + "%\n" + "Vat is spent :" + vatCalculate + " bath \nSummaryTotal : " + totalPrice);
        }
    }
}
