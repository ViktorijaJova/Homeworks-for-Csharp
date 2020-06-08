using quiz.data;
using quiz.data.Models;
using quiz.Services.ScreenMenus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static quiz.Services.Services.InputParser;

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

            while (true)

            {
               
                Console.Write(" Welcome\n Please Enter Your Name:");
                var readname = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                var readpass = int.Parse(Console.ReadLine());
                var user = _userRepository.GetUserPassword(readpass);
                user = _userRepository.GetUserName(readname);

                List<int> answers = new List<int>();
                int counter = 0;


                if (user != null && user.Name == readname && user.Password == readpass && user.TestDone == false)
                {
                   

                    if (user.isTeacher == true)
                    {
                        bool isistrue = false;

                        while (!isistrue)
                        {

                            Menu.MainMenuForTeacher(user.Name);

                            var readinput = InputParser.ToInteger(1, 2);
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
                        bool istrue = false;
                        List<Question> questions = _userRepository.AllQuestions();

                        while (!istrue)
                        {
                            Menu.MainMenuforStudent(user.Name);


                            foreach (var question in questions)
                            {

                                Console.WriteLine($"{question.Questions}");
                                Console.WriteLine($"{question.Choices}");
                

                                var readanswer = int.Parse(Console.ReadLine());
                                if (readanswer == question.Corect)
                                {

                                        counter++;
                                    answers.Add(counter);

                                   
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Correct");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Incorrect");
                                    Console.ResetColor();
                                }


                            }
                            Console.Clear();
                            Console.WriteLine($"You got {counter} of 5 right and your grade is: {answers.Count}");
                            user.TestDone = true;
                            Console.WriteLine("Thank you for taking the test");
                            Console.WriteLine("Logining out...");
                            Thread.Sleep(3000);
                            Console.Clear();
                            istrue = !istrue;



                        }




                    }


                    

                }
                else
                {

                    if (user.TestDone == true)
                {
                    Console.WriteLine("You already took the test would you like to try a diffrent student:");
                }
              

                    else  {

                        Console.WriteLine("invalid password or name ?");

                    }
                   
                    
                    Console.WriteLine("Try again y/n");
                   

                    if (!InputParser.ToConfirm())
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
    



