using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ODD_Project
{
    //enum GameGenre
    //{
    //    RPG = 0,
    //    Shooter = 0,
    //    Sport = 0
    //}
    public partial class MainWindow : Window
    {

        GamesStoreData db = new GamesStoreData();

        //Creating lists
        List<Games> games = new List<Games>();
        List<Games> selectedGame = new List<Games>();

        ObservableCollection<Games> allGames;
        ObservableCollection<Games> filteredGame;


        int selectedRPG, selectedShooter, selectedSport;




        public MainWindow()
        {
     
            InitializeComponent();
        }



   

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            allGames = new ObservableCollection<Games>();
            filteredGame = new ObservableCollection<Games>();

            //Creating values for the list

            //(string newName, DateTime newReleaseDate, decimal newCost, string newDesc, Genre newGenre, reivew)
            //Games G1 = new Games("Call of Duty", new DateTime(2019, 06, 03), 60, "Live in a war", 1, "One of the best shooters out there, a staple for shooter fans. ");
            //Games G2 = new Games("Fifa", new DateTime(2011, 01, 02), 50m, "Play football", 2, "The most popular sports game to date. Selling over 20million copies yearly");
            //Games G3 = new Games("Gears of War", new DateTime(2017, 12, 12), 60, "Chainsaw your enemies", 3, "One of xbox's famous shooter exclusives. A compelling and exciting story with a unique multiplayer");
            //Games G4 = new Games("Fable", new DateTime(2015, 03, 06), 60, "Become a Hero", 4, "The one and only xbox RPG exclusive, scoring 10's across the board");
            //Games G5 = new Games("The Witcher", new DateTime(2000, 11, 07), 50m, "Slay beasts", 5, "Mediocre");
            //Games G6 = new Games("Last of us", new DateTime(2014, 07, 08), 40, "Survive", 6, "Game of the decade for many, this game will have you in tears");
            //Games G7 = new Games("God of War", new DateTime(2019, 02, 01), 40, "Be a God", 7, "Enagaging story with compelling combat, perfect combination of the two");
            //Games G8 = new Games("Spiderman", new DateTime(2018, 07, 10), 50, "Protect the weak", 8, "One of few spiderman games that does spiderman right");
            //Games G9 = new Games("Bloodborne", new DateTime(2016, 12, 02), 60, "Blood", 9, "A RPG horror that takes creative bosses to a next level");
            //Games G10 = new Games("NBA", new DateTime(2016, 12, 02), 60, "Play the game", 10, "A staple for any basketball fan");
            //Games G11 = new Games("Wii Sports", new DateTime(2016, 12, 02), 50, "Keep fit", 11, "The best selling game on the wii, it dominationed the market for families");
            //Games G12 = new Games("NHFL", new DateTime(2016, 12, 02), 40, "Just like real life", 12, "A great game hockey game with great customization");
            //Games G13 = new Games("Dishonoured", new DateTime(2016, 09, 1), 40, "Get revenge", 13, "A thrilling shooter with a very intriging story");
            //Games G14 = new Games("Wolfenstein", new DateTime(2012, 01, 08), 60, "Be a nazi", 14, "Takes a completely different take of the shooter genre story wise that will shock players");
            //Games G15 = new Games("Dark Souls", new DateTime(2011, 06, 04), 50, "You died", 15, "You died");

            //Genre g1 = new Genre() { ID = 1, Name = "Shooter" };
            //Games G1 = new Games("Call of Duty", new DateTime(2019, 06, 03), 60m, 1, 1, "5/5 ");
            //Games G2 = new Games("Bioshock", new DateTime(2011, 01, 02), 20m, 2, 1, "4/5");
            //Games G3 = new Games("Gears of War", new DateTime(2017, 12, 12), 20m, 3, 1, "3/5");
            //Games G4 = new Games("Wolfenstein", new DateTime(2017, 12, 12), 30m, 4, 1, "3/5");
            //Games G5 = new Games("Overwatch", new DateTime(2017, 12, 12), 30m, 5, 1, "3/5");

            //Genre g2 = new Genre() { ID = 2, Name = "Sport" };
            //Games G6 = new Games("NFHL", new DateTime(2019, 06, 03), 40m, 6, 2, "5/5 ");
            //Games G7 = new Games("Fifa", new DateTime(2011, 01, 02), 60m, 7, 2, "4/5");
            //Games G8 = new Games("NBA", new DateTime(2017, 12, 12), 40m, 8, 2, "3/5");
            //Games G9 = new Games("Wii Sports", new DateTime(2017, 12, 12), 20m, 9, 2, "3/5");

            //Genre g3 = new Genre() { ID = 3, Name = "RPG" };
            //Games G10 = new Games("Bloodborne", new DateTime(2019, 06, 03), 30m, 10, 3, "5/5 ");
            //Games G11 = new Games("Skyrim", new DateTime(2011, 01, 02), 20m, 11, 3, "4/5");
            //Games G12 = new Games("Fable", new DateTime(2017, 12, 12), 20m, 12, 3, "3/5");
            //Games G13 = new Games("Dark Souls", new DateTime(2017, 12, 12), 20m, 13, 3, "3/5");
            //Games G14 = new Games("Shadow of War", new DateTime(2017, 12, 12), 40m, 14, 3, "3/5");



            ////add to list
            //games.Add(G1);
            //games.Add(G2);
            //games.Add(G3);
            //games.Add(G4);
            //games.Add(G5);
            //games.Add(G6);
            //games.Add(G7);
            //games.Add(G8);
            //games.Add(G9);
            //games.Add(G10);
            //games.Add(G11);
            //games.Add(G12);
            //games.Add(G13);
            //games.Add(G14);

            //not working
            //var query = from g in db.Games
            //            group g by g.Genre into g
            //            orderby g.Count() descending
            //            select new
            //            {
            //                Game = g.Key,
            //                Count = g.Count()
            //            };


            ////shows all shooter games with their name and reivew
            //var query = from g in db.Games
            //            where g.GenID == 3
            //            orderby g.Name
            //            select new
            //            {
            //                Game = g.Name,
            //                Review = g.Review
            //            };




            //shows all games that cost 30 or under
            //var query = from g in db.Games
            //            orderby g.Cost
            //            where g.Cost <= 30
            //            select new
            //            {
            //                GameName = g.Name,
            //                Cost = g.Cost,

            //            };

            ////Sorting by cost high to low
            var query = from g in db.Games
                        orderby g.Cost descending
                        select new
                        {

                            g.Name,
                            g.Cost
                        };

            ////returns the games with the gen id of 6
            //var query = (from detail in db.Games
            //             where detail.GenID == 6
            //             select detail);



            //var results = query.ToList();

            //Ex1DgDisplay.ItemsSource = results;



            //datagames.ItemsSource = query.ToList().Distinct();

            //datagames.ItemsSource = query.ToList();

            ////display in listbox
            //lbxGames.ItemsSource = db.Games;//tell listbox that the source of items is the list activitie
            //datagames.ItemsSource = db.Games.

            //combo box
            //ComboBoxGenres.ItemsSource = new string[] { "RPG", "Shooter", "Sport" };
            //ComboBoxGenres.SelectedIndex = 0;


        }

        private void BtnViewReview_Click(object sender, RoutedEventArgs e)
        {
            //figure out what item is selected
            Games selectedGame  = lbxGames.SelectedItem as Games;
            //if selected activity is not null executes code
            if (selectedGame != null)
            {
                ////move item from left to right
                //activities.Remove(selectedActivity);
                games.Add(selectedGame);

                //shows description when item is selected
                lableShowGameReview.Text = "Review:   " + selectedGame.Review;

                //method to refresh screen
                RefreshScreen();

                ////add to total cost
                //total += selectedActivity.TotalCost;
                //TBLtotalcost.Text = total.ToString();
            }
            //if nothing is selected error message displays
            else
            {
                ErrorMessage();
            }



        }

        private void ComboBoxGenres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var games in selectedGame)
            {
                allGames.Add(games);
            }

            selectedGame.Clear();

            selectedRPG = 0;
            selectedShooter = 0;
            selectedSport = 0;
            RefreshScreen();
        }

        private void cmbGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BuyHighToLowbtn_Click(object sender, RoutedEventArgs e)
        {

            var query = from g in db.Games
                        orderby g.Cost descending
                        select new
                        {

                            g.Name,
                            g.Cost
                        };

            Buydg.ItemsSource = query.ToList();

        }

        private void BuyLowToHighbtn_Click(object sender, RoutedEventArgs e)
        {

            var query = from g in db.Games
                        orderby g.Cost ascending
                        select new
                        {

                            g.Name,
                            g.Cost
                        };

            Buydg.ItemsSource = query.ToList();

        }

        private void Buybtn_Click(object sender, RoutedEventArgs e)
        {
            string PurchaseMessage = "The game you have selected has been ordered";
            BuyPurchased.Text = PurchaseMessage;          
        }

        private void BuyShooterbtn_Click(object sender, RoutedEventArgs e)
        {

            //shows all shooter games with their name and reivew
            var query = from g in db.Games
                        where g.GenID == 1
                        orderby g.Name
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Cost                    
              

                        };

            Buydg.ItemsSource = query.ToList();

        }



        private void BuySportsbtn_Click(object sender, RoutedEventArgs e)
        {

            //shows all shooter games with their name and reivew
            var query = from g in db.Games
                        where g.GenID == 2
                        orderby g.Name
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Cost
                        
                        };

            Buydg.ItemsSource = query.ToList();

        }

        private void BuyRPGbtn_Click(object sender, RoutedEventArgs e)
        {

            //shows all shooter games with their name and reivew
            var query = from g in db.Games
                        where g.GenID == 3
                        orderby g.Name
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Cost
                    
                        };

            Buydg.ItemsSource = query.ToList();

        }





        private void ReivewPoorbtm_Click(object sender, RoutedEventArgs e)
        {
            //shows all shooter games with their name and reivew
            var query = from g in db.Games
                        where g.Review == "6/10"
                        orderby g.Name
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Review

                        };

            Reviewdg.ItemsSource = query.ToList();


        }

        private void ReviewAveragebtn_Click(object sender, RoutedEventArgs e)
        {
            var query = from g in db.Games
                        where g.Review == "7/10"
                        orderby g.Name
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Review

                        };

            Reviewdg.ItemsSource = query.ToList();

        }

        private void ReviewGoodbtn_Click(object sender, RoutedEventArgs e)
        {
            var query = from g in db.Games
                        where g.Review == "8/10"
                        orderby g.Name
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Review

                        };

            Reviewdg.ItemsSource = query.ToList();

        }



        private void ReviewGreatbtn_Click(object sender, RoutedEventArgs e)
        {
            var query = from g in db.Games
                        where g.Review == "9/10"
                        orderby g.Name
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Review

                        };

            Reviewdg.ItemsSource = query.ToList();

        }

        private void ReviewAmazingbtn_Click(object sender, RoutedEventArgs e)
        {
            var query = from g in db.Games
                        where g.Review == "10/10"
                        orderby g.Name
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Review

                        };

            Reviewdg.ItemsSource = query.ToList();

        }

        private void ReviewAllbtn_Click(object sender, RoutedEventArgs e)
        {
            var query = from g in db.Games               
                        orderby g.Review descending
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Review

                        };

            Reviewdg.ItemsSource = query.ToList();

        }

        private void RefreshScreen()
        {
            //Makes list box null and then fills it with activities again,
            lbxGames.ItemsSource = null;
            lbxGames.ItemsSource = games;

            //same as above but with a different list box, this is to prevent overlapping
            //lableShowGameReview.Text = null;
            //LBXselectedactivities.ItemsSource = selectedActivities;

    
        }

        private void ErrorMessage()
        {
            //if nothing is selected an error message will display
            //Creating an error message and giving the text block it's value (if the if statement is true)
            string errorMessage = "ERROR: Nothing has been selected";
            lableShowGameReview.Text = errorMessage;

        }



    }
}
