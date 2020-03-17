using System;
using System.Threading;


namespace moretasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task01
            Console.WriteLine("Write true or false ");
            bool readinput = bool.Parse(Console.ReadLine());

              if (readinput == true)
            { 
                    Console.WriteLine(false);

            }

            else if(readinput != true)
            {
                Console.WriteLine(true);
            
            }
            Thread.Sleep(1000);
            #endregion
            

            #region task02


            Console.WriteLine("Enter a number");
            int reads = 0;
            bool readline = int.TryParse(Console.ReadLine(), out reads);
            if (readline)
            {
                if (reads % 100 == 0)
                {
                    Console.WriteLine("You have entered a cool number!");
                }

                else if (reads % 100 != 0)
                {
                    Console.WriteLine("The number you've enterd is not cool at all!");
                }
                }
                else
                {
                    Console.WriteLine("Can't you read? Enter a number, not anything else!");
                }

            Thread.Sleep(1000);
            #endregion

            #region task03

            Console.Write("Enter a number between 1-12: ");
             int monthinput = Convert.ToInt32(Console.ReadLine());

            switch (monthinput)
            {
                case 1:
                    Console.Write("January\n");
                    break;
                case 2:
                    Console.Write("February\n");
                    break;
                case 3:
                    Console.Write("March\n");
                    break;
                case 4:
                    Console.Write("April\n");
                    break;
                case 5:
                    Console.Write("May\n");
                    break;
                case 6:
                    Console.Write("June\n");
                    break;
                case 7:
                    Console.Write("July\n");
                    break;
                case 8:
                    Console.Write("August\n");
                    break;
                case 9:
                    Console.Write("September\n");
                    break;
                case 10:
                    Console.Write("October\n");
                    break;
                case 11:
                    Console.Write("November\n");
                    break;
                case 12:
                    Console.Write("December\n");
                    break;
                default:
                    Console.Write("Error, incorrect value \n");
                    break;
            }
            Thread.Sleep(1000);
            #endregion


            #region task04
            Console.WriteLine("Enter a probability of winning an arcade game:");
            int prob = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many prizes you would like to win:");
            int prize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how much money:");
            int pay = int.Parse(Console.ReadLine());

            if(prob * prize- pay > 0)
            {
                Console.WriteLine("You won");
            }
            else {
                Console.WriteLine("Sorry you lost");
            }

            Thread.Sleep(2000);
            #endregion


            #region task05
            Console.WriteLine("Enter how many chickens you want");
            int chickeninput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many cows you want");
            int cowsinput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many pigs you want");
            int pigsinput = int.Parse(Console.ReadLine());
            int count1 = chickeninput * 2;
            int count2 = cowsinput * 4;
            int count3 = pigsinput * 4;

            int result = count1 + count2 + count3;
            Console.WriteLine("Full count of legs of the animals" + result);
            Thread.Sleep(1000);

            #endregion

            #region task06


            Console.Write("Enter a sentence and we'll count how many words you have: ");
             string countwords = (Console.ReadLine());

            string[] sentences = countwords.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence.Split(' ').Length + " words in sentence *" + sentence + "*");
            }

            Thread.Sleep(2000);
            #endregion


            #region task07

            Console.WriteLine("Welcome to my Liquor Store");
            Console.WriteLine("Please enter your name:");
            string firstnameinput = (Console.ReadLine());
            Console.WriteLine("And your last name:");
            string lastnameinput = Console.ReadLine();
            Console.WriteLine("And your age, please:");
            int ageinput = int.Parse(Console.ReadLine());
            if(ageinput >= 18)
            {
                Console.WriteLine("What kind of drink would you like to purchase:");
                string oldenough = Console.ReadLine();

                Console.WriteLine("Dear "+ "" + firstnameinput +  " "  + lastnameinput + " "
                    + "here is your bottle of " + " " + oldenough + " " + "have a nice day! ");
            } 
            else if( ageinput < 18)
            {
                Console.WriteLine("Dear" +  " " +  firstnameinput + " " + lastnameinput + " " +
                    " I am sorry but you are not allowed to buy alchocol");
            }
            Thread.Sleep(2000);
            #endregion

            #region task08

            Console.WriteLine("Welcome dear customer! Please select a drink:");
            Console.WriteLine("1. Espresso...........2$" + "2.Macchiato........3, 5$" + "3.Latte..............4$"+
                "4.Cappuccino.........6$" + " 5.Tea..............1$") ;
            string typeofdrink = Console.ReadLine();
            Console.WriteLine("How much sugar would you like choose from 1 to 5");
            string suger = Console.ReadLine();
            int cost = 0;
            int sugar = 0;

            switch (typeofdrink)
            {
                case "1":
                    cost += 2;
                    break;
                case "2":
                    cost += 3;
                    break;
                case "3":
                    cost += 4;
                    break;
                case "4":
                    cost += 6;
                    break;
                case "5":
                    cost += 1;
                    break;

                default:
                    Console.WriteLine("Wrong choice.Please choose between 1-5");
                    break;
            }

            switch (suger)
            {
                case "1":
                    sugar = 0;
                    break;
                case "2":
                    sugar = 0;
                    break;
                case "3":
                    sugar =0;
                    break;
                case "4":
                    sugar =0;
                    break;
                case "5":
                    sugar = 0;
                    break;

                default:
                    Console.WriteLine("No sugar it is");
                    break;
            }
                if (cost != 0)
            {
                Console.WriteLine("Pay {0} cent \nThank you", cost);
                int inputcost = int.Parse(Console.ReadLine());

                if(cost == inputcost)
                {
                    Console.WriteLine("Thank you for your purchase your drink will be ready in a bit");
                }
                if (cost != inputcost)
                {
                    Console.WriteLine("The drink cost" + "" + cost+ ""+ " you are missing " + "" + (cost - inputcost) + "" + " to buy it");
                    int secondcost = int.Parse(Console.ReadLine());
                    if (secondcost == (cost - inputcost))
                    {
                        Console.WriteLine("Thank you for your purchese your drink will be ready in a bit");
                    }
                    else if (secondcost != (cost - inputcost))
                    {
                        Console.WriteLine("I'm sorry that is incorrect, just go to a diffrent shop");
                    }
                   
        
            }
            }
            Thread.Sleep(2000);


            #endregion


            #region task09

            Console.WriteLine("Prediction of your future:");
            Random numero = new Random();
            int number =  numero.Next(1, 5);

           
            if(number == 1)
            {
                Console.WriteLine("Congrats you son of a b,You get to go on an adventure with Rick and Morty Wubba Lubba DubDub");
            }
            else if(number == 2)
            {
                Console.WriteLine("Congradulation, you have become a Pokemon Trainer");
            }
            else if(number == 3)
            {
                Console.WriteLine("Your future looks as ugly as you do, Bazinga");

            }
            else if(number == 4)
            {
                Console.WriteLine("Stop taking this stupid tests about your future, and get off that lazy ass and do something about it");
            }
            else if (number == 5)
                    {
                Console.WriteLine("We have to go back, Marty, We must go back to the future");

            }

            Thread.Sleep(2000);

            #endregion


            #region task10

            Console.Write("Enter the temperature in celsius: ");
            int celsius = int.Parse(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);

            #endregion
            Console.ReadLine();

        }
    }

}
