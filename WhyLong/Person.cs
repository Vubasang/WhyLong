using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace WhyLong
{
    class Person
    {
        public int PersonId {get; set; }
        public string SFP { get; set; }
        public DateTime Birthday { get; set; }   
    }
}
