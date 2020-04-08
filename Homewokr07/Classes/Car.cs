using Homewokr07.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homewokr07.Enteties
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }

     

        public Car( string brand, string model, int doors, int topSpeed,Consumption consumption,EngineType engineType)

        {
            Id = GenerateId();
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
            Consumption = consumption;
            EngineType = engineType;

        }

        public void PrintInfo()
        {
            Console.WriteLine($" Id:{GenerateId()}Brand:{Brand} Model:{Model} Doors:{Doors} TopSpeed:{TopSpeed} EngineType:{EngineType},Consumption:{Consumption}");
        }
        private int GenerateId()
        {
            Random rand = new Random();
            return rand.Next(0, 10_000_000);
        }


     

    }
}