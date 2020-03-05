using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task01
            int num1 = 0;
            int num2 = 0;
            int operatior = 0;

            Console.WriteLine("Enter the first number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nHere are the options :\n");
            Console.WriteLine("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
            Console.WriteLine("\nInput your choice :");
            operatior = Convert.ToInt32(Console.ReadLine());

            switch (operatior)
            {
                case 1:
                    Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.Write("The second integer is zero. Devide by zero.\n");
                    }
                    else
                    {
                        Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);
                    }
                    break;

                case 5:
                    break;

                default:
                    Console.Write("Input correct option\n");
                    break;


            }

            #endregion

            #region task02
            double number1 = 0;
            double number2 = 0;
            double number3 = 0;
            double number4 = 0;

            Console.WriteLine("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
         number1, number2, number3, number4, result);

            #endregion

            #region task03

            int firstnumber1 = 0;
            int secondnumber2 = 0;
            int toswitch = 0;
            Console.WriteLine("\nInput the First Number : ");
            firstnumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the Second Number : ");
            secondnumber2 = int.Parse(Console.ReadLine());
            toswitch = firstnumber1;
            firstnumber1 = secondnumber2;
            secondnumber2 = toswitch;
            Console.WriteLine("\nAfter Swapping : ");
            Console.WriteLine("\nFirst Number : " + firstnumber1);
            Console.WriteLine("\nSecond Number : " + secondnumber2);

            #endregion

            #region taskswitch

            Console.WriteLine("Enter a number between 1 and 3");
            int number1to3 = Int32.Parse(Console.ReadLine());

            switch (number1to3)
            {
                case 1:
                    Console.WriteLine("You get a car, you get a car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");

                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            #endregion


            #region taskif
            int numberone = 0;
            int numbertwo = 0;
            int large = 0;

            Console.WriteLine("Enter first number : ");
            numberone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            numbertwo = Convert.ToInt32(Console.ReadLine());

            if (numberone > numbertwo)
                large = numberone;
            else
                large = numbertwo;

            Console.WriteLine("Largest number is {0}", large);

            int onenumber = 0;
            int checknumber = 0;
            Console.Write("Input a number : ");
            onenumber = Convert.ToInt32(Console.ReadLine());
            checknumber = onenumber % 2;
            if (checknumber == 0)
                Console.WriteLine("{0} is an even number.\n", onenumber);
            else
                Console.WriteLine("{0} is an odd number.\n", onenumber);

            #endregion



            Console.ReadLine();



        }

        }
}


