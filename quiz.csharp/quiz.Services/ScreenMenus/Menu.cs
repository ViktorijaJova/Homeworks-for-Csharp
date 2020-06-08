using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace quiz.Services.ScreenMenus
{
  public  class Menu
    {


     
        public static void StartMenu()
        {
            Console.WriteLine("Welcome to school.");
            Console.WriteLine("1. Log in .");
            Console.WriteLine("2. Exit application.");
        }

        public static void MainMenuForTeacher(string name)
        {
            Console.WriteLine(string.Format("Welcome {0}.This are all lists of your students", name));
            Console.WriteLine("1.List of students that did the test");
            Console.WriteLine("2.List of students that haven't taken the test");
          
        }
        public static void MainMenuforStudent(string name)
        {
            Console.WriteLine(string.Format("Welcome {0}.  Your pop quiz starts now.", name));
            Console.WriteLine("Write the number in front of the answer that you think is correct: ");
            Thread.Sleep(1000);
        }
  
        public static void ClearScreen()
        {
            Console.Clear();
            StartMenu();
        }

    }

}
