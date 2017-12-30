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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculation MyCalculation = new Calculation();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            int output;
            Int32.TryParse(((Button)sender).Content as string, out output);

            if (MyCalculation.FirstNumber == null)
            {
                MyCalculation.FirstNumber = output;   
            }
            else
            {
                MyCalculation.SecondNumber = output;
            }

            TextBoxResult.Text = TextBoxResult.Text + " " + output;
        }

        private void ButtonOperation_Click(object sender, RoutedEventArgs e)
        {
            MyCalculation.Operation = ((Button)sender).Content as string;

            TextBoxResult.Text = $"{TextBoxResult.Text} {MyCalculation.Operation}";
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            MyCalculation.FirstNumber = null;
            MyCalculation.SecondNumber = null;
            MyCalculation.Operation = null;
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            switch (MyCalculation.Operation)
            {
                case "/":
                    TextBoxResult.Text = ((int)MyCalculation.FirstNumber / (int)MyCalculation.SecondNumber).ToString();
                    break;
                case "*":
                    TextBoxResult.Text = ((int)MyCalculation.FirstNumber * (int)MyCalculation.SecondNumber).ToString();
                    break;
                case "-":
                    TextBoxResult.Text = ((int)MyCalculation.FirstNumber - (int)MyCalculation.SecondNumber).ToString();
                    break;
                case "+":
                    TextBoxResult.Text = ((int)MyCalculation.FirstNumber + (int)MyCalculation.SecondNumber).ToString();
                    break;
            }
        }
    }
}
