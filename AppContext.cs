using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace GMapApp
{

    // класс контекста базы данных

    class AppContext : DbContext
    {

        public DbSet<Place> Places { get; set; }

        public DbSet<Route> Routes { get; set; }

        public DbSet<Test> Tests { get; set; }

        public DbSet<User> Users { get; set; }

        public AppContext() : base("DefaultConnection") { }

    }
}
