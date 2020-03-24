using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)

        {
            //task 0.0

            string first = "Hello from SEDC Codecademy v7.0";
            Console.WriteLine(first);

            Console.WriteLine("Enter a number between 1 and 30");
            int n = int.Parse(Console.ReadLine());

            first = first.Substring(n);
            Console.WriteLine(first);

            Thread.Sleep(2000);

            //task 08
            Console.WriteLine(" Enter todays date: ex:24");
            int current_date = int.Parse(Console.ReadLine());
            Console.WriteLine("And the month: ex:11");
            int current_month = int.Parse(Console.ReadLine());
            Console.WriteLine("And the year: ex:2022");
            int current_year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birth date: ex:20"); ;
            int birth_date = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birth month: ex:03 ");
            int birth_month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birth year: ex:2000");
            int birth_year = int.Parse(Console.ReadLine());

            AgeCalculator(current_date, current_month,
                       current_year, birth_date,
                       birth_month, birth_year);

            #region task07

            Console.WriteLine("Input a number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a number that you want to raise to the first number : ");
            int raiser1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" The number {0} ^ (raised to the other integer) {1} = {2} ", number1, raiser1, Numbers(number1, raiser1));

            #endregion


            #region task06
            int start = 0;
            int count = -1;
            int index = -1;


            Console.Write("Enter any sentence or text or whatever you want : ");
            string readfirstinput = Console.ReadLine();
            Console.Write("Enter a word that you want to find out how many times it's in the sentences or text: ");
            string readsecondinput = Console.ReadLine();


            while (start != -1)
            {
                start = readfirstinput.IndexOf(readsecondinput, index + 1);
                count += 1;
                index = start;
            }
            Console.Write("The word '{0}' occurs " + count + " times in the sentence.\n", readsecondinput);


            #endregion

            #region task05

            Console.WriteLine("\n\nCheck whether a character is alphabet if so check for case :\n");
            Console.WriteLine("Enter a character: \n");
            char alphabets = (char)Console.Read();
            if (Char.IsLetter(alphabets))
            {
                if (Char.IsUpper(alphabets))
                {
                    Console.WriteLine("\nIt is a charachter and the character is UpperCase.\n");
                }
                else
                {
                    Console.WriteLine("\nIt' is a character and the character is lowercase.\n");
                }
            }
            else
            {
                Console.WriteLine("\nThe entered character is not an alphabetic character.\n");
            }
            Thread.Sleep(1000);
            #endregion

           
            Console.ReadLine();

            Console.ReadLine();

        }


        
        #region alsotask07
        public static int Numbers(int number, int raiser)
        {
            int value = 1;
            int i;
            for (i = 1; i <= raiser; i++)
                value = value * number;
            return value;
        }
        #endregion

        #region alsotask08.1
        public static void AgeCalculator(int current_date,
                      int current_month,
                       int current_year,
                         int birth_date,
                        int birth_month,
                         int birth_year)
        {
            int[] month = { 31, 28, 31, 30, 31, 30,
                      31, 31, 30, 31, 30, 31 };

            
            if (birth_date > current_date)
            {
                current_month = current_month - 1;

                current_date = current_date
                          + month[birth_month - 1];
            }

         
            if (birth_month > current_month)
            {
                current_year = current_year - 1;
                current_month = current_month + 12;
            }

            int calculated_date = current_date
                                     - birth_date;

            int calculated_month = current_month
                                    - birth_month;

            int calculated_year = current_year
                                     - birth_year;

            Console.WriteLine(" Your present Age");
            Console.WriteLine("Years: "
                               + calculated_year +
                    " Months: " + calculated_month
                   + " Days: " + calculated_date);
        }
        #endregion


        public static void Substring(string first)
        {

        }
    }


}











