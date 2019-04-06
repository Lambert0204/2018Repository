using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Domain
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
        public decimal NonProfitPrice { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
