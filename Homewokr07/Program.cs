using Homewokr07.Enteties;
using System;
using Homewokr07.Enums;

namespace Homewokr07
{
    class Program
    {
        static void Main(string[] args)
        {

           

            ElectricCar first = new ElectricCar("Reno", "Laguna", 5,260, Consumption.Medium, EngineType.Electric,500,300);
            ElectricCar second = new ElectricCar("Tesla", "2020", 2,300, Consumption.High, EngineType.Electric, 500,200);

            FuelCar prva = new FuelCar("Mercedes", "A", 4, 220,Consumption.Economic,EngineType.Disel,50,20);
            FuelCar vtora = new FuelCar("Opel", "Astra", 5, 180, Consumption.Economic, EngineType.Petrol,40,30);




            second.Drive(4000);

            first.Drive(300);
            Console.WriteLine($" After driving and before recharing your car you have:{first.BateryUsage} percents left\n");
            first.Recharge(100);
            Console.WriteLine($"After Recharging, now you have:{first.BateryUsage}percents battery \n");

            first.Recharge(6000);




            prva.Drive(20);
            Console.WriteLine($"The fuel before Refuling and after Driving you have: {prva.CurentFuel}L\n");
            prva.Refule(20);
            Console.WriteLine($" The Car after Refuling has :{prva.CurentFuel}L of fuel\n");


            vtora.Drive(1000);
            vtora.Refule(1000);



            Console.ReadLine();


        }
    }
}
