using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "Crvena Zvezda", Team2 = "Partizan", Score1 = 4, Score2 = 0, Completion = 66 });
            matches.Add(new Match() { Team1 = "Arsenal", Team2 = "Totenhem", Score1 = 3, Score2 = 1, Completion = 77 });
            matches.Add(new Match() { Team1 = "Juventus", Team2 = "Atletiko Madrid", Score1 = 0, Score2 = 0, Completion = 10 });
            matches.Add(new Match() { Team1 = "PSG", Team2 = "Manchester Unated", Score1 = 1, Score2 = 2, Completion = 46 });
            LbMatches.ItemsSource = matches;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(LbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Matches: " 
                    + (LbMatches.SelectedItem as Match).Team1 + " " +
                    (LbMatches.SelectedItem as Match).Score1 + " " +
                    (LbMatches.SelectedItem as Match).Score2 + " " +
                    (LbMatches.SelectedItem as Match).Team2 + " " + (LbMatches.SelectedItem as Match).Completion + " " + "minute");

            }
        }
    }
}
