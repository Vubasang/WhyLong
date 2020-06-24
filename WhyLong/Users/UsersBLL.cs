using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyLong.Users
{
    class UsersBLL
    {
        UsersDAL dalUsers;
        public UsersBLL()
        {
            dalUsers = new UsersDAL();
        }
        public DataTable getAllUsers()
        {
            return dalUsers.getAllUsers();
        }
        public bool InsertUsers(Users users)
        {
            return dalUsers.InsertUsers(users);
        }
        public DataTable FindFullName(string user)
        {
            return dalUsers.FindFullName(user);
        }
        public DataTable FindPhone(string user)
        {
            return dalUsers.FindPhone(user);
        }
        public DataTable FindEmail(string user)
        {
            return dalUsers.FindEmail(user);
        }
    }
}
