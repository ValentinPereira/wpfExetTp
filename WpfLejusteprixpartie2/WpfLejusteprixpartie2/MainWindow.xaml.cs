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

namespace WpfLejusteprixpartie2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int randomNumber = new Random().Next(1, 51);
        int userTry = 0;
        int userEntry = 1;
        public MainWindow()
        {
            InitializeComponent();
            ChooseNumber.Text = "" + userEntry;
        }

        private void MoreButton(object sender, RoutedEventArgs e)
        {
            if (userEntry == 50)
            {
               error.Text = ("Vous ne pouvez pas aller au-dessus du chiffre 50");
            }
            else
            {
                userEntry++;
                ChooseNumber.Text = "" + userEntry;
            }
        }
        private void LessButton(object sender, RoutedEventArgs e)
        {
            if (userEntry == 1)
            {
               error.Text = ("Veuillez entrer un nombre supérieur à 1");
            }
            else
            {
                userEntry--;
                ChooseNumber.Text = "" + userEntry;
            }
        }

        private void ValidateButton(object sender, RoutedEventArgs e)
        {
            if (userEntry == randomNumber)
            {
                error.Text = ("Bravo c'est le bon chiffre !. Vous avez essayé : " + userTry + "fois.");
            }
            else if (userEntry < randomNumber)
            {
                error.Text = ("Le nombre à deviner est plus grand retentez votre chance");
                userTry++;
            }
            else if (userEntry > randomNumber)
            {
                error.Text = ("Le nombre à deviner est plus petit retentez votre chance");
                userTry++;
            }
        }
    }
}
