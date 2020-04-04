using Homework06.App.Models;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework06.App.Services
{
    public class Functions

    {

        public static void PrintUsers(User[] listOfUsers)
        {
            Console.WriteLine("The users are:");
            foreach (User person in listOfUsers)
            {
                Console.WriteLine(person.Username);
            }
        }

        public static string RemoveDash(string input)
        {
            string result = input.Replace("-", "");
            return result;
        }

        public static void PrinOptions()
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Cash Withdrawal");
            Console.WriteLine("3. Cash Deposit");
        }

        public static string ProperString()
        {
            string cardNumber = Console.ReadLine();

            string check = "";
            if (cardNumber.Length != 19)
            {
                Console.WriteLine("Your card number is invalid!! (not enough or too much characters)");
                Console.WriteLine("Please try again (you need to enter folowing format of 19 characters ex.: 1234-1234-1234-1234)");
                check = ProperString();
            }
            else if (RemoveDash(cardNumber).Length != 16)
            {
                Console.WriteLine("Your number is not in the right format");
                Console.WriteLine("Please try again");
                check = ProperString();
            }

            else
            {
                check = cardNumber;
            }
            return check;
        }

        public static long CheckCardNumber(User[] listOfUsers)
        {
            string cardNumber = RemoveDash(ProperString());

            long randomNumber;
            bool checkInt = long.TryParse(cardNumber, out randomNumber);
            if (!checkInt)
            {
                Console.WriteLine("Please enter valid number!");
                randomNumber = CheckCardNumber(listOfUsers);
            }
            return randomNumber;
        }

        public static long CardNumberForLogin(User[] listOfUsers)
        {
            long check = 0;
            long cardNumber = CheckCardNumber(listOfUsers);

            foreach (User person in listOfUsers)
            {
                if (person.CardNumber == cardNumber)
                {
                    check = cardNumber;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("There is no card with that number!!");
                Console.WriteLine("Please try again");
                check = CardNumberForLogin(listOfUsers);
            }
            return check;
        }

        public static long CardNumberForRegister(User[] listOfUsers)
        {

            long cardNumber = CheckCardNumber(listOfUsers);
            long check = cardNumber;

            foreach (User person in listOfUsers)
            {
                if (person.CardNumber == cardNumber)
                {
                    check = 0;
                }
            }

            if (check == 0)
            {
                Console.WriteLine("That card number is already taken!");
                Console.WriteLine("Please try with different number");
                check = CardNumberForRegister(listOfUsers);
            }
            return check;
        }

        public static string CheckCardPin(User[] listOfUsers)
        {
            string check = "";
            string cardPin = Console.ReadLine();

            foreach (User person in listOfUsers)
            {
                if (person.GetPin() == cardPin)
                {
                    check = cardPin;
                }
            }
            if (check == "")
            {
                Console.WriteLine("That is not the pin for this card!!");
                Console.WriteLine("Please try again");
                check = CheckCardPin(listOfUsers);
            }
            return check;
        }

        public static string CheckInput()
        {
            string input = Console.ReadLine();

            if ((input != "1") && (input != "2") && (input != "3"))
            {
                Console.WriteLine("Please chose options from 1 or 2 or 3");
                input = CheckInput();
            }
            return input;
        }

        public static User ValidateUser(User[] listOfusers)
        {
            Console.WriteLine("Please enter your card number (ex.: 1234-1234-1234-1234)");
            long inputCard = CardNumberForLogin(listOfusers);

            Console.WriteLine("Please enter your pin");
            string cardPin = CheckCardPin(listOfusers);

            User logedInUser = null;

            foreach (User person in listOfusers)
            {
                if (person.CardNumber == inputCard)
                {
                    logedInUser = person;
                    break;
                }
            }

            return logedInUser;
        }

        public static void CahsWithdrawal(ref User person)
        {
            Console.WriteLine($"Your balance is: {person.GetBalance()}");
            Console.Write("Write the amount you want to Withdraw: ");
            double moneyToWithdraw = StringToDouble();

            if (person.GetBalance() >= moneyToWithdraw)
            {
                person.CashWithdraw(moneyToWithdraw);
                Console.WriteLine($"You withdrew {moneyToWithdraw}$. You have {person.GetBalance()}$ left on your account.");
            }
            else
            {
                Console.WriteLine("You don have that amount of money to withdraw");
                Console.WriteLine("Please try again with lower amount");
                CahsWithdrawal(ref person);
            }
        }

        public static double StringToDouble()
        {
            double randomNumber;
            bool check = double.TryParse(Console.ReadLine(), out randomNumber);

            if (!check)
            {
                Console.WriteLine("Please enter valid number");
                randomNumber = StringToDouble();
            }
            return randomNumber;
        }

        public static void UpdateUserInDatabase(ref User[] listOfUsers, User userToUpdate)
        {
            for (int i = 0; i < listOfUsers.Length; i++)
            {
                if ((listOfUsers[i].CardNumber == userToUpdate.CardNumber) && (listOfUsers[i].GetPin() == userToUpdate.GetPin()))
                {
                    listOfUsers[i] = userToUpdate;
                }

            }
        }

        public static void CashDeposit(ref User person)
        {
            Console.WriteLine($"Your balance is: {person.GetBalance()}");
            Console.Write("Write the amount you want to deposit: ");
            double moneyToDeposit = StringToDouble();

            person.CashDeposit(moneyToDeposit);
            Console.WriteLine($"Your balance now is: {person.GetBalance()}. You deposit {moneyToDeposit}");

        }

        public static void AvailabelOptios(User logedInUser, ref User[] userArray)
        {
            string chosenOption = CheckInput();

            switch (chosenOption)
            {
                case "1":
                    Console.WriteLine($"Your balance is: {logedInUser.GetBalance()}");
                    break;
                case "2":
                    CahsWithdrawal(ref logedInUser);
                    UpdateUserInDatabase(ref userArray, logedInUser);
                    break;
                case "3":
                    CashDeposit(ref logedInUser);
                    UpdateUserInDatabase(ref userArray, logedInUser);
                    break;
            }
        }

      
    }

}
