using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WhyLong
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DBConnection")
        { }

        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Artist> Artist { get; set; }  
    }
}
