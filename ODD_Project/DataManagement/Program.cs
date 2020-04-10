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
                Genre Genre1 = new Genre() { GenreID = 1, Name = "Shooter" };
                Games G1 = new Games() { GameID = 1, GenreID = 1, Name = "Call", Cost = 60m, ReleaseDate = new DateTime(2019, 6, 6), Review = "good" };
                //Games G1 = new Games( "Call of Duty", new DateTime(2019, 06, 03), 60m,1, 1, "5/5 ");
                //Games G2 = new Games("Bioshock", new DateTime(2011, 01, 02), 20m,2, 1, "4/5");
                //Games G3 = new Games("Gears of War", new DateTime(2017, 12, 12), 20m,3, 1, "3/5");
                //Games G4 = new Games("Wolfenstein", new DateTime(2017, 12, 12), 30m,4, 1, "3/5");
                //Games G5 = new Games("Overwatch", new DateTime(2017, 12, 12), 30m,5, 1, "3/5");

                Genre Genre2 = new Genre() { GenreID = 2, Name = "Sport" };
                Games G2 = new Games() { GameID = 1, GenreID = 1, Name = "Call", Cost = 60m, ReleaseDate = new DateTime(2019, 6, 6), Review = "good" };
                //Games G6 = new Games("NFHL", new DateTime(2019, 06, 03), 40m,6, 2, "5/5 ");
                //Games G7 = new Games("Fifa", new DateTime(2011, 01, 02), 60m,7,  2, "4/5");
                //Games G8 = new Games("NBA", new DateTime(2017, 12, 12), 40m,8, 2, "3/5");
                //Games G9 = new Games("Wii Sports", new DateTime(2017, 12, 12), 20m,9, 2, "3/5");

                Genre Genre3 = new Genre() { GenreID = 3, Name = "RPG" };
                Games G3 = new Games() { GameID = 1, GenreID = 1, Name = "Call", Cost = 60m, ReleaseDate = new DateTime(2019, 6, 6), Review = "good" };
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
                //db.Games.Add(G4);
                //db.Games.Add(G5);
                //db.Games.Add(G6);
                //db.Games.Add(G7);
                //db.Games.Add(G8);
                //db.Games.Add(G9);
                //db.Games.Add(G10);
                //db.Games.Add(G11);
                //db.Games.Add(G12);
                //db.Games.Add(G13);
                //db.Games.Add(G14);

                Console.WriteLine("Added games to database");

                db.SaveChanges();

                Console.WriteLine("Saved changes");
            }
        }
    }
}

