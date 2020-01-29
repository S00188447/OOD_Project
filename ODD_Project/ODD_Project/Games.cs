using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODD_Project
{
    public enum Genre { RPG, Shooter, Sport }

    class Games:IComparable
    {

        //Properties
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public static string Description { get; set; }
        public Genre Genre { get; set; }
        public string Review { get; set; }

        public override string ToString()
        {
            return $" {Name}{" - "}{ ReleaseDate.ToShortDateString() }";
        }
        public Games(string newName, DateTime newReleaseDate, decimal newCost, string newDesc, Genre newGenre, string newReview)
        {
            Name = newName;
            ReleaseDate = newReleaseDate;
            Cost = newCost;
            Description = newDesc;
            Genre = newGenre;
            Review = newReview;
        }

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
}
