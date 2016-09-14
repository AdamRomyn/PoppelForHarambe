using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIKE.BusinessLayer
{
    class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Role RoleType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {

        }
       
    }
}
