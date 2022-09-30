using OneClickShopping.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Domain.Entities
{
    public class Categories : BaseEntity
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Products> Products { get; set; }

    }
}
