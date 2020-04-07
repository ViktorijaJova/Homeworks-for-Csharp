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
    public FuelCar(string brand, string model, int doors, int topspeed,Consumption consumption,EngineType enginetype, int fuelcapacity, int currentfuel)
            : base(brand, model, doors, topspeed,consumption,enginetype)
        {
            FuelCapacity = fuelcapacity;
            CurentFuel = currentfuel;
        }


        public void Drive(int distance)
        {
            var usedfuel = (distance * Convert.ToInt32(Consumption) / 10);
            CurentFuel= CurentFuel - usedfuel;
            Console.WriteLine($"For the distance you Drove you used {usedfuel}L Fuel and have left {CurentFuel}L");
        }

        public void Refule(int fuel)
        {
            if (fuel > FuelCapacity)
            {
                Console.WriteLine("You can't refule cause your above the limit of your fuel capacity");
            }
            else if (fuel < FuelCapacity)
            {
             var result = (CurentFuel += fuel);
             Console.WriteLine($"Your car has been Refueld for:{fuel}L");

            }



        }
    }
}
