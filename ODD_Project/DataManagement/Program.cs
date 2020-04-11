using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODD_Project;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            GenreData db = new GenreData();

            using (db)
            {
                Genre Genre1 = new Genre() { GenID = 1, Name = "Shooter" };
                Games G1 = new Games() { GameID = 1, GenID = 1, Genre = Genre1, Name = "Call of Duty", Cost = 60m, ReleaseDate = new DateTime(2011, 1, 2), Review = "good" };
                Games G2 = new Games() { GameID = 2, GenID = 1, Genre = Genre1, Name = "Bioshock", Cost = 30m, ReleaseDate = new DateTime(2012, 3, 6), Review = "good" };
                Games G3 = new Games() { GameID = 3, GenID = 1, Genre = Genre1, Name = "Gears of war", Cost = 30m, ReleaseDate = new DateTime(2013, 7, 5), Review = "good" };
                Games G4 = new Games() { GameID = 4, GenID = 1, Genre = Genre1, Name = "Wolfenstein", Cost = 40m, ReleaseDate = new DateTime(2015, 4, 9), Review = "good" };
                Games G5 = new Games() { GameID = 5, GenID = 1, Genre = Genre1, Name = "Overwatch", Cost = 60m, ReleaseDate = new DateTime(2012, 3, 2), Review = "good" };
                //Games G1 = new Games( "Call of Duty", new DateTime(2019, 06, 03), 60m,1, 1, "5/5 ");
                //Games G2 = new Games("Bioshock", new DateTime(2011, 01, 02), 20m,2, 1, "4/5");
                //Games G3 = new Games("Gears of War", new DateTime(2017, 12, 12), 20m,3, 1, "3/5");
                //Games G4 = new Games("Wolfenstein", new DateTime(2017, 12, 12), 30m,4, 1, "3/5");
                //Games G5 = new Games("Overwatch", new DateTime(2017, 12, 12), 30m,5, 1, "3/5");

                Genre Genre2 = new Genre() { GenID = 2, Name = "Sport" };
                Games G6 = new Games() { GameID = 6, GenID = 2, Genre = Genre2, Name = "NFHL", Cost = 40m, ReleaseDate = new DateTime(2015, 1, 12), Review = "good" };
                Games G7 = new Games() { GameID = 7, GenID = 2, Genre = Genre2, Name = "Fifa", Cost = 60m, ReleaseDate = new DateTime(2011, 9, 11), Review = "good" };
                Games G8 = new Games() { GameID = 8, GenID = 2, Genre = Genre2, Name = "NBA", Cost = 40m, ReleaseDate = new DateTime(2012, 12, 6), Review = "good" };
                Games G9 = new Games() { GameID = 9, GenID = 2, Genre = Genre2, Name = "Wii Sports", Cost = 20m, ReleaseDate = new DateTime(2013, 7, 6), Review = "good" };
                //Games G6 = new Games("NFHL", new DateTime(2019, 06, 03), 40m,6, 2, "5/5 ");
                //Games G7 = new Games("Fifa", new DateTime(2011, 01, 02), 60m,7,  2, "4/5");
                //Games G8 = new Games("NBA", new DateTime(2017, 12, 12), 40m,8, 2, "3/5");
                //Games G9 = new Games("Wii Sports", new DateTime(2017, 12, 12), 20m,9, 2, "3/5");

                Genre Genre3 = new Genre() { GenID = 3, Name = "RPG" };
                Games G10 = new Games() { GameID = 10, GenID = 3, Genre = Genre3, Name = "Bloodborne", Cost = 60m, ReleaseDate = new DateTime(2019, 2, 1), Review = "good" };
                Games G11 = new Games() { GameID = 11, GenID = 3, Genre = Genre3, Name = "Dark Souls", Cost = 60m, ReleaseDate = new DateTime(2019, 8, 5), Review = "good" };
                Games G12 = new Games() { GameID = 12, GenID = 3, Genre = Genre3, Name = "Sekiro", Cost = 20m, ReleaseDate = new DateTime(2018, 11, 9), Review = "good" };
                Games G13 = new Games() { GameID = 13, GenID = 3, Genre = Genre3, Name = "Skyrim", Cost = 20m, ReleaseDate = new DateTime(2017, 3, 8), Review = "good" };
                Games G14 = new Games() { GameID = 14, GenID = 3, Genre = Genre3, Name = "Fable", Cost = 30m, ReleaseDate = new DateTime(2016, 7, 11), Review = "good" };
                Games G15 = new Games() { GameID = 15, GenID = 3, Genre = Genre3, Name = "Shadow of war", Cost = 40m, ReleaseDate = new DateTime(2016, 12, 6), Review = "good" };
                //Games G10 = new Games("Bloodborne", new DateTime(2019, 06, 03), 30m,10, 3, "5/5 ");
                //Games G11 = new Games("Skyrim", new DateTime(2011, 01, 02), 20m,11, 3, "4/5");
                //Games G12 = new Games("Fable", new DateTime(2017, 12, 12), 20m,12, 3, "3/5");
                //Games G13 = new Games("Dark Souls", new DateTime(2017, 12, 12), 20m,13, 3, "3/5");
                //Games G14 = new Games("Shadow of War", new DateTime(2017, 12, 12), 40m,14, 3, "3/5");



                db.Genres.Add(Genre1);
                db.Genres.Add(Genre2);
                db.Genres.Add(Genre3);

                Console.WriteLine("Added genres to database");

                db.Games.Add(G1);
                db.Games.Add(G2);
                db.Games.Add(G3);
                db.Games.Add(G4);
                db.Games.Add(G5);
                db.Games.Add(G6);
                db.Games.Add(G7);
                db.Games.Add(G8);
                db.Games.Add(G9);
                db.Games.Add(G10);
                db.Games.Add(G11);
                db.Games.Add(G12);
                db.Games.Add(G13);
                db.Games.Add(G14);
                db.Games.Add(G15);

                Console.WriteLine("Added games to database");

                db.SaveChanges();

                Console.WriteLine("Saved changes");
            }
        }
    }
}

