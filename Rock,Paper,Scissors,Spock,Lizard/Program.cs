using System;
using System.Threading;

namespace Exampleofrockpaperscissors
{
    class Program
    {

        static void Main(string[] args)
        {
            string computerchoice;
            bool playAgain = true;
            Console.WriteLine("Welcome to the ultimate Rock,Paper,Scissors,Lizard,Spock Game \n");
            Thread.Sleep(1000);


            while (playAgain)
            {
                int playersscore = 0;
                int computersscore = 0;

                while (playersscore < 5 && computersscore < 5)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Choose:Rock,Paper,Scissors,Lizard,Spock (note:first letter UpperCase)");
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

                                computersscore++;
                            }
                            else if (playerchoice == "Paper")
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Scissors beat Paper, you lose \n");

                                playersscore++;
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

                if (playersscore == 5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You won, Congradulation!\n");
                }
                else if (computersscore == 5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Sorry the computer won, better luck next time!\n");
                }

            
            Console.WriteLine("Would you like to play again yes/no\n");
            string reads = Console.ReadLine();

            if (reads == "yes")
            {
                playAgain = true;
            }
            else if (reads == "no")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Sorry to see you go, Have a nice day!\n");
                playAgain = false;
                break;
            }
        }

            Console.ReadLine();
        }
    }
}
