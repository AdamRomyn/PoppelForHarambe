using AIKE.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIKE.BusinessLayer
{
    class UserController
    {

        private Collection<User> users;
        private UserDB userDB;

        public UserController()
        {
            userDB = new UserDB();
            users = userDB.GetUsers;
        }

        public User isUserValid(string email, string password)
        {
            bool found;
            foreach (User user in users) {
                found = user.Email == email;
                if (found) {
                    return user;
                }
            }
            return null;
            
        }
    }
}
