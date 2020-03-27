using System;
using Homework05.classes;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a dog's name:");
            string readname = Console.ReadLine();
            Console.WriteLine("Now enter the dog's color:");
            string readcolor = Console.ReadLine();
            Console.WriteLine("Enter the dog's race:");
            string readrace = Console.ReadLine();
            Console.WriteLine("Now choose what you would want the dog to do: Play, Eat or Chasetail");
            string readaction = Console.ReadLine();


            Dog dog = new Dog()
            {
                Name = readname,
                Color = readcolor,
                Race = readrace,

            };

            if (readaction == "Play")
            {
                Console.WriteLine(dog.Play());

            } else if (readaction == "Eat")
            {
                Console.WriteLine(dog.Eat());
            } else if (readaction == "ChaseTail")
            {
                Console.WriteLine(dog.ChasingTail());
            }
            else
            {
                Console.WriteLine("Invalid input");
            }




            bool RunProgram = true;
            do
            {
                Car[] CarArray = new Car[4];

                CarArray[0] = new Car("Hyundai", 180);
                CarArray[1] = new Car("Mazda", 220);
                CarArray[2] = new Car("Ferrari", 250);
                CarArray[3] = new Car("Porsche", 300);

                Driver[] DriverArray = new Driver[4];

                DriverArray[0] = new Driver("Bob", 6);
                DriverArray[1] = new Driver("Greg", 7);
                DriverArray[2] = new Driver("Jill", 5);
                DriverArray[3] = new Driver("Anne", 9);

                Car firstCar = GameService.ChoseCarWithDriver(CarArray, DriverArray);
                Car secondCar = GameService.ChoseCarWithDriver(CarArray, DriverArray);

                GameService.RaceCars(firstCar, secondCar);

                Console.WriteLine("Do you want to chek another one Y/N ");
                RunProgram = GameService.RunAgain();

            } while (RunProgram);



            Console.ReadLine();

        }
    }


    

    }

    

    
