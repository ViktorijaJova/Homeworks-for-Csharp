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
                               new User(){ Name = "Viktorija", Password= 123 , TestDone = false},
                               new User(){ Name = "Monika", Password= 222 , TestDone = false},
                               new User(){ Name = "Despina", Password= 333 , TestDone = false},



            };

            Questions = new List<Question>
            {
             new Question() {Questions = "What is the capital of Tasmania?", FirstChoice = "1.Dodoma", SecondChoice = "2.Hobart", ThirdChoice = "3.Launceston", ForthChoice = "4.Wellington", Corect = 2},
                new Question() {Questions = "What is the tallest building in the Republic of the Congo?", FirstChoice = "1.Kinshasa Democratic Republic of the Congo Temple", SecondChoice = "2.Palais de la Nation", ThirdChoice = "3.Kongo Trade Centre", ForthChoice = "4.Nabemba Tower", Corect = 4},
                new Question() {Questions = "Which of these is not one of Pluto's moons?", FirstChoice = "1.Styx", SecondChoice = "2.Hydra", ThirdChoice = "3.Nix", ForthChoice = "4.Lugia", Corect = 4},
                new Question() {Questions = "What is the smallest lake in the world?", FirstChoice= "1.Onega Lake", SecondChoice = "2.Benxi Lake", ThirdChoice = "3.Kivu Lake", ForthChoice = "4.Wakatipu Lake", Corect = 2},
                new Question() {Questions = "What country has the largest population of alpacas?", FirstChoice = "1.Chad", SecondChoice= "2.Peru", ThirdChoice = "3.Australia", ForthChoice = "4.Niger", Corect = 4}
            };
       
        }
    }
}
