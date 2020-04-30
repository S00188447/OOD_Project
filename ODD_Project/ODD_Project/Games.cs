using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODD_Project
{


    public class Games : IComparable
    {

        //Properties
        [Key]
        public int GameID { get; set; }


        public int GenID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public DateTime ReleaseDate { get; set; }
        public string Review { get; set; }
        [ForeignKey("GenID")]
        public virtual Genre Genre { get; set; }
        public override string ToString()
        {
            return $" {Name}{" - "}{ ReleaseDate.ToShortDateString() }";
        }
        //public Games(string newName, DateTime newReleaseDate, decimal newCost, int newGameID, int newGenreID, string newReview)
        //{
        //    GameID = newGameID;
        //    GenreID = newGenreID;
        //    Name = newName;
        //    ReleaseDate = newReleaseDate;
        //    Cost = newCost;
        //    Review = newReview;
        //}

        public int CompareTo(object obj)
        {
            //get a reference to the next object in the list
            Games objectthatIamcomparingto = (Games)obj;

            //choosing the video I am comparing
            int returnValue = this.ReleaseDate.CompareTo(objectthatIamcomparingto.ReleaseDate);

            //return
            return returnValue;
        }
    }

        public class Genre
        {

        [Key]
            public int GenID { get; set; }
            public string Name { get; set; }

        public virtual List<Games> games { get; set; }
        }

    public class Sales
    {

        [Key]
        public int GameID { get; set; }
        public string Game_Name { get; set; }

        public int Sales_Recent { get; set; }

        public int Sales_Total { get; set; }

        public DateTime Sales_UpdateDate { get; set; }


        public virtual List<Games> games { get; set; }
    }

    public class Stock
    {

        [Key]
        public int GameID { get; set; }
        public string Game_Name { get; set; }
        public int Stock_Quanity { get; set; }


        public virtual List<Games> games { get; set; }
    }

    public class Orders
    {

        [Key]
        public int Order_ID { get; set; }
        public int GameID { get; set; }

        public int Order_Amount { get; set; }

        public int Order_TotalCost { get; set; }


        public virtual List<Games> games { get; set; }
    }

    public class GamesStoreData: DbContext
    {
        public GamesStoreData() : base("GamesStoreData") { }
        public DbSet<Games> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Stock> Stock { get; set; }

        public DbSet<Orders> Order { get; set; }
    }

    
}
