using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Features.CQRS.Queries.Product.GetByIdProduct
{
    public  class GetByIdProductQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentQty { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public bool StockStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
