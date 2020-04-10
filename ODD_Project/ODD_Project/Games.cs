﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int GenreID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public DateTime ReleaseDate { get; set; }
        public string Review { get; set; }
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
            public int GenreID { get; set; }
            public string Name { get; set; }

        public virtual List<Games> games { get; set; }
        }

    public class GenreData: DbContext
    {
        public GenreData() : base("GenreData") { }
        public DbSet<Games> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }

    
}
