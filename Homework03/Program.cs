using System;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)


        {
            #region task01
            int inputsofnumbers = 0;
            int[] arr = new int[6];

            Console.Write("Enter Six Numbers :");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    inputsofnumbers = inputsofnumbers + arr[i];
                }

            }
            Console.WriteLine("\nSum of even numbers :" + inputsofnumbers);

            #endregion

            #region task02
            string[] groupofstudents1 = new string[] { "Ate", "Kate", "Mate", "Koko", "KIki" };
            string[] groupofstudents2 = new string[] { "Koki", "Nate", "Caci", "Eci", "Tedi" };

            Console.WriteLine(" Choose your Student Group ");
            Console.WriteLine("Enter 1 to get first group \n  2 to get the second group");
            int readinput = int.Parse(Console.ReadLine());
            for (int i = 0; i < groupofstudents1.Length; i++)
            {
                if (readinput == 1)
                {
                    Console.WriteLine(groupofstudents1[i]);
                }
                else if (readinput == 2) {
                    Console.WriteLine(groupofstudents2[i]);
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            }
        
            
                #endregion



                #region task03
                int numbers = 0;
                int[] arrofnumbers = new int[5];

                Console.Write("Enter Five Numbers :");

            for (int i = 0; i < arrofnumbers.Length; i++)
            {
                arrofnumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrofnumbers.Length; i++)
            { 
                  numbers = numbers + arrofnumbers[i];
             
            }
            Console.WriteLine("\nSum of numbers :" + numbers);

            #endregion


            Console.ReadLine();

        }

    }

    }

   

 





 