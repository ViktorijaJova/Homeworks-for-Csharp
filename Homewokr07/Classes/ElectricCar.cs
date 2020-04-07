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
        public ElectricCar(string brand, string model, int doors, int topspeed,Consumption consumption,EngineType enginetype,int batterycapacity, int batteryusage) : base(brand, model, doors, topspeed,consumption,enginetype)
        {
            BateryCapacity = batterycapacity;
            BateryUsage = batteryusage;
        }

        public void Drive(int distance)
        {
            var usedbattery = (distance * Convert.ToInt32(Consumption) / 10);
             BateryUsage = BateryUsage - (distance * Convert.ToInt32(Consumption) / 10);
            Console.WriteLine($"For the distance you Drove you used {usedbattery} percent of the battery and now you have {BateryUsage}percents left ");
        }

        public void Recharge( int minutes)
        {

            if (minutes > BateryCapacity)
            {
                Console.WriteLine("Can't Recharge because it bigger than the BatteryCapacity");
            }
            else
            {
                var rechargablepercents = minutes / 10;
                BateryUsage = BateryUsage + rechargablepercents;
                Console.WriteLine($"Your battery has been Recharged for:{rechargablepercents} percents");
            }




        }
    }
}
