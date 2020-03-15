using System;
using System.Linq;

namespace crvir19_homework
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task01
            Console.Write("Enter number higher than 2 and get all numbers that are dividable by 3: ");
            int length = Int32.Parse(Console.ReadLine());
            for (int j = 1; j <= length; j++)
            {
                if (j % 3 == 0)
                    Console.WriteLine(j);
            }

            #endregion

            #region task02


            Console.Write("Enter number higher than 5 and get numbers that are dividable by 2 and 3: ");
            int inputread = Int32.Parse(Console.ReadLine());
            if (inputread > 5)
                {
                    for (int i = 1; i <= inputread; i++)
                    {
                        if (i % 2 == 0 && i % 3 == 0)
                        {
                            Console.Write($"{i}" + " ");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Enter a number higher than 5");
                }

                #endregion

                #region task03

                Console.Write("Enter a number to get the product of the digits: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int product = 0;
            while (number != 0)
            {
                product += number % 10;
                number /= 10;
            }
            Console.WriteLine("Product of the digits of the number: " + product);

            #endregion

            #region task04 and 05 in one


            int totaleven = 0;
            int totalodd = 0;
            Console.WriteLine(" ENTER THE LIMIT IN WHICH YOU WANT TO SUM THE ODD AND EVEN NUMBERS");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int num = 0; num < limit; num++)
            {
                if (num % 2 == 0)
                {
                    totaleven = totaleven + num;
                }
                else
                {
                    totalodd = totalodd + num;
                }
            }

            Console.WriteLine(" \n sum of all even numbers are : {0} \n sum of all odd numbers are : {1}", totaleven, totalodd);
            #endregion

            #region task06

            Console.WriteLine("Enter a number and get the sum of all the numbers that divide by 5");
            int inputreadof = Int32.Parse(Console.ReadLine());
            int sums = 0;
            for (int i = 1; i <= inputreadof; i++)
            {
                if (i % 5 == 0)
                    sums += i;
            }
            Console.WriteLine(sums);
            #endregion

            #region task07
            char[] chararray = new char[] { 'a', 'b', 'c', 'd' };
            Console.WriteLine("Regular array:");
            Console.WriteLine(chararray);

            Array.Reverse(chararray);
        foreach (char n  in chararray)
                {

                    Console.Write(n);
                }


                #endregion


                #region task08 or  task08.1
                Boolean isArrayEqual = true;////

            Console.WriteLine("Compare if two arrays have the same length");
            Console.WriteLine("Enter numbers for first array ex:2345");
            int inputreads = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter numbers for second array ex:3445");
            int inputreads2 = int.Parse(Console.ReadLine());
            int[] arr1 = { 0 };
            int[] arr2 = { 0 };

            Array.Resize(ref arr1, arr1.Length + 1);
            arr1[arr1.Length - 1] = inputreads;
            Array.Resize(ref arr2, arr2.Length + 1);
            arr2[arr2.Length - 1] = inputreads2;


            isArrayEqual = arr1.SequenceEqual(arr2);

            if (isArrayEqual)
            {
                Console.WriteLine("Both arrays are equal");
            }
            else
            {
                Console.WriteLine("Both arrays are not equals");
            }

            int[] niza1 = new int[] { 1, 2, 3, 4 };
            int[] niza2 = new int[] { 1, 2, 3, 4 };

            if((niza1.SequenceEqual(niza2)) == true)
            {
                Console.WriteLine("Nizite se isti");
            }
            else
            {
                Console.WriteLine("Nizite ne se isti");
            }



            #endregion

            #region task09 and 10 

            Console.WriteLine("Enter a number:");

            int temp = int.Parse(Console.ReadLine());
            int sum = 0;
            int products = 1;
            while (temp != 0)
            {
                int d = temp % 10;
                temp /= 10;

                if (d > 0 && temp % d == 0)
                {
                    sum += d;
                    products *= d;
                }
            }

            Console.Write("Sum = " + sum);
            Console.Write("\nProduct = " + product);

            #endregion


            #region task11 
            int[] digits = new int[0];

            for (int i=10; i<100; i++)
            {
                int digit2 = i % 10;
                int digit1 =i/ 10;
                if (digit1 > digit2)
                {
                    Array.Resize(ref digits, digits.Length + 1);
                    digits[digits.Length - 1] = i;
                }

            }

            foreach(int n in digits)
            {
                Console.Write(n + " ");
            }
            #endregion


            #region task12
            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {

                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }

            }

            #endregion

            #region bonus sort of 

            Random rnd = new System.Random();
            int Random=0;
            Char go;
            bool lucky = false;
            Console.WriteLine("Welcome to the best Number Guessing Game");
            
            {
                lucky = false;
                Console.WriteLine("1.Easy (1-100)");
                Console.WriteLine("2.Medium (1-500)");
                Console.WriteLine("3.Hard (1-1000)");
                Console.WriteLine("Pick a Level  : ");
               int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                    Random = rnd.Next(1, 100);
                else if (choice == 2)
                    Random = rnd.Next(1, 500);
                else if (choice == 3)
                      Random = rnd.Next(1, 1000);
                Console.WriteLine(" Try To Guess The Number");
                while (lucky == false)
                {
                   int  pick = Convert.ToInt32(Console.ReadLine());
                    if (pick == Random)
                    {
                        Console.WriteLine("Congratulations! ,That Is the Number!!");
                        lucky = true;
                    }
                    else if (pick < Random)
                        Console.WriteLine("Try Guessing A Little Bit Higher");
                    else if (pick > Random)
                        Console.WriteLine("try Guessing A little Bit Lower");
                }
                Console.WriteLine(" If you want to play again type (y)");
                go = Convert.ToChar(Console.ReadLine());
            } while (go == 'y' );


            #endregion

            Console.ReadLine();

        }

    }
}



