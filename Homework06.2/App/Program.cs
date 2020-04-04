using Homework06.App.Models;
using Homework06.App.Services;
using System;

namespace Homework06.App
{
    class Program
    {
        static void Main()
        {

            User[] userArray = new User[3];
            userArray[0] = new User("Viktorija", 1234123412341234, "0000", 4000);
            userArray[1] = new User("Matea", 1234123412341234, "1111", 1000000);
            userArray[2] = new User("Nikola", 1234123412341234, "2222", 1000);

            while (true)
            {
                Console.WriteLine("Please select 1 or 2 or 3: ");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                string chosenOption = Functions.CheckInput();

                switch (chosenOption)
                {
                    case "1":
                        User logedInUser = Functions.ValidateUser(userArray);
                        Console.WriteLine($"Welcome {logedInUser.Username}!");

                        bool RunProgram1 = true;

                        do
                        {
                            Console.WriteLine("What do you want to do?");
                            Functions.PrinOptions();
                            Functions.AvailabelOptios(logedInUser, ref userArray);
                            Console.WriteLine("Do you want another transaction? Y/N ");
                            RunProgram1 = RunAgain();
                        } while (RunProgram1);
                        Console.WriteLine("Thank you for using our app. Good bye! ");
                        break;

                    case "2":

                        bool RunProgram2 = true;

                        do
                        {
                            Console.Write("Please insert User name: ");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Please enter your card number in the folowing format (ex.: 1234-1234-1234-1234)");
                            long cardNumber = Functions.CardNumberForRegister(userArray);
                            Console.WriteLine("Insert your pin number:");
                            string userPin = Console.ReadLine();
                            Console.WriteLine("Please insert balance you want to put in:");
                            double userBalance = Functions.StringToDouble();

                            Array.Resize(ref userArray, userArray.Length + 1);
                            userArray[userArray.Length - 1] = new User(userName, cardNumber, userPin, userBalance);

                            PrintUsers(userArray);

                            Console.WriteLine("Do you want another user registration? Y/N ");
                            RunProgram2 = RunAgain();

                        } while (RunProgram2);
                        Console.WriteLine("Thank you for using our app. Good bye! ");
                        break;

                    case "3":
                        Console.WriteLine("Thank you for using our app. Goodbye! ");
                        break;
                }
            }
        }

        public static bool RunAgain()
        {
            bool check;

            string input = Console.ReadLine();

            if (input == "Y" || input == "y")
            {
                check = true;
            }
            else if (input == "N" || input == "n")
            {
                check = false;
            }
            else
            {
                Console.WriteLine("Please enter Y or N");
                check = RunAgain();
            }
            return check;
        }



        public static void PrintUsers(User[] listOfUsers)
        {
            Console.WriteLine("The users are:");
            foreach (User person in listOfUsers)
            {
                Console.WriteLine(person.Username);
            }
        }


    }

  
}