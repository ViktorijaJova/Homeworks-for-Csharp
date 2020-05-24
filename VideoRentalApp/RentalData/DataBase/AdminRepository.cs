using sedc.videorental.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sedc.videorental.data.DataBase
{
     public class AdminRepository:InMemoryDatabase
    {

        public List<User> GetAllUsers()
        {
            return Users;
        }

        public User GetUserByIdCard(int idCard)
        {
            return Users.FirstOrDefault(_user => _user.CardNumber == idCard);
        }
    }
}
