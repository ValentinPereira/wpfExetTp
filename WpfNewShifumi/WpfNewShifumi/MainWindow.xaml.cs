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

namespace WpfNewShifumi
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string userChoice = ""; // Déclaration de mes variables et de leurs valeurs
        string paper = "papier";
        string stone = "pierre";
        string chisel = "ciseau";
        int userVictory = 0; // On commence à 0 pour indiquer que l'on commence une nouvelle partie
        int userDefeat = 0;
        int userSame = 0;
        int totalGame = 0;

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            string resultat = resultTextBlock.Text;  //Pour afficher mes résultats dans mes textblocs
            string stats = statsTextBlock.Text; // Mes stats
            string percents = percentsTextBlock.Text; // Mon pourcentage de victoires
            Random rnd = new Random(); // Génération d'une valeur prédéfinie au hasard
            string[] iaChoices = { "pierre", "feuille", "ciseau" };
            int choiceComputer = rnd.Next(iaChoices.Length); // Le choiceComputeur correspond à l'index de mon tableau

            if (userChoice == "") // Si l'utilisateur ne rentre aucunes données
            {
                MessageBox.Show("Erreur, merci de sélectionner un des trois éléments ci-dessus");
            }
            else
            {
                if (userChoice == paper && iaChoices[choiceComputer] == stone || userChoice == stone && iaChoices[choiceComputer] == chisel || userChoice == chisel && iaChoices[choiceComputer] == paper)
                {
                    resultTextBlock.Text = "Bravo tu as gagné avec " + userChoice + " et l' ia " + iaChoices[choiceComputer];
                    userVictory++;
                    totalGame++;
                }
                else if (userChoice == paper && iaChoices[choiceComputer] == paper || userChoice == stone && iaChoices[choiceComputer] == stone || userChoice == chisel && iaChoices[choiceComputer] == chisel)
                {
                    resultTextBlock.Text = "Egalité, tu as choisis : " + userChoice + " , et l' ia : " + iaChoices[choiceComputer];
                    userSame++; // Ajouter les égalités pour les compter
                    totalGame++;
                }
                else
                {
                    resultTextBlock.Text = "Perdu avec " + userChoice + "l'ia a choisit " + iaChoices[choiceComputer];
                    userDefeat++;
                    totalGame++;
                }
                statsTextBlock.Text = "Nombre de victoire(s) : " + userVictory + " , Nombre de défaite(s) : " + userDefeat + " , Nombre d'égalité(s) : " + userSame + ".";
                percentsTextBlock.Text = "Pourcentage de victoire(s) : " + 100 * userVictory / totalGame + " %";
            }
        }

        private void ButtonRock_Click(object sender, RoutedEventArgs e) // Méthode pour enregistrer la valeur au clique de l'élément sélectionné
        {
            userChoice = stone; // Lors du clique sur la pierre, la valeur sera stockée dans la variable userChoice.
        }

        private void ButtonPaper_Click(object sender, RoutedEventArgs e)
        {
            userChoice = paper;
        }

        private void ButtonChisel_Click(object sender, RoutedEventArgs e)
        {
            userChoice = chisel;
        }

        private void BtnReplayGame_Click(object sender, RoutedEventArgs e)
        {
            buttonStone.IsEnabled = true;
            buttonPaper.IsEnabled = true;
            buttonChisel.IsEnabled = true;
            btnPlay.Visibility = Visibility.Visible;
            btnReplayGame.Visibility = Visibility.Hidden;
        }
    }
}
