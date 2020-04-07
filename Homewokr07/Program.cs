using Homewokr07.Enteties;
using System;
using Homewokr07.Enums;

namespace Homewokr07
{
    class Program
    {
        static void Main(string[] args)
        {

            ElectricCar first = new ElectricCar("Reno", "Laguna", 5,260, Consumption.medium, EngineType.disel,500,300);
            ElectricCar second = new ElectricCar("Tesla", "2020", 2,300, Consumption.high, EngineType.electric, 500,200);

            FuelCar prva = new FuelCar("Mercedes", "A", 4, 220,Consumption.economic,EngineType.petrol,50,20);
            FuelCar vtora = new FuelCar("Opel", "Astra", 5, 180, Consumption.economic, EngineType.petrol,40,30);



        

            first.Drive(300);
            Console.WriteLine($" After driving and before recharing your car you have:{first.BateryUsage} percents left\n");
            first.Recharge(100);
            Console.WriteLine($"After Recharging, now you have:{first.BateryUsage}percents battery \n");

            second.Drive(500);
            Console.WriteLine($" After driving and before recharing your car you have:{second.BateryUsage}percents left \n");
            second.Recharge(600);


            prva.Drive(20);
            Console.WriteLine($"The fuel before Refuling and after Driving you have: {prva.CurentFuel}L\n");
            prva.Refule(20);
            Console.WriteLine($" The Car after Refuling has :{prva.CurentFuel}L of fuel\n");


            vtora.Drive(100);
            vtora.Refule(100);



            Console.ReadLine();


        }
    }
}
