using quiz.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quiz.data
{
    public class UserRepository : Database
    {

        public User GetUserPassword(int password)
        {
            return Users.FirstOrDefault(_user => _user.Password == password);
        }


        public User GetUserName(string name)
        {
            return Users.FirstOrDefault(_user => _user.Name == name);
        }

   
        public List<User> GetAllUsers()
        {
            return Users;
        }


        public List<Question> AllQuestions()
        {
            return Questions;
        }

        public List<User> GetStudents()
        {

            return Users.Where(_user => _user.isTeacher == false).ToList();
        }
    
    

}
}
