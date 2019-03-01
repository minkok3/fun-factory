using System.Collections.Generic;

namespace WebApp.Domain
{
    public class Component
    {
        public long Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQty { get; set; }

        public virtual ICollection<KitComponent> Components { get; set; }
    }
}