using sedc.videorental.data.DataBase;
using sedc.videorental.data.Models;
using sedc.videorental.Services.Helpers;
using sedc.videorental.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace sedc.videorental.Services.Services
{
    public class MovieService : InMemoryDatabase
    {
        private MovieRepository _movierepository;

        public MovieService()
        {

            _movierepository = new MovieRepository();
        }

        public void ViewMovieList(User user)
        {
            string erroeMessage = string.Empty;
            var movies = _movierepository.GetAllMovies();
            bool isFinished = false;
            while (!isFinished)

            {
                Screen.ClearScreen();
                Screen.ErrorMessage(erroeMessage);

                if (movies.Count != 0)
                {
                    PrintMoviesInfo(movies);
                    if (user.IsSubscriptionExpired)
                    {
                        Console.WriteLine("\nYour Subscription has expired would you like to renew your subscription y/n");
                        var readline = Console.ReadLine();
                        LoadingHelpers.Spiner();

                        if (readline == "y")
                        {
                            var renewed = user.SubscriptionRenwed = DateTime.Now;
                            user.IsSubscriptionExpired = !user.IsSubscriptionExpired;
                            Console.WriteLine($"\nThank you {user.FullName} your subscription has been renewed {renewed}!");
                        }
                        else if (readline == "n")
                        {
                            Console.WriteLine("Please renew your subscription if you want to rent a movie");
                            Thread.Sleep(5000);
                            isFinished = !isFinished;
                            break; 
                           
                        }
                     
                    }
                }
                else
                {
                    Console.WriteLine("No videos available with that filtering options");
                }

                Screen.OrderingMenu();
                var selection = InputParser.ToInteger(0, 9);

                switch (selection)
                {
                    case 1:
                        movies = _movierepository.GetAllMovies();
                        break;

                    case 2:
                        movies = _movierepository.OrderByGenre();

                        break;


                    case 3:
                        var genre = InputParser.ToGenre();
                        movies = _movierepository.GetbyGenre(genre);

                        break;

                    case 4:
                        movies = _movierepository.OrderByReleaseDate();
                        break;

                    case 5:
                        Console.WriteLine("Enter year:");
                        var year = InputParser.ToInteger(_movierepository.GetAllMovies().Min(_movie => _movie.ReleaseDate.Year)


                          , DateTime.Now.Year - 1);

                        movies = _movierepository.GetByYear(year);
                        break;
                    case 6:
                        movies = _movierepository.OrderByAvaibility();
                        break;
                    case 7:
                        movies = _movierepository.GetAvaiableMovies();

                        break;
                    case 8:
                        Console.WriteLine("Enter search phrase:");

                        string titlepart = Console.ReadLine();
                        movies = _movierepository.SearchMoviesbyTitle(titlepart);

                        break;
                    case 9:
                        try
                        {
                            RentVideo(user);

                        }
                        catch (Exception ex)
                        {
                            erroeMessage = ex.Message;
                        }

                        break;
                    case 0:
                        isFinished = !isFinished;
                        break;
                }

            }

        }

        public void ViewSpeicalOffers(User user)
        {
            string errorMessage = string.Empty;
            var premiers = _movierepository.GetPremiers();
            var discounts = _movierepository.GetDiscountMovies();
            bool isgoing = false;
            Screen.SpecialOffers();

            while (!isgoing)
            {

                var specialoffers = InputParser.ToInteger(1, 2);
                Screen.ClearScreen();
                switch (specialoffers)
                {
                    case 1:
                        PrintMoviesInfo(discounts);
                        Console.WriteLine("1.Rent a movie from our special limited offer");
                        Console.WriteLine("2 Go back");
                        var readline = InputParser.ToInteger(1, 2);
                        switch (readline)
                        {
                            case 1:

                                RentVideofromDiscounts(user);
                                break;

                            case 2:
                                isgoing = !isgoing;
                                break;

                        }

                        break;

                    case 2:
                        PrintMoviesInfo(premiers);
                        Console.WriteLine("1.Rent a movie from our special limited offer");
                        Console.WriteLine("2 Go back");
                        var readlines = InputParser.ToInteger(1, 2);

                        switch (readlines)
                        {
                            case 1:
                                RentVideofromPremiers(user);
                                break;

                            case 2:
                                isgoing = !isgoing;
                                break;
                        }
                        break;

                }
            }

        }

        public void ViewMovieListAsAdmin(User user)
        {
            string erroeMessage = string.Empty;
            var movies = _movierepository.GetAllMovies();
            var premiers = _movierepository.GetPremiers();
            var discounts = _movierepository.GetDiscountMovies();
            bool isFinished = false;

            while (!isFinished)

            {
                Screen.ClearScreen();
                Screen.ErrorMessage(erroeMessage);

                if (movies.Count != 0)
                {
                    PrintMoviesInfo(movies);
                    PrintMoviesInfo(discounts);
                    PrintMoviesInfo(premiers);

                }
                else
                {
                    Console.WriteLine("No videos available, you messed up!");
                }



                isFinished = !isFinished;
            }
        }

        private void RentVideo(User user)
        {
            Console.WriteLine("Enter movie id:");
            var movieId = InputParser.ToInteger(_movierepository.GetAllMovies()
                .Min(_movie => _movie.Id),
                _movierepository.GetAllMovies()
                .Max(_movie => _movie.Id)
                );
            var movie = _movierepository.GetMovieById(movieId);



            if (movie != null)
            {

                if (user.RentedMovies.Any(rental => rental.Movie.Id == movieId))
                {
                    throw new Exception($"You have aleady rented this movie {movie.Title}");

                }
                /*
                                var listofrentedmovieids = user.RentedMovies
                                    .Select(rental => rental.Movie.Id)
                                    .ToList();*/
                /*   if (listofrentedmovieids.Contains(movieId))
                   {
                       throw new Exception($"You have aleady rented this movie {movie.Title}");
                   }*/


                if (!movie.IsAviable)
                {
                    throw new Exception($"Movie { movie.Title }  mis not avaiable at the moment");

                }

                Console.WriteLine($"Are you sure you want to rent {movie.Title}? y/n");
                bool confirm = InputParser.ToConfirm();
                if (!confirm)
                {
                    return;
                }
                Console.WriteLine("Renting movie please wait...");
                LoadingHelpers.Spiner();
                movie.Quantity--;
                if (movie.Quantity == 0)
                {
                    movie.IsAviable = !movie.IsAviable;
                }
                user.RentedMovies.Add(new RentalInfo(movie));
                Console.WriteLine("Successfully rented movie");
                Thread.Sleep(2000);
            }
            else
            {
                throw new Exception($" No movie was found with {movieId} id");
            }
        }

        private void RentVideofromPremiers(User user)
        {
            Console.WriteLine("Enter movie id:");
            var movieId = InputParser.ToInteger(_movierepository.GetPremiers()
                .Min(_movie => _movie.Id),
                _movierepository.GetPremiers()
                .Max(_movie => _movie.Id)
                );
            var movie = _movierepository.GetMovieByIDPremiers(movieId);


            if (!movie.IsAviable)
            {
                throw new Exception($"Movie { movie.Title }  is not avaiable at the moment");

            }

            Console.WriteLine($"Are you sure you want to rent {movie.Title}? y/n");
            bool confirm = InputParser.ToConfirm();
            if (!confirm)
            {
                return;
            }
            Console.WriteLine("Renting movie please wait...");
            LoadingHelpers.Spiner();
            movie.Quantity--;
            if (movie.Quantity == 0)
            {
                movie.IsAviable = !movie.IsAviable;
            }

            user.RentedMovies.Add(new RentalInfo(movie));
            Console.WriteLine("Successfully rented an awesome movie");
            Console.WriteLine("Press 2 to go back");
            Thread.Sleep(2000);


        }


        private void RentVideofromDiscounts(User user)
        {
            Console.WriteLine("Enter movie id:");
            var movieId = InputParser.ToInteger(_movierepository.GetDiscountMovies()
                .Min(_movie => _movie.Id),
                _movierepository.GetDiscountMovies()
                .Max(_movie => _movie.Id)
                );
            var movie = _movierepository.GetMoviesByIDDiscounts(movieId);


            if (!movie.IsAviable)
            {
                throw new Exception($"Movie { movie.Title }  is not avaiable at the moment");

            }

            Console.WriteLine($"Are you sure you want to rent {movie.Title}? y/n");
            bool confirm = InputParser.ToConfirm();
            if (!confirm)
            {
                return;
            }
            Console.WriteLine("Renting movie please wait...");
            LoadingHelpers.Spiner();
            movie.Quantity--;
            if (movie.Quantity == 0)
            {
                movie.IsAviable = !movie.IsAviable;
            }

            user.RentedMovies.Add(new RentalInfo(movie));
            Console.WriteLine("Successfully rented an awesome movie");
            Console.WriteLine("Press 2 to go back");
            Thread.Sleep(2000);


        }
        public void ViewRentedVideos(User user)
        {
            string errorMessage = string.Empty;
            var rentals = user.RentedMovies;
            bool isFinished = false;

            while (!isFinished)
            {
                try
                {
                    Screen.ClearScreen();
                    Screen.ErrorMessage(errorMessage);

                    if (rentals.Count != 0)
                    {
                        var movies = rentals.Select(_rental => _rental.Movie)
                            .ToList();
                        PrintMoviesInfo(movies);

                    }
                    else
                    {
                        Console.WriteLine("You have not rented any videos");
                    }

                    Screen.RentedMenu();
                    int selection = InputParser.ToInteger(0, 2);
                    switch (selection)
                    {
                        case 1:
                            rentals = user.RentedMovies;
                            break;
                        case 2:
                            ReturnMovie(user);
                            break;
                        case 0:
                            isFinished = !isFinished;
                            break;
                    }
                }

                catch (Exception ex)
                {
                    errorMessage = ex.Message;
                }
            }

        }


        public void ViewRentedHistoryVideos(User user)
        {
            if (user.RentedMoviesHistory.Count == 0)
            {
                throw new Exception("You do not have any videos rented history");
            }
            PrintRentedInfo(user.RentedMoviesHistory);

            Console.WriteLine("To go back press 0");
            int selection = InputParser.ToInteger(0, 0);
            if (selection == 0)
            {
                return;
            }

        }

        private void ReturnMovie(User user)
        {
            if (user.RentedMovies.Count == 0)
            {
                throw new Exception("You do not have any rented videos");
            }

            Console.WriteLine("Enter movie id in order to return the video");
            var movieid = InputParser.ToInteger(1, 35);

            var rental = user.RentedMovies.FirstOrDefault(_rental =>
            _rental.Movie.Id == movieid);

            LoadingHelpers.ShowSimplePercentage();
            if (rental != null)
            {
                rental.DateRented = DateTime.Now;

                // fix bug later
                /*     var movie = _movierepository.GetMovieById(movieid);
                     if (movie.Quantity == 0)
                     {
                         movie.IsAviable = !movie.IsAviable;
                     }

                     movie.Quantity += 1;
               */

                user.RentedMovies.Remove(rental);
                user.RentedMoviesHistory.Add(rental);


                Console.WriteLine("Successfully returned");
                Thread.Sleep(2000);
                return;
            }
            else
            {
                throw new Exception("You do not have that movie rented.Please enter valid movie id");
            }

        }




        private void PrintMoviesInfo(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                string availability = movie.IsAviable ? "Yes" : "No";
                Console.WriteLine(string.Format
                    ("Rent id: {0} Title {1} Release Date {2} Genre {3} isAvailable {4} Quantity{5}", movie.Id
                    , movie.Title,
                    movie.ReleaseDate.ToString
                    ("MMMM dd yyyy"), movie.Genre, availability
                     , movie.Quantity
                   )
                    );
            }
        }


        private void PrintRentedInfo(List<RentalInfo> rentals)
        {
            foreach (var rental in rentals)
            {
                Console.WriteLine($"{rental.Movie.Title} rented from {rental.DateRented} to {rental.DateReturned}");

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
                    ReleaseDate = relasedate

                };

                var movies = _movierepository.GetAllMovies();
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
                var movie = _movierepository.GetMovieById(movieId);
                var movies = _movierepository.GetAllMovies();
                var premiers = _movierepository.GetMovieByIDPremiers(movieId);
                var getpremier = _movierepository.GetPremiers();
                var discounts = _movierepository.GetMoviesByIDDiscounts(movieId);
                var getdisucounts = _movierepository.GetDiscountMovies();


                //bug 

                /*      if (!movie.IsAviable)
                      {
                          throw new Exception($"Movie  is not avaiable at the moment");
  */
                //}

                Console.WriteLine($"Are you sure you want to delete the movie? y/n");
                bool confirm = InputParser.ToConfirm();
                Console.WriteLine("Deleting movie please wait...");
                LoadingHelpers.Spiner();
                getdisucounts.Remove(discounts);
                getpremier.Remove(premiers);
                movies.Remove(movie);
                Console.WriteLine($"You have deleted succesfully ");
                return null;

            }

        }









    }
}




