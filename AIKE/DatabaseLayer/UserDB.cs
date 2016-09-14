using AIKE.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIKE.DatabaseLayer
{
    class UserDB : DB
    {
        
        private string usersTable = "Users";
        private string rolesTable = "Roles";

        private string sqlUsers = "SELECT * FROM Users";

        private Collection<User> users;

        //***every column (field) in a database table has a name, data type and the datatype has a size

        public struct ColumnAttribs
        {
            public string myName;
            public SqlDbType myType;
            public int mySize;
        }

        public UserDB() : base()
        {
            users = new Collection<User>();
            FillDataSet(sqlUsers, usersTable);
            FillUserCollection(usersTable);
        }

        public Collection<User> GetUsers
        {
            get
            {
                return users;
            }
        }

        //public User isUserValid(string email,string password)
        //{
        //    SqlParameter param = new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email");
        //    param.SourceVersion = DataRowVersion.Current;
        //    daMain.SelectCommand.Parameters.Add(param);
        //    param = new SqlParameter("@Password", SqlDbType.VarChar, 25, "Password");
        //    param.SourceVersion = DataRowVersion.Current;
        //    daMain.SelectCommand.Parameters.Add(param);
        //    daMain.SelectCommand = new SqlCommand("SELECT * FROM Users WHERE Email = @Email AND Password = @Password", cnMain);
        //    return false;
        //}

        private void FillUserCollection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            User user;
            Role role;  //Declare roleValue and initialise
            
            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Employee object
                    user = new User();
                    role = new Role();
                    role.RoleValue = (Role.RoleType)Convert.ToByte(myRow["RoleID"]);
                    //Obtain each employee attribute from the specific field in the row in the table
                    user.ID = Convert.ToInt32(myRow["ID"]);
                    //Do the same for all other attributes
                    user.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                    user.FirstName = Convert.ToString(myRow["Firstname"]).TrimEnd();
                    user.Password = Convert.ToString(myRow["Password"]).TrimEnd();
                    user.RoleType = role;
                    //Depending on Role read more Values
                    
                    users.Add(user);
                }
            }
        }



    }
}
