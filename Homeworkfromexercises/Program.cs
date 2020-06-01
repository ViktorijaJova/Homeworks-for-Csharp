using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;

namespace excersies.class01.csharpadvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01

            // just one name  


            Console.WriteLine("Write a name:");
            string readname = Console.ReadLine();


            Console.WriteLine("Write text and see how many times the name  appears in the text");
            string readtext = Console.ReadLine();


            int count = Regex.Matches(readtext, readname).Count;
            Console.WriteLine("Number of occurences:" + count);


            //or

            List<string> names = new List<string>();

            bool isrunning = false;
            while (!isrunning)
            {
                Console.WriteLine("Enter names and press x whne you done");
                string inputedinames = Console.ReadLine();

                if (inputedinames.ToLower() == "x")
                {
                    break;
                }
                names.Add(inputedinames);
            }
            Console.WriteLine("Enter the text to see how many times the names are in it");
            string inputedtext = Console.ReadLine();


            GetNames(names, inputedtext);

            #endregion


            #region 02

            Console.WriteLine("Enter date");

            DateTime dateValue = DateTime.Parse(Console.ReadLine());

            var dd = dateValue.ToString("dddd");
            Console.WriteLine(dateValue.ToString("dddd"));



            if (dd == "Sunday" || dd == "Saturday")
            {
                Console.WriteLine("Its a weekend not a work day");

            }
            else if (dateValue.Month == 1 && dateValue.Day == 1 || dateValue.Month == 1 && dateValue.Day == 7 || dateValue.Month == 4 && dateValue.Day == 20
              || dateValue.Month == 5 && dateValue.Day == 1 || dateValue.Day == 20 && dateValue.Month == 5 || dateValue.Month == 5 && dateValue.Day == 25 || dateValue.Day == 3 && dateValue.Month == 8)
            {
                Console.WriteLine("It's a holiday");
            }

            else
            {
                Console.WriteLine("It's a work day");
            }



            #endregion




            #region 03

            bool game = false;

            while (!game) {
                Console.WriteLine("1.Play 2.Exit");
                var inputo = Console.ReadLine();
            
                int playerall = 0;
                int computerall = 0;
                switch (inputo)
                {
                    case "1":
                        bool playAgain = true;
                        Console.WriteLine("Welcome to the ultimate Rock,Paper,Scissors,Lizard,Spock Game \n");

                        while (playAgain)
                        {
                          
                            int playersscore = 0;
                            int computersscore = 0;
                            while (playersscore < 2  &&  computersscore < 2)
                            {
                                string computerchoice;

                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Choose:Rock,Paper,Scissors,Lizard,Spock ");
                                string playerchoice = Console.ReadLine();
                                Random inputs = new Random();
                                int randomchoice = inputs.Next(1, 6);

                                switch (randomchoice)
                                {
                                    case 1:
                                        computerchoice = "Rock";
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine("The computer chose Rock \n");

                                        if (playerchoice == "Rock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("It's a Draw \n");
                                        }

                                        else if (playerchoice == "Paper")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Paper beats Rock, you win \n");
                                            playersscore++;
                                        }
                                        else if (playerchoice == "Scissors")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Rock beats Scissors, you lose \n");
                                            computersscore++;
                                        }
                                        else if (playerchoice == "Lizard")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Rock smashes Lizard, you lose \n");
                                            computersscore++;
                                        }
                                        else if (playerchoice == "Spock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Spock vaporizes Rock, you win");
                                            playersscore++;
                                        }
                                        break;
                                    case 2:
                                        computerchoice = "Paper";
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine("The computer chose Paper \n");

                                        if (playerchoice == "Paper")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("It's a draw \n");

                                        }
                                        else if (playerchoice == "Rock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Paper beats Rock, you loose \n");


                                            computersscore++;
                                        }
                                        else if (playerchoice == "Scissors")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Scissors beats Paper, you won \n");

                                            playersscore++;
                                        }
                                        else if (playerchoice == "Spock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Paper disproves Spock, you lose \n");
                                            computersscore++;
                                        }
                                        else if (playerchoice == "Lizard")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Lizard eats paper, you won");
                                            playersscore++;
                                        }
                                        break;
                                    case 3:
                                        computerchoice = "Scissors";
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine("The computer chose Scissors\n");
                                        if (playerchoice == "Scissors")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("It's a draw \n");

                                        }
                                        else if (playerchoice == "Rock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Rock beats Scissors,you win \n");

                                            playersscore++;
                                        }
                                        else if (playerchoice == "Paper")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Scissors beat Paper, you lose \n");

                                            computersscore++;


                                        }
                                        else if (playerchoice == "Lizard")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Scissors decapitates Lizard, you lose \n");
                                            computersscore++;
                                        }
                                        else if (playerchoice == "Spock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Spock smashes Scissors, you win \n");
                                            playersscore++;
                                        }
                                        break;
                                    case 4:
                                        computerchoice = "Lizard";
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine("The computer chose Lizard\n");
                                        if (playerchoice == "Lizard")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("It's a draw \n");
                                        }
                                        else if (playerchoice == "Spock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Lizard poisons Spock, sorry you lose \n");
                                            computersscore++;
                                        }
                                        else if (playerchoice == "Rock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Rock crushes Lizard, you win\n");
                                            playersscore++;
                                        }
                                        else if (playerchoice == "Paper")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Lizard eats paper, you lose\n");
                                            computersscore++;
                                        }
                                        else if (playerchoice == "Scissors")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Scissors decapitate lizard, you win \n");
                                            playersscore++;
                                        }
                                        break;
                                    case 5:
                                        computerchoice = "Spock";
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine("The computer chose Spock\n");
                                        if (playerchoice == "Spock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("It's a draw \n");
                                        }
                                        else if (playerchoice == "Lizard")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Lizard poisones Spock,you win\n");
                                            playersscore++;
                                        }
                                        else if (playerchoice == "Rock")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Spock vaporizes Rock, you lose \n");
                                            computersscore++;
                                        }
                                        else if (playerchoice == "Paper")
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Paper disproves Spock,you win \n");
                                            playersscore++;
                                        }
                                        else if (playerchoice == "Scissors")
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Spock smashes scissors, you lose \n");
                                            computersscore++;
                                        }

                                        break;
                                    default:
                                        Console.WriteLine("Invalid input \n");

                                        break;
                                }

                            }

                            if (playersscore == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("You won, Congradulation!\n");
                                playerall++;
                                
                            }
                            else if (computersscore == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Sorry the computer won, better luck next time!\n");
                                computerall++;
                            }


                            Console.WriteLine("Would you like to play again yes/no\n");
                            string readss = Console.ReadLine();

                            if (readss == "yes")
                            {
                                playAgain = true;
                            }
                            else if (readss == "no")
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Sorry to see you go, Have a nice day!\n");
                                Console.WriteLine("Would you like to see the scores yes/no");
                                string readyesno = Console.ReadLine();

                                if (readyesno == "yes")
                                {
                                    Console.WriteLine("Your score" + playerall);
                                    Console.WriteLine("Computer score" + computerall);
                                    break;
                                }
                                else
                                {

                                    playAgain = false;
                                    break;
                                }
                            }
                        }
                        break;


                    case "2":
                        Environment.Exit(0);
                        break;
                   
                }

         
            }
        }


        #endregion

       

        public static void GetNames(List<string> names, string inputedtext)
        {
            foreach(var name in names)
            {
                var get = new Regex(name);
                var count = get.Matches(inputedtext).Count;
                Console.WriteLine("Number of times the name was in the text was " + count);
            }
        }



        }

    
    }





