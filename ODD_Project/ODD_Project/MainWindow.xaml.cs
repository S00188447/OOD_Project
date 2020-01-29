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

namespace ODD_Project
{
    enum GameGenre
    {
        RPG = 0,
        Shooter = 0,
        Sport = 0
    }
    public partial class MainWindow : Window
    {

        //Creating lists
        List<Games> games = new List<Games>();
        List<Games> selectedGame = new List<Games>();
        //List<Games> filteredactivities = new List<Games>();
        //variable
        //decimal total = 0;


        public MainWindow()
        {
     
            InitializeComponent();
        }



   

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Creating values for the list

            //(string newName, DateTime newReleaseDate, decimal newCost, string newDesc, Genre newGenre, reivew)
            Games G1 = new Games("Call of Duty", new DateTime(2019, 06, 03), 30m, "A trek to the mountains", Genre.RPG, "One of the best shooters out there, a staple for shooter fans. ");
            Games G2 = new Games("Fifa", new DateTime(2011, 01, 02), 50m, "Mountain biking, all equipment provided", Genre.Sport, "The most popular sports game to date. Selling over 20million copies yearly");
            Games G3 = new Games("Gears of War", new DateTime(2017, 12, 12), 70m, "Up to 1000m high", Genre.Shooter, "One of xbox's famous shooter exclusives. A compelling and exciting story with a unique multiplayer");
            Games G4 = new Games("Fable", new DateTime(2015, 03, 06), 70m, "Travel to an island picnic", Genre.RPG, "The one and only xbox RPG exclusive, scoring 10's across the board");
            Games G5 = new Games("The Witcher", new DateTime(2000, 11, 07), 50m, "2 hour long surd", Genre.RPG, "Mediocre");
            Games G6 = new Games("Last of us", new DateTime(2014, 07, 08), 80m, "Boat needed", Genre.Shooter, "Game of the decade for many, this game will have you in tears");
            Games G7 = new Games("God of War", new DateTime(2019, 02, 01), 200m, "May be dangerous", Genre.RPG, "Enagaging story with compelling combat, perfect combination of the two");
            Games G8 = new Games("Spiderman", new DateTime(2018, 07, 10), 300m, "Totally safe", Genre.RPG, "One of few spiderman games that does spiderman right");
            Games G9 = new Games("Bloodborne", new DateTime(2016, 12, 02), 1000m, "For the rich", Genre.RPG, "A RPG horror that takes creative bosses to a next level");
            Games G10 = new Games("NBA", new DateTime(2016, 12, 02), 1000m, "For the rich", Genre.Sport, "A staple for any basketball fan");
            Games G11 = new Games("Wii Sports", new DateTime(2016, 12, 02), 1000m, "For the rich", Genre.Sport, "The best selling game on the wii, it dominationed the market for families");
            Games G12 = new Games("NHFL", new DateTime(2016, 12, 02), 1000m, "For the rich", Genre.Sport, "A great game hockey game with great customization");
            Games G13 = new Games("Dishonoured", new DateTime(2016, 12, 02), 1000m, "For the rich", Genre.Shooter, "A thrilling shooter with a very intriging story");
            Games G14 = new Games("Wolfenstein", new DateTime(2016, 12, 02), 1000m, "For the rich", Genre.Shooter, "Takes a completely different take of the shooter genre story wise that will shock players");
            Games G15 = new Games("Dark Souls", new DateTime(2016, 12, 02), 1000m, "For the rich", Genre.RPG, "You died");



            //add to list
            games.Add(G1);
            games.Add(G2);
            games.Add(G3);
            games.Add(G4);
            games.Add(G5);
            games.Add(G6);
            games.Add(G7);
            games.Add(G8);
            games.Add(G9);
            games.Add(G10);
            games.Add(G11);
            games.Add(G12);

            //display in listbox
            lbxGames.ItemsSource = games; //tell listbox that the source of items is the list activitie
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
            RefreshScreen();


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
