using System;
using System.Collections.Generic;
using System.Data;
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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string Put;
        public static bool Clear = false;
        public static bool TrueClear = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OneB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "1";
            CalculateTB.Text = Put;
        }

        private void TwoB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "2";
            CalculateTB.Text = Put;
        }

        private void ThreeB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "3";
            CalculateTB.Text = Put;
        }

        private void ForB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "4";
            CalculateTB.Text = Put;
        }

        private void FiveB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "5";
            CalculateTB.Text = Put;
        }

        private void SixB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "6";
            CalculateTB.Text = Put;
        }

        private void SevenB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "7";
            CalculateTB.Text = Put;
        }

        private void EightB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "8";
            CalculateTB.Text = Put;
        }

        private void NineB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "9";
            CalculateTB.Text = Put;
        }

        private void NullB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += "0";
            CalculateTB.Text = Put;
        }

        private void DotB_Click(object sender, RoutedEventArgs e)
        {
            UpdateCalculate();
            Clear = false;
            Put += ".";
            CalculateTB.Text = Put;
        }

        private void EquallyB_Click(object sender, RoutedEventArgs e)
        {
            ValidateLenght(Put);
            Put = new DataTable().Compute(CalculateTB.Text, null).ToString();
            CalculateTB.Text = Put;
            Clear = true;
        }

        private void PlusB_Click(object sender, RoutedEventArgs e)
        {
            Clear = false;
            Put += "+";
            CalculateTB.Text = Put;
        }

        private void MinusB_Click(object sender, RoutedEventArgs e)
        {
            Clear = false;
            Put += "-";
            CalculateTB.Text = Put;
        }

        private void MultiplyB_Click(object sender, RoutedEventArgs e)
        {
            Clear = false;
            Put += "*";
            CalculateTB.Text = Put;
        }

        private void DivideB_Click(object sender, RoutedEventArgs e)
        {
            Clear = false;
            Put += "/";
            CalculateTB.Text = Put;
        }

        private void SinB_Click(object sender, RoutedEventArgs e)
        {
            if(Put == null)
            {
                MessageBox.Show("Error Put is null");
                return;
            }
            ValidateLenght(Put);
            Put = new DataTable().Compute(CalculateTB.Text, null).ToString();
            CalculateTB.Text = Put;
            Put = Math.Sin(Convert.ToDouble(CalculateTB.Text)).ToString();
            CalculateTB.Text = Put;
            Clear = true;

        }

        private void CosB_Click(object sender, RoutedEventArgs e)
        {
            if (Put == null)
            {
                MessageBox.Show("Error Put is null");
                return;
            }
            ValidateLenght(Put);
            Put = new DataTable().Compute(CalculateTB.Text, null).ToString();
            CalculateTB.Text = Put;
            Put = Math.Cos(Convert.ToDouble(CalculateTB.Text)).ToString();
            CalculateTB.Text = Put;
        }

        private void TanB_Click(object sender, RoutedEventArgs e)
        {
            if (Put == null)
            {
                MessageBox.Show("Error Put is null");
                return;
            }
            ValidateLenght(Put);
            Put = new DataTable().Compute(CalculateTB.Text, null).ToString();
            CalculateTB.Text = Put;
            Put = Math.Tan(Convert.ToDouble(CalculateTB.Text)).ToString();
            CalculateTB.Text = Put;
        }

        private void ACB_Click(object sender, RoutedEventArgs e)
        {
            Put = null;
            CalculateTB.Text = Put;
        }
        private static void UpdateCalculate()
        {
            if(Clear == true)
            {
                Put = null;
            }
        }
        private static void ValidateLenght(string x)
        {
            if(x.Length > 25)
            {
                MessageBox.Show("Allo ya tak mnogo считать ne umeyu");
                return;
            }
        }
    }
}
