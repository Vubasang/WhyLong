using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WhyLong
{
    class AdminsBLL
    {
        AdminsDAL dalAdmins;
        public AdminsBLL()
        {
            dalAdmins = new AdminsDAL();
        }
        public DataTable getAllAdmins()
        {
            return dalAdmins.getAllAdmins();
        }
        public bool InsertAdmins(Admins admins)
        {
            return dalAdmins.InsertAdmins(admins);
        }
        public bool UpdateAdmins(Admins admins)
        {
            return dalAdmins.UpdateAdmins(admins);
        }
        public bool DeleteBooks(Admins admins)
        {
            return dalAdmins.DeleteAdmins(admins);
        }
        public DataTable FindCode(string admin)
        {
            return dalAdmins.FindCode(admin);
        }
        public DataTable FindFullName(string admin)
        {
            return dalAdmins.FindFullName(admin);
        }
        public DataTable FindYearOfBirth(string admin)
        {
            return dalAdmins.FindYearOfBirth(admin);
        }
        public DataTable FindGender(string admin)
        {
            return dalAdmins.FindGender(admin);
        }
        public DataTable FindEmail(string admin)
        {
            return dalAdmins.FindEmail(admin);
        }
        public DataTable FindPhone(string admin)
        {
            return dalAdmins.FindPhone(admin);
        }
        public DataTable FindAddress(string admin)
        {
            return dalAdmins.FindAddress(admin);
        }
        public DataTable FindPosition(string admin)
        {
            return dalAdmins.FindPosition(admin);
        }
    }
}
