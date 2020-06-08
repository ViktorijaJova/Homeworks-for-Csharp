using quiz.data;
using quiz.data.Models;
using quiz.Services.ScreenMenus;
using quiz.Services.Services;
using System;
using System.Collections.Generic;
using System.Threading;
using static quiz.Services.Services.InputParser;

namespace quiz.csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "School";



            var _Service = new UserService();
            var _userRepository = new UserRepository();
            User user = null;

            string errorMessage = string.Empty;


            bool isLoggedIn = false;

            while (!isLoggedIn)
            {
                Menu.StartMenu();
                var startMenuInput = InputParser.ToInteger(1, 2);
                switch (startMenuInput)
                {
                    case
                    1:// login
                        while (!isLoggedIn)
                        {
                            user = _Service.Login();
                            isLoggedIn = !isLoggedIn;
                        }
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;
                }

             
            }
        
            Console.ReadLine();

        





            }
        }
    }

