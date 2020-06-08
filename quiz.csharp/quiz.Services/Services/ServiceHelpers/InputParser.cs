using System;
using System.Collections.Generic;
using System.Text;

namespace quiz.Services.Services
{
    public class InputParser
    {
       

            private static readonly List<string> _validConfirmInput = new List<string> { "Y", "y", "yes", "Yes", "1", "True" };
            private static readonly List<string> _validDeclineInput = new List<string> { "n", "N", "No", "no", "0", "False" };
            public static int ToInteger(int min, int max)
            {
                int parsedNumber = 0;
                bool isValid = false;

                while (!isValid)
                {
                    try
                    {
                        parsedNumber = int.Parse(Console.ReadLine());
                        if (!(parsedNumber >= min && parsedNumber <= max))
                        {
                            throw new Exception($"Please select from given input range from {min} to {max}");
                        }
                        isValid = !isValid;
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Please enter argument");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Not valid input");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number is too large or too low");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                return parsedNumber;
            }

        
        public static bool ToConfirm()
        {
            bool isValidInput;
            while (true)
            {
                var value = Console.ReadLine();
                if (_validConfirmInput.Contains(value))
                {
                    isValidInput = true;
                    break;
                }
                else if (_validDeclineInput.Contains(value))
                {
                    isValidInput = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                    Console.WriteLine($"Valid inputs:{string.Join(",", _validConfirmInput.ToArray())}{string.Join(",", _validDeclineInput.ToArray())}");
                }

            }
            return isValidInput;
        }
    }


}
