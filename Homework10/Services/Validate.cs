using System;
using System.Collections.Generic;
using System.Text;

namespace TryHomework
{
     public class Validate
    {
        public string ValidateOption1or2()
        {
            string input = Console.ReadLine();


            try
            {

                if ((input != "1") && (input != "2"))

                {
                    throw new Exception("Please chose between option 1 or 2, thank you");


                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                input = ValidateOption1or2();

            }

            return input;


        }

        public string ValidateOption1to5()
        {
            string input = Console.ReadLine();

            try
            {
                if ((input != "1") && (input != "2") && (input != "3") && (input != "4") && (input != "5"))
                {
                   throw new Exception("Please chose between options 1 to 5, thank you");

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                input = ValidateOption1to5();

            }

            return input;
        }

        public Movie Movie(List<Movie> allMovies)
        {
            string input = Console.ReadLine();
            Movie movieToWatch = null;
            try
            {

                foreach (var movie in allMovies)
                {
                    if (input == movie.Title)
                    {
                        movieToWatch = movie;
                    }
                }
                if (movieToWatch == null)
                {
                    throw new Exception("Please choose a  movie to watch from the list");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                movieToWatch = Movie(allMovies);

            }

            return movieToWatch;
        }

        public Genre Genres(string genre)
        {
            Genre chosenGenre = Genre.Random;

            switch (genre)
            {
                case "1":
                    chosenGenre = Genre.Comedy;
                    break;
                case "2":
                    chosenGenre = Genre.Horror;
                    break;
                case "3":
                    chosenGenre = Genre.Action;
                    break;
                case "4":
                    chosenGenre = Genre.Drama;
                    break;
                case "5":
                    chosenGenre = Genre.SciFi;
                    break;
            }
            return chosenGenre;
        }
    }
}
