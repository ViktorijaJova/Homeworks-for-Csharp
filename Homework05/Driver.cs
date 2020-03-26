using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Homework05.classes
{
 public class Driver
    {
        public string Name { get; set; }
        public byte Skill { get; set; }
        public bool IsSelected { get; set; }

        public Driver()
        {
            Name = "unknown";
            IsSelected = false;
        }

        public Driver(string name, byte skill)
        {
            Name = name;
            Skill = skill;
            IsSelected = false;
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        public bool IsSelected { get; set; }

        public int CalculateSpeed(Driver driverObject)
        {
            int result = driverObject.Skill * Speed;
            return result;
        }

        public Car()
        {
            IsSelected = false;
        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
            Driver = new Driver();
            IsSelected = false;
        }
    }
}
