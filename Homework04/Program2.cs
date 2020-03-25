using System;
using System.Linq;
using System.Threading;
namespace Homework04._1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            #region task04

            Console.WriteLine("Write a sentence: \n");
            string readstring = Console.ReadLine();
            int lengths = readstring.Length;
            char[] arrays = readstring.ToCharArray(0, lengths);

            Console.WriteLine("After the magic happens, the sentence is : \n");
            for (int i = 0; i < lengths; i++)
            {
                char characters = arrays[i];
                if (Char.IsLower(characters))
                    Console.Write(Char.ToUpper(characters));
                else
                    Console.Write(Char.ToLower(characters));
            }

            #endregion


            //task 3
            Console.WriteLine(" \n Enter a sentences and get how many digits and vowels are in it:");
            string str = Console.ReadLine();
            // string str = "my age is 22 years and my brothers is 26";
            CountVowlsandDigits(str);
            Thread.Sleep(1000);

            //task 2  
            int[] array = { 596, 304, 111, 6334, 4956, 33, 44566, 777, 444 };
            int number = array.Length;
            Console.WriteLine("The greatest number in the array is:" + " " + greatestnumber(array, number) + "\n");

            Thread.Sleep(1000);
            #region task01 or task1.01
            string reverse = "";
            Console.WriteLine(" Enter a word and check if its a palindrome or not");
            string readinputs = Console.ReadLine();
            for (int i = readinputs.Length - 1; i >= 0; i--)
            {
                reverse += readinputs[i].ToString();
            }
            if (reverse == readinputs)
            {
                Console.WriteLine("The Word is Palindrome \n You've entered  {0} and reverse  is {1}", readinputs, reverse);
            }
            else
            {
                Console.WriteLine("The word  is not Palindrome \n You've entered {0} and reverse  is {1}", readinputs, reverse);
            }

            Thread.Sleep(1000);
            #endregion


            //task 1
            Console.WriteLine(CheckPalindrome("level \n"));
            Console.WriteLine(CheckPalindrome("swim \n"));

            Console.ReadLine();


        }

        #region alsotask1.01
        public static bool CheckPalindrome(string word)
        {
            if (word.Length <= 1)
                return true;
            else
            {
                if (word[0] != word[word.Length - 1])
                    return false;
                else
                    return CheckPalindrome(word.Substring(1, word.Length - 2));

            }
        }
        #endregion

        #region alsotask 02

        public static int greatestnumber(int[] arr, int n)
        {

            return arr.Max();
        }

        #endregion



        #region alopartoftask03
        public static void CountVowlsandDigits(string str)
        {
            int vowels = 0;
            int digit = 0;


            for (int i = 0; i < str.Length; i++)
            {

                char character = str[i];

                if (character == 'a' || character == 'e' || character == 'i' ||
                    character == 'o' || character == 'u')
                    vowels++;


                else if (char.IsDigit(character))
                    digit++;
            }
            Console.WriteLine(" Number of vowels in the sentence: " + vowels + "\n");
            Console.WriteLine("Number of digits in the sentence: " + digit + "\n");

        }
        #endregion        }
    }
}
