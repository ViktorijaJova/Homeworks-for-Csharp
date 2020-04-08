using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Homewokr07.Enums;

namespace Homewokr07.Enteties
{
    public class ElectricCar : Car
    {
        public int BateryCapacity { get; set; }
        public int BateryUsage { get; set; }
        public ElectricCar(string brand, string model, int doors, int topSpeed,Consumption consumption,EngineType engineType,int batteryCapacity, int batteryUsage) : base(brand, model, doors, topSpeed,consumption,engineType)
        {
            BateryCapacity = batteryCapacity;
            BateryUsage = batteryUsage;
        }

        public void Drive(int distance)


        {
            var usedBattery = (distance * Convert.ToInt32(Consumption) / 10);
            BateryUsage = BateryUsage - (distance * Convert.ToInt32(Consumption) / 10);
            if (usedBattery > BateryCapacity)
            {
                Console.WriteLine($"You can't drive more than the capacity of your battery which is {BateryCapacity} percents");
            }
            else
            {
                Console.WriteLine($"For the distance you Drove you used {usedBattery} percent of the battery and now you have {BateryUsage}percents left ");
            }
        }

        public void Recharge( int minutes)
        {
            var rechargablePercents = minutes / 10;
            BateryUsage = BateryUsage + rechargablePercents;
            if ( rechargablePercents > BateryCapacity)
            {
                Console.WriteLine($"Can't Recharge for {BateryUsage} percent  because it bigger than the BatteryCapacity which is {BateryCapacity}percents");
            }
            else
            {
                
                Console.WriteLine($"Your battery has been Recharged for:{rechargablePercents} percents");
            }




        }
    }
}
