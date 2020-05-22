using sedc.videorental.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sedc.videorental.data.DataBase
{
  public  class UserRepository:InMemoryDatabase
    {


        public List<User> GetAllUsers()
        {
            return Users;
        }

        public User GetUserByIdCard(int idCard)
        {
            return Users.FirstOrDefault(_user => _user.CardNumber == idCard);
        }
        public bool Createuser(User user)
        {
            var beforeCount = Users.Count;
            Users.Add(user);

            return beforeCount != Users.Count;
        }

        public List<int> GetAllCardNumbers()
        {
            return Users.Select(_user => _user.CardNumber)
            .ToList();

        }
    }
}
