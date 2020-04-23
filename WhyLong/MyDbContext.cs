using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WhyLong
{
    public class MyDbContext: DbContext
    {
        protected MyDbContext() : base("DbConnection")
        {

        }
    }
}
