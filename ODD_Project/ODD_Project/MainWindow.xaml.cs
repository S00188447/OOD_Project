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
    //Github link:
    // https://github.com/S00188447/OOD_Project

    public partial class MainWindow : Window
    {

        GamesStoreData db = new GamesStoreData();

        //Creating lists
        List<Games> games = new List<Games>();

        List<Games> selectedGame = new List<Games>();

        ObservableCollection<Games> allGames;
        ObservableCollection<Games> filteredGame;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Youtubers> youtubers = new List<Youtubers>();
            allGames = new ObservableCollection<Games>();
            filteredGame = new ObservableCollection<Games>();

            //Creating values for the list

            //(string newName, DateTime newReleaseDate, decimal newCost, string newDesc, Genre newGenre, reivew)
            Youtubers Y1 = new Youtubers() { YoutuberName = "ItsNick", GameCovered = "Call of Duty", ImageLogo = "/Images/Cod.jpg" };
            Youtubers Y2 = new Youtubers() { YoutuberName = "FightinCowboy", GameCovered = "Dark Souls", ImageLogo = "/Images/DarkSouls.jpg" };
            Youtubers Y3 = new Youtubers() { YoutuberName = "Overwatch DAILY", GameCovered = "Overwatch", ImageLogo = "/Images/Overwatch.jpg" };
            Youtubers Y4 = new Youtubers() { YoutuberName = "RTGame", GameCovered = "Fable", ImageLogo = "/Images/Fable.jpg" };
            Youtubers Y5 = new Youtubers() { YoutuberName = "TheRadBrad", GameCovered = "Bloodborne", ImageLogo = "/Images/Bloodborne.jpg" };
            Youtubers Y6 = new Youtubers() { YoutuberName = "MadGam3r", GameCovered = "Fifa", ImageLogo = "/Images/Fifa.jpg" };
            Youtubers Y7 = new Youtubers() { YoutuberName = "TheGamerKratos", GameCovered = "God of War", ImageLogo = "/Images/GodofWar.jpg" };

            //add to list

            youtubers.Add(Y1);
            youtubers.Add(Y2);
            youtubers.Add(Y3);
            youtubers.Add(Y4);
            youtubers.Add(Y5);
            youtubers.Add(Y6);
            youtubers.Add(Y7);

            Youtuberslbx.ItemsSource = youtubers;
        }






        private void BuyHighToLowbtn_Click(object sender, RoutedEventArgs e)
        {

            //sorts the games by cost from high to low
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

            //sorts the games by cost from low to high
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
            //displays this message if a user buys a game
            string PurchaseMessage = "The game you have selected has been ordered";
            BuyPurchased.Text = PurchaseMessage;          
        }

        private void BuyShooterbtn_Click(object sender, RoutedEventArgs e)
        {

            //shows all shooter games with their name and cost
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

            //shows all sports games with their name and cost
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

            //shows all RPG games with their name and cost
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
            //shows all games that got a poor rating
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
            //shows all games that got a average rating
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
            //shows all games that got a good rating
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
            //shows all games that got a great rating
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
            //shows all games that got a amazing rating
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
            //shows all games
            var query = from g in db.Games               
                        orderby g.Review descending
                        select new
                        {
                            Game = g.Name,
                            Cost = g.Review

                        };

            Reviewdg.ItemsSource = query.ToList();

        }
    }
}
