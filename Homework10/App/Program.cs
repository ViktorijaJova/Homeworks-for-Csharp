using System;
using System.Collections.Generic;
using System.Linq;

namespace TryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
             Validate validate = new Validate();
             UserInterface userInterface = new UserInterface();


            // movie list one
            Movie movie1 = new Movie("Room", Genre.Drama,3, 2);
            Movie movie2 = new Movie("Call me by your name", Genre.Drama, 4, 2.5);
            Movie movie3 = new Movie("Get Out", Genre.Horror, 2, 2.5);
            Movie movie4 = new Movie("Midsommer", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Avengers:End Game", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("Taken", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Bridesmaids", Genre.Comedy, 1, 2.5);
            Movie movie8 = new Movie("Game Night", Genre.Comedy, 4, 2.5);
            Movie movie9 = new Movie("Ex Machina", Genre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Jurasstic Park", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

            //movie list two
            Movie movie11 = new Movie("Hangover", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Jojo Rabit", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("It", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Psycho", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("Thor:Ragnorak", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Ant-man and th Wasp", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("Once upon a time in Hollywood", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("Joker", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Eternal Sunshine of the Spotless Mind", Genre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Arrival", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

            // first Cinema
            Cinema cinema1 = new Cinema("Pathe");
            cinema1.Halls = new List<int>() { 1, 2, 3 };
            cinema1.ListofMovies = MovieSet1;


            //second Cinema
            Cinema cinema2 = new Cinema("Cineplex");
            cinema2.Halls = new List<int>() { 1, 2, 3 ,4 };
            cinema2.ListofMovies = MovieSet2;

            userInterface.ChoseCinema();
            string chosenCinema = validate.ValidateOption1or2();

            switch (chosenCinema)
            {
                case "1":
                    userInterface.ChoseCinemaOptions();
                    string chosenMovieView1 = validate.ValidateOption1or2();

                    switch (chosenMovieView1)
                    {
                        case "1":
                            userInterface.Movies(cinema1.ListofMovies);
                            Console.WriteLine("Please chosoe a movie from the list:");
                            Movie movieToWatch = validate.Movie(cinema1.ListofMovies);
                            cinema1.MoviePlaying(movieToWatch);
                            break;

                        case "2":
                            userInterface.MovieGenre();
                            string genre = validate.ValidateOption1to5();
                            Genre chosenGenre = validate.Genres(genre);

                            List<Movie> moviesByGenre = cinema1.ListofMovies.Where(x => x.Genres == chosenGenre).ToList();
                            userInterface.Movies(moviesByGenre);

                            Console.WriteLine("Please choose a  movie from the list:");
                            Movie movieFromGenre = validate.Movie(moviesByGenre);
                            cinema1.MoviePlaying(movieFromGenre);
                            break;
                    }

                    break;

                case "2":

                     userInterface.ChoseCinemaOptions();
                    string chosenMovieView2 = validate.ValidateOption1or2();

                    switch (chosenMovieView2)
                    {
                        case "1":

                            userInterface.Movies(cinema2.ListofMovies);
                            Console.WriteLine("Please write the name of the movie from the list that you want to watch:\n");
                            Movie movieToWatch = validate.Movie(cinema2.ListofMovies);
                            cinema2.MoviePlaying(movieToWatch);
                            break;

                        case "2":

                            userInterface.MovieGenre();
                            string genre = validate.ValidateOption1to5();
                            Genre chosenGenre = validate.Genres(genre);

                            List<Movie> moviesByGenre = cinema2.ListofMovies.Where(x => x.Genres == chosenGenre).ToList();
                            userInterface.Movies(moviesByGenre);

                            Console.WriteLine("Please write the name of the movie from the list that you want to watch:\n: ");
                            Movie movieFromGenre = validate.Movie(moviesByGenre);
                            cinema2.MoviePlaying(movieFromGenre);
                            break;
                    }
                    break;
            }

            Console.ReadLine();


        }


    }
}