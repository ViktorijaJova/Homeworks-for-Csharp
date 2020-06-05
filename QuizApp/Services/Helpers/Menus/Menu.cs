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
            Console.WriteLine(string.Format("Welcome {0}.This are all of your students", name));
            Console.WriteLine("1.List of students that did the test");
            Console.WriteLine("2.List of students that haven't taken the test");
          
        }
        public static void MainMenuforStudent(string name)
        {
            Console.WriteLine(string.Format("Welcome {0}.  Your pop quiz starts now.", name));
            Console.WriteLine("Write the number in front of the answer that you think is correct: ");
            Thread.Sleep(1000);
    /*        Console.WriteLine("Q: What is the capital of Tasmania?");
            Console.WriteLine("1.Dodoma 2.Hobart 3.Laucenston 4.Welligton");*/
          

        }
/*
        public static void SecondQuestion()
        {
            Console.WriteLine("Q: What is the tallest building in the Republic of the Congo?");
            Console.WriteLine("1.Kinshasa Democratic Republic of the Congo Temple 2. Palais de la Nation 3.Kongo Trade Centre 4. Nabemba Tower");
        }

        public static void ThirdQuestion()
        {
            Console.WriteLine("Q: Which of these is not one of Pluto's moons?");
            Console.WriteLine("1. Styx 2.Hydra 3.Nix 4.Lugia");
        }

        public static void ForthQuestion()
        {
            Console.WriteLine("Q: What is the smallest lake in the world?");
            Console.WriteLine("1.Onega Lake 2.Benxi Lake 3.Kivu Lake 4.Wakatipu Lake");
        }
        public static void FifthQuestion()
        {
            Console.WriteLine("Q: What country has the largest population of alpacas?");
            Console.WriteLine("1.Chad 2.Peru 3.Australia 4.Niger");
        }
*/
        public static void ClearScreen()
        {
            Console.Clear();
            StartMenu();
        }

    }

}
