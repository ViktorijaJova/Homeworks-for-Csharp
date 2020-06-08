using quiz.data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace quiz.data
{
    public class Database
    {
        protected List<User> Users { get; set; }
        protected List<Question> Questions { get; set; }


        public Database()
        {
            InitDatabase();
        }

        private void InitDatabase()
        {
            Users = new List<User>
            {
                               new User() { Name = "Nikola", Password = 111, isTeacher = true},
                               new User(){ Name = "Viktorija", Password= 123 , TestDone = false,},
                               new User(){ Name = "Monika", Password= 222 , TestDone = false},
                               new User(){ Name = "Despina", Password= 333 , TestDone = false},



            };

            Questions = new List<Question>
            {
             new Question() {Questions = "What is the capital of Tasmania?",Choices= "1.Dodoma \n 2.Hobart \n 3.Launceston \n 4.Wellington", Corect = 2},
                new Question() {Questions = "What is the tallest building in the Republic of the Congo?", Choices = "1.Kinshasa  Democratic Republic of the Congo Temple \n 2.Palais de la Nation\n 3.Kongo Trade Centre \n4.Nabemba Tower", Corect = 4},
                new Question() {Questions = "Which of these is not one of Pluto's moons?", Choices = "1.Styx \n2.Hydra \n3.Nix \n4.Lugia", Corect = 4},
                new Question() {Questions = "What is the smallest lake in the world?", Choices= "1.Onega Lake \n 2.Benxi Lake \n 3.Kivu Lake \n4.Wakatipu Lake", Corect = 2},
                new Question() {Questions = "What country has the largest population of alpacas?", Choices = "1.Chad \n 2.Peru \n3.Australia \n 4.Niger", Corect = 4,
                    }

            };

        }
    }
}
       
      