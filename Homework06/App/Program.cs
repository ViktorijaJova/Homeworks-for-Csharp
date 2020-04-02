using Sedc.Class06.Excersises.Buissnis.Models;
using Sedc.Class06.Excersises.Buissnis.Services;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;

namespace Class07.App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RunProgram = true;

            User[] userArray = new User[3];
            userArray[0] = new User("vik@gmail.com", "Viktorija11", "Viktorija", "Jovanovska" ,DateTime.Now);
            userArray[1] = new User("nik@gmail.com","Viktorija11","Nikol","Jovanov", DateTime.Now);
            userArray[2] = new User("kik@gmail.com", "Viktorija11", "Krist","Jovanovska", DateTime.Now);

            do
            {
                Console.WriteLine("Please choose 1 or 2:");
            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Register");

            string inputChoice = CheckInput();

            if (inputChoice == "1")
            {
                LogIn(userArray);
            }
            else if (inputChoice == "2")
            {
                RegisterUser(ref userArray);
            }

                Console.WriteLine("Do you want to choose another option again Y/N: ");
                RunProgram = RunAgain();

            } while (RunProgram);


            Console.ReadLine();


        }
        public static string CheckInput()
        {
            string input = Console.ReadLine();

            if ((input != "1") && (input != "2"))
            {
                Console.WriteLine("Please chose options 1 or 2:");
                input = CheckInput();
            }
            return input;
        }

        public static void LogIn(User[] listOfUsers)

        {
            var validationservice = new ValidationService();


            Console.WriteLine("Enter your Email address:");
            string email = Console.ReadLine();
            if (!validationservice.ValidateEmail(email))
            {
                Console.WriteLine("Enter a valid email address");
            }
         
            Console.WriteLine("Enter your Password:");
            string password = Console.ReadLine();

            if (!validationservice.ValidatePassword(password))
            {
                Console.WriteLine("Password is not valid, should be minimum 8characters 1 Upper-letter and 1 digit ");
            }

            foreach (User person in listOfUsers)
            {
                if ((person.Email == email) && (person.Password == password))
                {
                    Console.WriteLine($"Hello {person.GetFullName()} your personal ID is: {person.ID}\n");


                    Console.WriteLine("All of the other users are:");
                    foreach (User persons in listOfUsers)
                    {
                        Console.WriteLine(persons.GetInfo());
                    }
                }
            }
          

        }



        public static void RegisterUser(ref User[] listOfUsers)
        {
            bool foundUser = false;
            var validationservice = new ValidationService();

            Console.WriteLine("Please insert your email address:");
            string emailName = Console.ReadLine();

            while (!validationservice.ValidateEmail(emailName))
                {
                    Console.WriteLine("Enter a valid email address:");
                    emailName = Console.ReadLine();
            }
           
            
            
            foreach (User person in listOfUsers)
            {

                if ((person.Email == emailName))
                {
                    Console.WriteLine($"The email {emailName}  already exist!");
                    foundUser = true;
                    break;
                }
            }

            Console.WriteLine("Please insert your password:");
            string password = Console.ReadLine();
            while (!validationservice.ValidatePassword(password))
            {
                Console.WriteLine("Password is not valid, should be minimum 8characters 1 Upper-letter and 1 digit, please try again:");
                password = Console.ReadLine();
            }

            Console.WriteLine("Enter your Firstname:");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter your Lastname:");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter your date of birth: dd/MM/yyyy");
            string line = Console.ReadLine();
            DateTime dt;
            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                Console.WriteLine("Invalid date, please retry");
                line = Console.ReadLine();
            }

          

            if (!foundUser)
            {
                Array.Resize(ref listOfUsers, (listOfUsers.Length + 1));
                listOfUsers[listOfUsers.Length - 1] = new User(emailName, password, firstname,lastname,dt.Date);
                Console.WriteLine("Congrats! Registration is complete!");
                Console.WriteLine("Here are all the users:");
                
                foreach (User person in listOfUsers)
                {
                    Console.WriteLine(person.GetInfo());
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
}

    }