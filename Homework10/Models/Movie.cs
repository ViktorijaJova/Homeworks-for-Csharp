using System;
using System.Collections.Generic;
using System.Text;

namespace TryHomework
{
   public class Movie
    {
        public string Title { get; set; }
        public Genre Genres { get; set; }

        public int Rating { get; set; }
        public double TicketPrice { get; set; }


        public Movie (string title,int rating)
        {
            Title = title;

            try
            {
                if(rating <1 || rating > 5)
                {
                    throw new Exception("Invalid Rating Input!!!");
                }
              Rating = rating;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Rating = 1;
            }
            Genres = Genre.Random;
            TicketPrice = 5 * rating;
        }

        public Movie (string title,Genre genre,int rating,  double ticketprice)
        {
            Title = title;
            Genres = genre;
            try
            {
                if (rating < 1 || rating > 5)
                {
                    throw new Exception("Invalid Rating Input!!!");
                }
                Rating = rating;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Rating = 1;
            }
            if(ticketprice == 0)
            {
                TicketPrice = 5 * rating;
            }
            else
            {
                TicketPrice = ticketprice;
            }
            
           
        }
    }
}
