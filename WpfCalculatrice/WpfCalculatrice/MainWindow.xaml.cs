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

namespace WpfCalculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                resultNumber.Text = number2.ToString();
            }
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                resultNumber.Text = number2.ToString();
            }
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                resultNumber.Text = number2.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4    ;
                resultNumber.Text = number2.ToString();
            }
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                resultNumber.Text = number2.ToString();
            }
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                resultNumber.Text = number2.ToString();
            }
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                resultNumber.Text = number2.ToString();
            }
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                resultNumber.Text = number2.ToString();
            }
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                resultNumber.Text = number2.ToString();
            }
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                resultNumber.Text = number2.ToString();
            }
        }

        private void MoreButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            resultNumber.Text = "0";
        }

        private void MultiButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LessButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}   
