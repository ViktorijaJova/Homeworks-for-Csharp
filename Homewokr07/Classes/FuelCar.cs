using Homewokr07.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Homewokr07.Enteties
{
   public class FuelCar : Car {
       
        public int FuelCapacity { get; set; }
        public int CurentFuel { get; set; }
    public FuelCar(string brand, string model, int doors, int topSpeed,Consumption consumption,EngineType engineType, int fuelCapacity, int currentFuel)
            : base(brand, model, doors, topSpeed,consumption,engineType)
        {
            FuelCapacity = fuelCapacity;
            CurentFuel = currentFuel;
        }


        public void Drive(int distance)
        {

            var usedFuel = (distance * Convert.ToInt32(Consumption) / 10);
            CurentFuel = CurentFuel - usedFuel;

            if (usedFuel > FuelCapacity)
            {
                Console.WriteLine($"You cant drive more than your fuel capacity which is {FuelCapacity}L");
            }
            else
            {
                Console.WriteLine($"For the distance you Drove you used {usedFuel}L Fuel and have left {CurentFuel}L");
            }
        }

        public void Refule(int fuel)
        {
            if (fuel > FuelCapacity)
            {
                Console.WriteLine($"You can't refule {fuel}L cause your above the limit of your fuel capacity which is {FuelCapacity}L");
            }
            else 
            {
             var result = (CurentFuel += fuel);
             Console.WriteLine($"Your car has been Refueld for:{fuel}L");

            }



        }
    }
}
