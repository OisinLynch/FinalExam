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

namespace FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create Lists
        List<Player> allPlayers;
        List<Player> selectedPlayers = new List<Player>();
        //Create Random
        Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();

            string[] formationSelect = { "4-4-2", "4-3-3", "4-5-1" };
            cmbFromation.ItemsSource = formationSelect;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            allPlayers = GetPlayers();
            lbxPlayers.ItemsSource = allPlayers;
        }

        private List<Player> GetPlayers()
        {
            List<Player> allPlayers = new List<Player>();

            //Create Players
            Player p1 = new Player()
            {
                FirstName = "Adam",
                Surname = "Brennan",
                PreferedPosition = Position.Goakeeper,
                DateOfBirth = new DateTime(1992, 06, 01),
                Age = 27
            };

            Player p2 = new Player()
            {
                FirstName = "Amelia",
                Surname = "Byrne",
                PreferedPosition = Position.Goakeeper,
                DateOfBirth = new DateTime(1993, 04, 25),
                Age = 26
            };

            Player p3 = new Player()
            {
                FirstName = "Ava",
                Surname = "Daly",
                PreferedPosition = Position.Defender,
                DateOfBirth = new DateTime(1991, 02, 24),
                Age = 28
            };

            Player p4 = new Player()
            {
                FirstName = "Chloe",
                Surname = "Doyle",
                PreferedPosition = Position.Defender,
                DateOfBirth = new DateTime(1992, 05, 15),
                Age = 27
            };

            Player p5 = new Player()
            {
                FirstName = "Conor",
                Surname = "Dunne",
                PreferedPosition = Position.Defender,
                DateOfBirth = new DateTime(1999, 06, 27),
                Age = 20
            };

            Player p6 = new Player()
            {
                FirstName = "Daniel",
                Surname = "Dunne",
                PreferedPosition = Position.Defender,
                DateOfBirth = new DateTime(1998, 10, 22),
                Age = 21
            };

            Player p7 = new Player()
            {
                FirstName = "Emily",
                Surname = "Fitzgerald",
                PreferedPosition = Position.Defender,
                DateOfBirth = new DateTime(1997, 01, 10),
                Age = 22
            };

            Player p8 = new Player()
            {
                FirstName = "Emma",
                Surname = "Kavanagh",
                PreferedPosition = Position.Defender,
                DateOfBirth = new DateTime(1999, 03, 09),
                Age = 20
            };

            Player p9 = new Player()
            {
                FirstName = "Grace",
                Surname = "Kelly",
                PreferedPosition = Position.Midfielder,
                DateOfBirth = new DateTime(1998, 03, 02),
                Age = 21
            };

            Player p10 = new Player()
            {
                FirstName = "Hannah",
                Surname = "McCarthy",
                PreferedPosition = Position.Midfielder,
                DateOfBirth = new DateTime(1996, 01, 20),
                Age = 23
            };

            Player p11 = new Player()
            {
                FirstName = "Harry",
                Surname = "Lynch",
                PreferedPosition = Position.Midfielder,
                DateOfBirth = new DateTime(1998, 06, 08),
                Age = 21
            };

            Player p12 = new Player()
            {
                FirstName = "Jack",
                Surname = "Murphy",
                PreferedPosition = Position.Midfielder,
                DateOfBirth = new DateTime(1995, 02, 02),
                Age = 24
            };

            Player p13 = new Player()
            {
                FirstName = "James",
                Surname = "McDonagh",
                PreferedPosition = Position.Midfielder,
                DateOfBirth = new DateTime(1995, 08, 14),
                Age = 24
            };

            Player p14 = new Player()
            {
                FirstName = "Lucy",
                Surname = "Nolan",
                PreferedPosition = Position.Midfielder,
                DateOfBirth = new DateTime(1994, 02, 18),
                Age = 25
            };

            Player p15 = new Player()
            {
                FirstName = "Luke",
                Surname = "O'Brien",
                PreferedPosition = Position.Forward,
                DateOfBirth = new DateTime(1999, 11, 06),
                Age = 20
            };

            Player p16 = new Player()
            {
                FirstName = "Mia",
                Surname = "O'Connor",
                PreferedPosition = Position.Forward,
                DateOfBirth = new DateTime(1994, 10, 08),
                Age = 25
            };

            Player p17 = new Player()
            {
                FirstName = "Michael",
                Surname = "O'Neill",
                PreferedPosition = Position.Forward,
                DateOfBirth = new DateTime(1998, 05, 01),
                Age = 21
            };

            Player p18 = new Player()
            {
                FirstName = "Noah",
                Surname = "O'Reilly",
                PreferedPosition = Position.Forward,
                DateOfBirth = new DateTime(1999, 12, 12),
                Age = 20
            };

            //Add players to the list
            allPlayers.Add(p1);
            allPlayers.Add(p2);

            allPlayers.Add(p3);
            allPlayers.Add(p4);
            allPlayers.Add(p5);
            allPlayers.Add(p6);
            allPlayers.Add(p7);
            allPlayers.Add(p8);

            allPlayers.Add(p9);
            allPlayers.Add(p10);
            allPlayers.Add(p11);
            allPlayers.Add(p12);
            allPlayers.Add(p13);
            allPlayers.Add(p14);

            allPlayers.Add(p15);
            allPlayers.Add(p16);
            allPlayers.Add(p17);
            allPlayers.Add(p18);

            //Sort by Position
            allPlayers.Sort();

            return allPlayers;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Find what Player is selected 
            Player selectedPlayer = lbxPlayers.SelectedItem as Player;

            //Null check
            if (selectedPlayer != null)
            {
                //Move Player from PlayerSelect box to SelectedPlayers box
                allPlayers.Remove(selectedPlayer); 
                selectedPlayers.Add(selectedPlayer);

                //Sort the seleced Players by Position
                selectedPlayers.Sort();

                //Refreash screen
                lbxPlayers.ItemsSource = null;
                lbxPlayers.ItemsSource = allPlayers;

                lbxSelectedPlayers.ItemsSource = null;
                lbxSelectedPlayers.ItemsSource = selectedPlayers;
            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Find what Player is selected 
            Player selectedPlayer = lbxSelectedPlayers.SelectedItem as Player;

            //Null check
            if (selectedPlayer != null)
            {
                //Move activity from ActivitySelect box to SelectedActivity box
                allPlayers.Add(selectedPlayer);
                selectedPlayers.Remove(selectedPlayer);

                //Sort the seleced Players by Position
                allPlayers.Sort();

                //Refreash screen
                lbxPlayers.ItemsSource = null;
                lbxPlayers.ItemsSource = allPlayers;

                lbxSelectedPlayers.ItemsSource = null;
                lbxSelectedPlayers.ItemsSource = selectedPlayers;
            }

            
        }

        //Methods
        //private Player GetRandomPlayer()
        //{
        //    //Get random First Name
        //    string[] firstNames = {
        //        "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
        //        "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
        //        "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};
        //    int randomNumber = rng.Next(0, 20); //0-20
        //    string firstName = firstNames[randomNumber];

        //    //Get random Surname
        //    string[] lastNames = {
        //        "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
        //        "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
        //        "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh" };
        //    randomNumber = rng.Next(0, 20); //0-20
        //    string surname = lastNames[randomNumber];

        //    //Get random Date in the last 30 days
        //    randomNumber = rng.Next(0, 31); // 0 - 30
        //    DateTime randomDate = DateTime.Now.AddDays(-randomNumber); //Give a date in the last 30 days

        //    //Create a Player object with random info
        //    //Player p1 = new Player(firstName, surname, randomDate);

        //    //Return random object
        //    //return p1;
        //}
    }
}
