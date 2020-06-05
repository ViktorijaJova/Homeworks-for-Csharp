using quiz.data;
using quiz.data.Models;
using quiz.Services.ScreenMenus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static quiz.Services.Services.Helpers;

namespace quiz.Services.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }



        public User Login()
        {
            int counter = 0;

            while (true)

            {
                var counters = 0;
                Console.Write(" Welcome please:Enter Your Name:");
                var readname = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                var readpass = int.Parse(Console.ReadLine());
                var user = _userRepository.GetUserPassword(readpass);
                user = _userRepository.GetUserName(readname);


                if (user != null && user.Name == readname && user.Password == readpass && user.TestDone == false)
                {
                    counters++;
                   

                    if (user.isTeacher == true)
                    {
                        bool isistrue = false;

                        while (!isistrue)
                        {
                            Menu.MainMenuForTeacher(user.Name);

                            var readinput = Helpers.ToInteger(1, 2);
                            var list = _userRepository.GetStudents();



                            switch (readinput)
                            {
                                case 1:

                                    foreach (var student in list)
                                    {
                                        if (student.TestDone == true)
                                        {

                                            Console.ForegroundColor = ConsoleColor.Green;

                                            Console.WriteLine($"{student.Name}");
                                            Console.ResetColor();



                                        }

                                    }
                                    Console.WriteLine("Press x to exit");
                                    var readline = Console.ReadLine();
                                    if (readline == "x")
                                    {
                                        Console.Clear();
                                        isistrue = !isistrue;
                                    }


                                    break;
                                case 2:
                                    foreach (var student in list)
                                    {
                                        if (student.TestDone == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;

                                            Console.WriteLine($"{student.Name}");
                                            Console.ResetColor();


                                        }


                                    }
                                    Console.WriteLine("Press x to exit:");
                                    var readlineo = Console.ReadLine();
                                    if (readlineo == "x")
                                    {
                                        Console.Clear();
                                        isistrue = !isistrue;
                                    }

                                    break;

                            }

                        }


                    }
                    else if (!user.isTeacher)
                    {
                        List<int> answers = new List<int>();
                        bool istrue = false;
                        List<Question> questions = _userRepository.AllQuestions();

                        while (!istrue)
                        {
                            Menu.MainMenuforStudent(user.Name);


                            foreach (var question in questions)
                            {

                                Console.WriteLine($"{question.Questions}");
                                Console.WriteLine($"{question.FirstChoice}");
                                Console.WriteLine($"{question.SecondChoice}");
                                Console.WriteLine($"{question.ThirdChoice}");
                                Console.WriteLine($"{question.ForthChoice}");

                                var readanswer = int.Parse(Console.ReadLine());
                                if (readanswer == question.Corect)
                                {
                                    counter++;
                                    Console.WriteLine("Correct");

                                }

                                /* var readanswers = Helpers.ToInteger(1, 4);
                                 switch (readanswers)
                                 {
                                     case 1:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 2:
                                         Console.WriteLine("Correct");
                                         counter++;

                                         break;
                                     case 3:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 4:
                                         Console.WriteLine("Incorect");
                                         break;
                                 }
                                 Menu.SecondQuestion();
                                 var readanswer2 = Helpers.ToInteger(1, 4);
                                 switch (readanswer2)
                                 {
                                     case 1:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 2:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 3:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 4:
                                         Console.WriteLine("Correct");
                                         counter++;
                                         break;
                                 }
                                 Menu.ThirdQuestion();
                                 var readanswer3 = Helpers.ToInteger(1, 4);
                                 switch (readanswer3)
                                 {
                                     case 1:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 2:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 3:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 4:
                                         Console.WriteLine("Correct");
                                         counter++;
                                         break;
                                 }
                                 Menu.ForthQuestion();
                                 var readanswer4 = Helpers.ToInteger(1, 4);
                                 switch (readanswer4)
                                 {
                                     case 1:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 2:
                                         Console.WriteLine("Coorect");
                                         counter++;
                                         break;
                                     case 3:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 4:
                                         Console.WriteLine("Incorect");

                                         break;
                                 }
                                 Menu.FifthQuestion();
                                 var readanswer5 = Helpers.ToInteger(1, 4);
                                 switch (readanswer5)
                                 {
                                     case 1:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 2:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 3:
                                         Console.WriteLine("Incorect");
                                         break;
                                     case 4:
                                         Console.WriteLine("Correct");
                                         counter++;
                                         break;
                                 }
     */

                            }


                                Console.WriteLine($"Your grade is: {counter}");
                                user.TestDone = true;
                                answers.Add(counter);
                                Console.WriteLine("Logining out...");
                                Thread.Sleep(2000);
                                 Console.Clear();
                                 istrue = !istrue;

                            

                        }

                        /*  if (user.TestDone == true)
                          {
                              Console.WriteLine("You already did the test");

                          }*/






                    }


                    

                }
                else
                {
                    Console.WriteLine("invalid password or name ?");
                    if(user.TestDone == true)
                    {
                        Console.WriteLine("You already took the test would you like to try a diffrent student:");
                    }

                    if(counters >= 3)
                    {
                        Environment.Exit(0);
                    }
                    
                    Console.WriteLine("Try again y/n");

                    if (!Helpers.ToConfirm())
                    {
                        Console.WriteLine("Bye:)");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
    



