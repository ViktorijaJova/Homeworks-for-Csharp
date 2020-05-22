using sedc.videorental.data.DataBase;
using sedc.videorental.data.Models;
using sedc.videorental.Services.Helpers;
using sedc.videorental.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace sedc.videorental.Services.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();

        }

        public User Login()
        {
            while (true)
            {
                Console.Write("Enter Card id Number:");
                var idCard = InputParser.ToInteger(100, 999);

                var user = _userRepository.GetUserByIdCard(idCard);

                if (user != null)
                {
                    Console.WriteLine($"Welcome {user.FullName}");
                    return user;
                }
                Console.WriteLine("user card id does not excist");
                Console.WriteLine("Try again y/n");
                if (!InputParser.ToConfirm())
                {
                    Console.WriteLine("Thank you for using rent a video app");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }

            }
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

            public User SignUp()
        {
            while (true)
            {
                Console.WriteLine("Enter Full Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter date of birth:");
                DateTime dob = InputParser.ToDateTime();
                int cardNumber = GenerateNewCardNumber();

                Console.WriteLine("Creating user please wait:....");

                var user = new User
                {
                    CardNumber = cardNumber,
                    FullName = name,
                    DateofBirth = dob
                };
                Console.WriteLine($"\r Welcome {user.FullName}{user.CardNumber}");
                return user;



            }

        }



        private int GenerateNewCardNumber()
        {
            const int max = 1000;
            const int min = 100;

            var rand = new Random();
            var takenCardNumbers = _userRepository.GetAllCardNumbers();


            int cardNumber;
            do
            {
                cardNumber = rand.Next(min, max);
            }
            while (takenCardNumbers.Contains(cardNumber));
            return cardNumber;



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
                    var readline = InputParser.ToConfirm();
                  
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
                    Console.WriteLine("No users available, you messed up!");
                }

                isFinished = !isFinished;
            }

        }


        private void PrintUsersInfo(List<User> users)
        {

            foreach (var user in users)
            {
              if(user.isAdmin != true)
                {
                    Console.WriteLine(user.FullName);
                }
            }
        }




    }
}