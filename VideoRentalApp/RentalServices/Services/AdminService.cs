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
     public class AdminService: UserRepository
    {

        private AdminRepository _adminRepository;

        public AdminService()
        {
            _adminRepository = new AdminRepository();

        }

        public User LoginAsAdmin()
        {
            while (true)
            {
                Console.Write("Enter Admin Card id Number:");
                var idCard = InputParser.ToInteger(100, 999);

                var user = _adminRepository.GetUserByIdCard(idCard);

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
            var listofusers = _adminRepository.GetAllUsers();
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



    }
}
