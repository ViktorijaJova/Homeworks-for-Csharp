using System;


namespace Atm
{
    class Program
    {
        static void Main(string[] args)
        {

            User[] usersarray = new User[3];

            usersarray[0] = new User("Viktorija","123456","1234",2000);
            usersarray[1] = new User("Nikola", "987654","5678",20000);
            usersarray[2] = new User("Kristina", "147258", "9123", 5000);

            Console.WriteLine("Welcome to the ATM app");
            Console.WriteLine("Please enter your card number:");
            string inputcardnumber = (Console.ReadLine());

            if(inputcardnumber.Length != 6 )
            {
                Console.WriteLine("Invalid card number");
            }
            else
            {
                Console.WriteLine("Enter your pin number:");
                string inputpin = Console.ReadLine();

                if(inputpin.Length != 4)
                {
                    Console.WriteLine("Invalid pin number");
                }
                else
                {
                   foreach(User person in usersarray)
                    {
                        Console.WriteLine("Welcome " + person.Name);

                    }

                    Console.WriteLine("What would you like to do:");
                    Console.WriteLine("1 .Check Balance");
                    Console.WriteLine("2.Cash WithDraw");
                    Console.WriteLine("3.Cash Deposite");

                    int readinput = int.Parse(Console.ReadLine());

                    if(readinput == 1)
                    {
                        Console.WriteLine("This is your balance:");
                    }
                }

            }



            Console.ReadLine();


        }

    }
}
