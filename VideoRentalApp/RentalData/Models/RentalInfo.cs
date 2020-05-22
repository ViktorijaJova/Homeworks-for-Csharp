using sedc.videorental.data.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace sedc.videorental.data.Models
{
   public class RentalInfo:BaseEntity
    {
        public Movie Movie { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime DateReturned { get; set; }

        public RentalInfo(Movie movie)
        {
            Movie = movie;
            DateRented = DateTime.Now;
            DateReturned = DateTime.Now.AddMonths(-1);
        }
    }
}
