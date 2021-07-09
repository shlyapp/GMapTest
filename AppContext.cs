using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace GMapApp
{
    class AppContext : DbContext
    {

        public DbSet<Place> Places { get; set; }

        public DbSet<Route> Routes { get; set; }

        public AppContext() : base("DefaultConnection") { }

    }
}
