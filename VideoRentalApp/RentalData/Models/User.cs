using sedc.videorental.data.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace sedc.videorental.data.Models
{
   public class User:BaseEntity
    {
        public string FullName { get; set; }
        public DateTime DateofBirth { get; set; }
        public int CardNumber { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        
        public DateTime SubscriptionRenwed { get; set; }

         public bool isAdmin { get; set; }


        public List<RentalInfo> RentedMovies { get; set; }

        public List<RentalInfo> RentedMoviesHistory { get; set; }

        public List<RentalInfo> NewMoviesAdded { get; set; }

       

        

        public User()
        {
            IsSubscriptionExpired = false;
            RentedMovies = new List<RentalInfo>();
            RentedMoviesHistory = new List<RentalInfo>();

        }

    }



}
