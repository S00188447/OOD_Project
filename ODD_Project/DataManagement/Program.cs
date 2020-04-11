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

                Stock S1 = new Stock() { GameID = 1, Game_Name = "Call of Duty", Stock_Quanity = 20 };
                Stock S2 = new Stock() { GameID = 2, Game_Name = "Bioshock", Stock_Quanity = 25 };
                Stock S3 = new Stock() { GameID = 3, Game_Name = "Gears of war", Stock_Quanity = 23 };
                Stock S4 = new Stock() { GameID = 4, Game_Name = "Wolfenstein", Stock_Quanity = 27 };
                Stock S5 = new Stock() { GameID = 5, Game_Name = "Overwatch", Stock_Quanity = 28 };
                Stock S6 = new Stock() { GameID = 6, Game_Name = "NHFL", Stock_Quanity = 23 };
                Stock S7 = new Stock() { GameID = 7, Game_Name = "Fifa", Stock_Quanity = 10 };
                Stock S8 = new Stock() { GameID = 8, Game_Name = "NBA", Stock_Quanity = 12 };
                Stock S9 = new Stock() { GameID = 9, Game_Name = "Wii Sports", Stock_Quanity = 13 };
                Stock S10 = new Stock() { GameID = 10, Game_Name = "Bloodborne", Stock_Quanity = 16 };
                Stock S11 = new Stock() { GameID = 11, Game_Name = "Dark Souls", Stock_Quanity = 19 };
                Stock S12 = new Stock() { GameID = 12, Game_Name = "Sekiro", Stock_Quanity = 6 };
                Stock S13 = new Stock() { GameID = 13, Game_Name = "Skyrim", Stock_Quanity = 3 };
                Stock S14 = new Stock() { GameID = 14, Game_Name = "Fable", Stock_Quanity = 7 };
                Stock S15 = new Stock() { GameID = 15, Game_Name = "Shadow of war", Stock_Quanity = 12 };

                Orders O1 = new Orders() { Order_ID = 1, GameID = 14, Order_Amount = 1, Order_TotalCost = 30 };
                Orders O2 = new Orders() { Order_ID = 2, GameID = 7, Order_Amount = 1, Order_TotalCost = 60 };
                Orders O3 = new Orders() { Order_ID = 3, GameID = 2, Order_Amount = 2, Order_TotalCost = 60 };
                Orders O4 = new Orders() { Order_ID = 4, GameID = 6, Order_Amount = 1, Order_TotalCost = 40 };
                Orders O5 = new Orders() { Order_ID = 5, GameID = 7, Order_Amount = 2, Order_TotalCost = 120 };
                Orders O6 = new Orders() { Order_ID = 6, GameID = 14, Order_Amount = 1, Order_TotalCost = 30 };
                Orders O7 = new Orders() { Order_ID = 7, GameID = 14, Order_Amount = 2, Order_TotalCost = 60 };
                Orders O8 = new Orders() { Order_ID = 8, GameID = 2, Order_Amount = 3, Order_TotalCost = 90 };
                Orders O9 = new Orders() { Order_ID = 9, GameID = 1, Order_Amount = 1, Order_TotalCost = 60 };


                Sales Sales1 = new Sales() { GameID = 1, Game_Name = "Call of Duty", Sales_Recent = 12, Sales_Total = 603, Sales_UpdateDate = new DateTime(2020, 4, 7) };
                Sales Sales2 = new Sales() { GameID = 2, Game_Name = "Bioshock", Sales_Recent = 4, Sales_Total = 406, Sales_UpdateDate = new DateTime(2020, 4, 7) };
                Sales Sales3= new Sales() { GameID = 3, Game_Name = "Gears of war", Sales_Recent = 7, Sales_Total = 233, Sales_UpdateDate = new DateTime(2020, 4, 7) };
                Sales Sales4= new Sales() { GameID = 4, Game_Name = "Wolfenstein", Sales_Recent = 13, Sales_Total = 453, Sales_UpdateDate = new DateTime(2020, 4, 7) };
                Sales Sales5= new Sales() { GameID = 5, Game_Name = "Overwatch", Sales_Recent = 14, Sales_Total = 563, Sales_UpdateDate = new DateTime(2020, 4, 7) };
                Sales Sales6= new Sales() { GameID = 6, Game_Name = "NHFL", Sales_Recent = 15, Sales_Total = 153, Sales_UpdateDate = new DateTime(2020, 4, 14) };
                Sales Sales7= new Sales() { GameID = 7, Game_Name = "Fifa", Sales_Recent = 5, Sales_Total = 256, Sales_UpdateDate = new DateTime(2020, 4, 14) };
                Sales Sales8= new Sales() { GameID = 8, Game_Name = "NBA", Sales_Recent = 9, Sales_Total = 354, Sales_UpdateDate = new DateTime(2020, 4, 14) };
                Sales Sales9= new Sales() { GameID = 9, Game_Name = "Wii Sports", Sales_Recent = 5, Sales_Total = 343, Sales_UpdateDate = new DateTime(2020, 4, 14) };
                Sales Sales10 = new Sales() { GameID = 10, Game_Name = "Bloodborne", Sales_Recent = 6, Sales_Total = 743, Sales_UpdateDate = new DateTime(2020, 4, 14) };
                Sales Sales11 = new Sales() { GameID = 11, Game_Name = "Dark Souls", Sales_Recent = 9, Sales_Total = 731, Sales_UpdateDate = new DateTime(2020, 4, 21) };
                Sales Sales12 = new Sales() { GameID = 12, Game_Name = "Sekiro", Sales_Recent = 16, Sales_Total = 634, Sales_UpdateDate = new DateTime(2020, 4, 21) };
                Sales Sales13 = new Sales() { GameID = 13, Game_Name = "Skyrim", Sales_Recent = 15, Sales_Total = 667, Sales_UpdateDate = new DateTime(2020, 4, 21) };
                Sales Sales14 = new Sales() { GameID = 14, Game_Name = "Fable", Sales_Recent = 8, Sales_Total = 657, Sales_UpdateDate = new DateTime(2020, 4, 21) };
                Sales Sales15 = new Sales() { GameID = 15, Game_Name = "Shadow of war", Sales_Recent = 6, Sales_Total = 443, Sales_UpdateDate = new DateTime(2020, 4, 21) };


                //Genre Genre1 = new Genre() { GenID = 1, Name = "Shooter" };
                //Games G1 = new Games() { GameID = 1, GenID = 1, Genre = Genre1, Name = "Call of Duty", Cost = 60m, ReleaseDate = new DateTime(2011, 1, 2), Review = "good" };
                //Games G2 = new Games() { GameID = 2, GenID = 1, Genre = Genre1, Name = "Bioshock", Cost = 30m, ReleaseDate = new DateTime(2012, 3, 6), Review = "good" };
                //Games G3 = new Games() { GameID = 3, GenID = 1, Genre = Genre1, Name = "Gears of war", Cost = 30m, ReleaseDate = new DateTime(2013, 7, 5), Review = "good" };
                //Games G4 = new Games() { GameID = 4, GenID = 1, Genre = Genre1, Name = "Wolfenstein", Cost = 40m, ReleaseDate = new DateTime(2015, 4, 9), Review = "good" };
                //Games G5 = new Games() { GameID = 5, GenID = 1, Genre = Genre1, Name = "Overwatch", Cost = 60m, ReleaseDate = new DateTime(2012, 3, 2), Review = "good" };
                ////Games G1 = new Games( "Call of Duty", new DateTime(2019, 06, 03), 60m,1, 1, "5/5 ");
                ////Games G2 = new Games("Bioshock", new DateTime(2011, 01, 02), 20m,2, 1, "4/5");
                ////Games G3 = new Games("Gears of War", new DateTime(2017, 12, 12), 20m,3, 1, "3/5");
                ////Games G4 = new Games("Wolfenstein", new DateTime(2017, 12, 12), 30m,4, 1, "3/5");
                ////Games G5 = new Games("Overwatch", new DateTime(2017, 12, 12), 30m,5, 1, "3/5");

                //Genre Genre2 = new Genre() { GenID = 2, Name = "Sport" };
                //Games G6 = new Games() { GameID = 6, GenID = 2, Genre = Genre2, Name = "NFHL", Cost = 40m, ReleaseDate = new DateTime(2015, 1, 12), Review = "good" };
                //Games G7 = new Games() { GameID = 7, GenID = 2, Genre = Genre2, Name = "Fifa", Cost = 60m, ReleaseDate = new DateTime(2011, 9, 11), Review = "good" };
                //Games G8 = new Games() { GameID = 8, GenID = 2, Genre = Genre2, Name = "NBA", Cost = 40m, ReleaseDate = new DateTime(2012, 12, 6), Review = "good" };
                //Games G9 = new Games() { GameID = 9, GenID = 2, Genre = Genre2, Name = "Wii Sports", Cost = 20m, ReleaseDate = new DateTime(2013, 7, 6), Review = "good" };
                ////Games G6 = new Games("NFHL", new DateTime(2019, 06, 03), 40m,6, 2, "5/5 ");
                ////Games G7 = new Games("Fifa", new DateTime(2011, 01, 02), 60m,7,  2, "4/5");
                ////Games G8 = new Games("NBA", new DateTime(2017, 12, 12), 40m,8, 2, "3/5");
                ////Games G9 = new Games("Wii Sports", new DateTime(2017, 12, 12), 20m,9, 2, "3/5");

                //Genre Genre3 = new Genre() { GenID = 3, Name = "RPG" };
                //Games G10 = new Games() { GameID = 10, GenID = 3, Genre = Genre3, Name = "Bloodborne", Cost = 60m, ReleaseDate = new DateTime(2019, 2, 1), Review = "good" };
                //Games G11 = new Games() { GameID = 11, GenID = 3, Genre = Genre3, Name = "Dark Souls", Cost = 60m, ReleaseDate = new DateTime(2019, 8, 5), Review = "good" };
                //Games G12 = new Games() { GameID = 12, GenID = 3, Genre = Genre3, Name = "Sekiro", Cost = 20m, ReleaseDate = new DateTime(2018, 11, 9), Review = "good" };
                //Games G13 = new Games() { GameID = 13, GenID = 3, Genre = Genre3, Name = "Skyrim", Cost = 20m, ReleaseDate = new DateTime(2017, 3, 8), Review = "good" };
                //Games G14 = new Games() { GameID = 14, GenID = 3, Genre = Genre3, Name = "Fable", Cost = 30m, ReleaseDate = new DateTime(2016, 7, 11), Review = "good" };
                //Games G15 = new Games() { GameID = 15, GenID = 3, Genre = Genre3, Name = "Shadow of war", Cost = 40m, ReleaseDate = new DateTime(2016, 12, 6), Review = "good" };
                ////Games G10 = new Games("Bloodborne", new DateTime(2019, 06, 03), 30m,10, 3, "5/5 ");
                ////Games G11 = new Games("Skyrim", new DateTime(2011, 01, 02), 20m,11, 3, "4/5");
                ////Games G12 = new Games("Fable", new DateTime(2017, 12, 12), 20m,12, 3, "3/5");
                ////Games G13 = new Games("Dark Souls", new DateTime(2017, 12, 12), 20m,13, 3, "3/5");
                ////Games G14 = new Games("Shadow of War", new DateTime(2017, 12, 12), 40m,14, 3, "3/5");



                //db.Genres.Add(Genre1);
                //db.Genres.Add(Genre2);
                //db.Genres.Add(Genre3);

                Console.WriteLine("Added genres to database");

                //db.Games.Add(G1);
                //db.Games.Add(G2);
                //db.Games.Add(G3);
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
                //db.Games.Add(G15);

                db.Stock.Add(S1);
                db.Stock.Add(S2);
                db.Stock.Add(S3);
                db.Stock.Add(S4);
                db.Stock.Add(S5);
                db.Stock.Add(S6);
                db.Stock.Add(S7);
                db.Stock.Add(S8);
                db.Stock.Add(S9);
                db.Stock.Add(S10);
                db.Stock.Add(S11);
                db.Stock.Add(S12);
                db.Stock.Add(S13);
                db.Stock.Add(S14);
                db.Stock.Add(S15);

                Console.WriteLine("Added stock values to database");

                db.Order.Add(O1);
                db.Order.Add(O2);
                db.Order.Add(O3);
                db.Order.Add(O4);
                db.Order.Add(O5);
                db.Order.Add(O6);
                db.Order.Add(O7);
                db.Order.Add(O8);
                db.Order.Add(O9);


                Console.WriteLine("Added order values to database");

                db.Sales.Add(Sales1);
                db.Sales.Add(Sales2);
                db.Sales.Add(Sales3);
                db.Sales.Add(Sales4);
                db.Sales.Add(Sales5);
                db.Sales.Add(Sales6);
                db.Sales.Add(Sales7);
                db.Sales.Add(Sales8);
                db.Sales.Add(Sales9);
                db.Sales.Add(Sales10);
                db.Sales.Add(Sales11);
                db.Sales.Add(Sales12);
                db.Sales.Add(Sales13);
                db.Sales.Add(Sales14);
                db.Sales.Add(Sales15);

                Console.WriteLine("Added sales values to database");




                //Console.WriteLine("Added games to database");

                db.SaveChanges();

                Console.WriteLine("Saved changes");
            }
        }
    }
}

