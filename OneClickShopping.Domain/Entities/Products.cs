using OneClickShopping.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Domain.Entities
{
    public class Products : BaseEntity
    {
        public string Name { get; set; }
        public int CurrentQty { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
        public string Description { get; set; }
        public bool StockStatus { get; set; }
    }
}
