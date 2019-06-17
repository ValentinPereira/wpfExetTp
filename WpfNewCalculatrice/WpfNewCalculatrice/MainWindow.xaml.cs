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

namespace WpfNewCalculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1 = 0; // Création d'une variable number1 qui a pour valeur 0 et contient le type long
        double number2 = 0; // "" number2.
        string operation = ""; //Création de la variable opération de type string.
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OneButton_Click(object sender, RoutedEventArgs e) //Création de la méthode boutton1.
        {
            if (operation == "") // Quand la variable opération est activée par l'utilisateur qui tape un calcul
            {
                number1 = (number1 * 10) + 1;  // le chiffre 1 + le second chiffre
                resultNumber.Text = number1.ToString(); //Affiche le numéro
            }
            else
            {
                number2 = (number2 * 10) + 1; // le chiffre 2 + 1
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

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                resultNumber.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
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
            operation = "+"; // Demande l'opération d'un addition avec la méthode moreclick.
            resultNumber.Text = "0"; // Remet à 0
        }

        private void MultiButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            resultNumber.Text = "0";
        }

        private void LessButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            resultNumber.Text = "0";
        }
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            resultNumber.Text = "0";
        }
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            switch(operation) // Si la méthode equal est utilisée on calcul selon le bouton choisie le nombre1 et le nombre2
            {
                case "+":
                    resultNumber.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    resultNumber.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    resultNumber.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    if(number2 == 0)
                    {
                        MessageBox.Show("division par 0 impossible");
                    }
                    resultNumber.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
          number1 = 0; // La méthode reset remet la variable number1 et 2 plus le résultat à 0
          number2 = 0;
          operation = "";
          resultNumber.Text = "0";
        }
    }
}   
