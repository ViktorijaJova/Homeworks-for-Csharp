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



       

  




    }
}