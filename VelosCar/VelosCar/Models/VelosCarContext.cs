using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    public class VelosCarContext : DbContext
    {
        public DbSet<Accesorio> Accesorios { get; set; }
        public int MyProperty { get; set; }
    }
}