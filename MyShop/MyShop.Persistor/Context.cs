using MyShop.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Persistor
{
    public class Context : DbContext
    {
        public Context() : base("Data Source=LManalo-T440P;Initial Catalog=MyShop;Integrated Security=True") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
