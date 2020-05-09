using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryHomework
{
   public class UserInterface : Validate
    {

        public void ChoseCinema()
        {
            Console.WriteLine("Please chose which cinema you want to go to: 1 or 2 ");
            Console.WriteLine("1.Pathe");
            Console.WriteLine("2. Cineplex");
        }

        public void ChoseCinemaOptions()
        {
            Console.WriteLine("Please choose from the following options: 1 or 2 ");
            Console.WriteLine("1. See all of the movie lists");
            Console.WriteLine("2. See movies by Genre");
        }

        public void Movies(List<Movie> allMovies)
        {
            foreach (var movie in allMovies)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }

        public void MovieGenre()
        {
            Console.WriteLine("Please choose your favourite Genre: 1 to 5");
            Console.WriteLine("1. Comedy");
            Console.WriteLine("2. Horror");
            Console.WriteLine("3. Action");
            Console.WriteLine("4. Drama");
            Console.WriteLine("5. SciFi");
        }




    }
}
