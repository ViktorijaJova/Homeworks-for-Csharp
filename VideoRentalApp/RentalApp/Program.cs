using sedc.videorental.data.DataBase;
using sedc.videorental.data.Models;
using sedc.videorental.Services.Helpers;
using sedc.videorental.Services.Menus;
using sedc.videorental.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace Sedc.videorental.App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Video Rental Store";



            var _userService = new UserService();
            var _movieService = new MovieService();
            var _adminService = new AdminService();
            User user = null;
           
            string errorMessage = string.Empty;

            Screen.HomeScreen();

            bool isLoggedIn = false;

            while (!isLoggedIn)
            {
                Screen.StartMenu();
                var startMenuInput = InputParser.ToInteger(1, 4);
                switch (startMenuInput)
                {
                    case
                    1:// login as admin
                        while (!isLoggedIn)
                        {
                            user = _adminService.LoginAsAdmin();

                            isLoggedIn = !isLoggedIn;
                        }
                        break;

                    case 2: //log in as user
                        while (!isLoggedIn)
                        {
                            user = _userService.Login();

                            isLoggedIn = !isLoggedIn;
                        }
                        break;
                    case 3: //sign up 
                        while (!isLoggedIn)
                        {
                            user = _userService.SignUp();
                            isLoggedIn = !isLoggedIn;
                        }
                   
                        break;
                    case 4: // exit application
                        Environment.Exit(0);
                        break;



                }
                Console.ReadLine();
            }

            if (!user.isAdmin)
            {

                while (true)
                {
                    Screen.ClearScreen();
                    Screen.ErrorMessage(errorMessage);
                    errorMessage = string.Empty;
                    if (user.IsSubscriptionExpired)
                    {
                       
                        Console.WriteLine("\nYour Subscription has expired and you won't be able to use the app,would you like to renew Subscription y/n ");
                        var readline = Console.ReadLine();
                        LoadingHelpers.Spiner();
                        if (readline == "y")
                        {

                            var renewed = user.SubscriptionRenwed = DateTime.Now;
                            user.IsSubscriptionExpired = !user.IsSubscriptionExpired;

                            Console.WriteLine($"\nThank you {user.FullName} your subscription has been renewed {renewed}!");
                        }
                         else  {
                            Console.WriteLine("Please renew your subscription if you want to continue using this app,Thank you!");
                            Thread.Sleep(3000);
                            break;

                        }
                  

                    }

                    Screen.MainMenu(user.FullName);
                    var selection = InputParser.ToInteger(1, 5);
                    switch (selection)
                    {
                        case 1:
                            _movieService.ViewMovieList(user);
                            break;


                        case 2:
                            _movieService.ViewRentedVideos(user);
                            break;


                        case 3:
                            try
                            {
                                _movieService.ViewRentedHistoryVideos(user);


                            }
                            catch (Exception ex)
                            {
                                errorMessage = ex.Message;
                            }
                            break;


                        case 4:
                            _movieService.ViewSpeicalOffers(user);
                            break;

                        case 5:
                            Console.WriteLine("Thank you for using rent a video app");
                            Thread.Sleep(3000);
                            Environment.Exit(0);
                            break;
                    }

                }

            }

            else
            {
                while (true)
                {
                    Screen.ClearScreen();
                    Screen.ErrorMessage(errorMessage);
                    errorMessage = string.Empty;
                    Screen.MainMenuforAdmin(user.FullName);
                    var selection = InputParser.ToInteger(1, 5);
                    switch (selection)
                    {
                        case 1://view movies
                            _adminService.ViewMovieListAsAdmin(user);

                            break;

                        case 2:// add movie
                            _adminService.AddMovieByAdmin();

                            //add movie
                            break;


                        case 3: // view users
                            _adminService.ViewUsersListAsAdmin(user);
                            break;


                        case 4:// remove movie
                            _adminService.RemoveMovieByAdmin();
                            break;
                        case 5: //exit 
                            Console.WriteLine("Your work day is over, hope you had fun, see you tomorrow :)");
                            Thread.Sleep(3000);
                            Environment.Exit(0);
                            break;




                    }

                    Console.ReadLine();

                }



            }
            
           
        }
       


    }
}
