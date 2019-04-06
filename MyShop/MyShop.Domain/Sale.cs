using System.Collections.Generic;

namespace MyShop.Domain
{
    public class Sale : IEntity
    {
        public int Id { get; set; }
        public string Price { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
