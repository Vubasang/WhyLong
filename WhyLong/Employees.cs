using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyLong
{
    public class Employees 
    { 
        [Key]
        public int EmployeeId { get; set; }
        public int Migration { get; set; }
        public string Position { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public char HomePhoneNumber { get; set; }
        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
