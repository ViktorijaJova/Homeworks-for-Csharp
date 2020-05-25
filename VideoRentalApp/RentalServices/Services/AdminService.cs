using sedc.videorental.data.DataBase;
using sedc.videorental.data.Models;
using sedc.videorental.Services.Helpers;
using sedc.videorental.Services.Menus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace sedc.videorental.Services.Services
{
     public class AdminService
    {
        private MovieRepository  _movieRepository;
            private UserRepository  _userRepository;

        public AdminService()
        {
            _movieRepository = new MovieRepository();
            _userRepository = new UserRepository();
        }

        public User LoginAsAdmin()
        {
            while (true)
            {
                Console.Write("Enter Admin Card id Number:");
                var idCard = InputParser.ToInteger(100, 999);

                var user = _userRepository.GetUserByIdCard(idCard);

                if (user != null)
                {
                    if (user.isAdmin == true)
                    {
                        Console.WriteLine($"Welcome to work Admin: {user.FullName}");
                        return user;
                    }
                }
                Console.WriteLine("Admin card id does not excist, are you sure you work here mate?");
                Console.WriteLine("Try again y/n");
                if (!InputParser.ToConfirm())
                {
                    Console.WriteLine("I hope you find out where you work,if not we always like pro-bono work :)");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }


            }
        }


        private void PrintUsersInfo(List<User> users)
        {

            foreach (var user in users)
            {
                if (user.isAdmin != true)
                {
                    Console.WriteLine(user.FullName);
                }
            }
        }
        public void ViewUsersListAsAdmin(User user)
        {
            string erroeMessage = string.Empty;
            var listofusers = _userRepository.GetAllUsers();
            bool isFinished = false;
            while (!isFinished)

            {
                Screen.ClearScreen();
                Screen.ErrorMessage(erroeMessage);

                if (listofusers.Count != 0)
                {
                    PrintUsersInfo(listofusers);

                    Console.WriteLine("\nWould you like to see users with expired subscription y/n");
                    var readline = Console.ReadLine();

                    if (readline == "y" )
                    {
                        foreach (var exuser in listofusers)
                        {
                            if (exuser.IsSubscriptionExpired)
                            {
                                Console.WriteLine(exuser.FullName);
                            }
                        }
                    }
                    else
                    {
                        
                        break;

                    }
                }
                else
                {
                    Console.WriteLine("No users available, you messed up!");
                }

                isFinished = !isFinished;
            }

        }

        public void ViewMovieListAsAdmin(User user)
        {
            string erroeMessage = string.Empty;
            var movies = _movieRepository.GetAllMovies();

            bool isFinished = false;

            while (!isFinished)

            {
                Screen.ClearScreen();
                Screen.ErrorMessage(erroeMessage);

                if (movies.Count != 0)
                {

                    PrintMoviesInfo(movies);

                }
                else
                {
                    Console.WriteLine("No videos available, you messed up!");
                }



                isFinished = !isFinished;
            }
        }

        public Movie AddMovieByAdmin()
        {
            while (true)
            {
                Console.WriteLine("Enter Title");
                var title = Console.ReadLine();
                Console.WriteLine("Enter age restriction:");
                var agerestriction = InputParser.ToInteger(12, 20);
                Console.WriteLine("Enter Genre");
                var genre = InputParser.ToGenre();
                Console.WriteLine("Enter if its available: true/false");
                var isavaible = bool.Parse(Console.ReadLine());
                Console.WriteLine("Enter language:");
                string language = Console.ReadLine();
                Console.WriteLine("Enter length");
                var length = InputParser.ToInteger(60, 300);
                Console.WriteLine("Enter quantity");
                var quantity = InputParser.ToInteger(1, 20);
                Console.WriteLine("Is it a premier");
                var premier = bool.Parse(Console.ReadLine());
                Console.WriteLine("And finally enter realse date");
                DateTime relasedate = InputParser.ToDateTime();


                Console.WriteLine("Adding movie please wait:....");
                LoadingHelpers.Spiner();



                var movie = new Movie
                {

                    Title = title,
                    AgeRestriction = agerestriction,
                    Genre = genre,
                    IsAviable = isavaible,
                    Language = language,
                    Length = length,
                    Quantity = quantity,
                    isapremier = premier,
                    ReleaseDate = relasedate

                };

                var movies = _movieRepository.GetAllMovies();
                movies.Add(movie);
                Console.WriteLine($"\rSuccesfully added {movie.Title} to the list");
                return movie;

            }

        }


        public Movie RemoveMovieByAdmin()
        {
            while (true)
            {
                Console.WriteLine("Enter movie id:");
                var movieId = InputParser.ToInteger(1, 35);
                var movie = _movieRepository.GetMovieById(movieId);
                var movies = _movieRepository.GetAllMovies();


                if (!movie.IsAviable)
                {
                    throw new Exception($"Movie  is not avaiable at the moment");

                }

                Console.WriteLine($"Are you sure you want to delete the movie? {movie.Title}y/n");
                bool confirm = InputParser.ToConfirm();
                Console.WriteLine("Deleting movie please wait...");
                LoadingHelpers.Spiner();
                movies.Remove(movie);
                Console.WriteLine($"You have deleted succesfully {movie.Title}");
                return null;

            }

        }


        private void PrintMoviesInfo(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                string availability = movie.IsAviable ? "Yes" : "No";
                Console.WriteLine(string.Format
                    ("Rent id: {0} Title {1} Release Date {2} Genre {3} isAvailable {4} Quantity {5}", movie.Id
                    , movie.Title,
                    movie.ReleaseDate.ToString
                    ("MMMM dd yyyy"), movie.Genre, availability
                     , movie.Quantity
                   )
                    );
            }
        }

    }
}
