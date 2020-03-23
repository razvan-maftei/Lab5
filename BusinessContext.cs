using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator5
{
    public class BusinessContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }
    }
}
