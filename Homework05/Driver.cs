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

   
    }
