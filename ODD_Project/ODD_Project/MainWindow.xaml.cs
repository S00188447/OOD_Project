﻿using System;
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
            Games G1 = new Games("Call of Duty", new DateTime(2019, 06, 03), 60, "Live in a war", Genre.RPG, "One of the best shooters out there, a staple for shooter fans. ");
            Games G2 = new Games("Fifa", new DateTime(2011, 01, 02), 50m, "Play football", Genre.Sport, "The most popular sports game to date. Selling over 20million copies yearly");
            Games G3 = new Games("Gears of War", new DateTime(2017, 12, 12), 60, "Chainsaw your enemies", Genre.Shooter, "One of xbox's famous shooter exclusives. A compelling and exciting story with a unique multiplayer");
            Games G4 = new Games("Fable", new DateTime(2015, 03, 06), 60, "Become a Hero", Genre.RPG, "The one and only xbox RPG exclusive, scoring 10's across the board");
            Games G5 = new Games("The Witcher", new DateTime(2000, 11, 07), 50m, "Slay beasts", Genre.RPG, "Mediocre");
            Games G6 = new Games("Last of us", new DateTime(2014, 07, 08), 40, "Survive", Genre.Shooter, "Game of the decade for many, this game will have you in tears");
            Games G7 = new Games("God of War", new DateTime(2019, 02, 01), 40, "Be a God", Genre.RPG, "Enagaging story with compelling combat, perfect combination of the two");
            Games G8 = new Games("Spiderman", new DateTime(2018, 07, 10), 50, "Protect the weak", Genre.RPG, "One of few spiderman games that does spiderman right");
            Games G9 = new Games("Bloodborne", new DateTime(2016, 12, 02), 60, "Blood", Genre.RPG, "A RPG horror that takes creative bosses to a next level");
            Games G10 = new Games("NBA", new DateTime(2016, 12, 02), 60, "Play the game", Genre.Sport, "A staple for any basketball fan");
            Games G11 = new Games("Wii Sports", new DateTime(2016, 12, 02), 50, "Keep fit", Genre.Sport, "The best selling game on the wii, it dominationed the market for families");
            Games G12 = new Games("NHFL", new DateTime(2016, 12, 02), 40, "Just like real life", Genre.Sport, "A great game hockey game with great customization");
            Games G13 = new Games("Dishonoured", new DateTime(2016, 09, 1), 40, "Get revenge", Genre.Shooter, "A thrilling shooter with a very intriging story");
            Games G14 = new Games("Wolfenstein", new DateTime(2012, 01, 08), 60, "Be a nazi", Genre.Shooter, "Takes a completely different take of the shooter genre story wise that will shock players");
            Games G15 = new Games("Dark Souls", new DateTime(2011, 06, 04), 50, "You died", Genre.RPG, "You died");



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
            games.Add(G13);
            games.Add(G14);
            games.Add(G15);

            //display in listbox
            lbxGames.ItemsSource = games; //tell listbox that the source of items is the list activitie

            //combo box
            ComboBoxGenres.ItemsSource = new string[] { "RPG", "Shooter", "Sport" };
            ComboBoxGenres.SelectedIndex = 0;
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
