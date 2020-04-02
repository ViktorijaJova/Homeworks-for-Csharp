using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.Class06.Excersises.Buissnis.Models
{
  public  class User
    {
        public int ID { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }
        public DateTime CreatedOn { get; set; }


        public User(string email,string password, string firstname, string lastname, DateTime dateofbirth)
        {
            ID = GenerateId();
            Email = email;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            DateofBirth = dateofbirth;
            CreatedOn = DateTime.Now;

        }


        public string GetInfo()
        {
            return string.Format("Name:{0} DateofBirth: {1}", GetFullName(), DateofBirth.Date);
        }

        public string GetFullName()
        {
            return $"{FirstName}{LastName}";
        }

        private int GenerateId()
        {
            Random rand = new Random();
            return rand.Next(0, 1000000);
        }


    }
    
}
