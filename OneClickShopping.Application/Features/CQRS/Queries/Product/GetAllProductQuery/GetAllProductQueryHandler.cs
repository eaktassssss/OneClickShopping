using MediatR;
using Microsoft.EntityFrameworkCore;
using OneClickShopping.Application.Repositories.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Features.CQRS.Queries.Product.GetAllProductQuery
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {


        private readonly IProductQueryRepository _productQueryRepository;
        public GetAllProductQueryHandler(IProductQueryRepository productQueryRepository)
        {
            _productQueryRepository = productQueryRepository;
        }

        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var query = _productQueryRepository.GetAll(x => x.IsDeleted == false, false).Include(x => x.Categories).Select(x => new GetAllProductQueryResponse()
            {


                CategoryName = x.Categories.CategoryName,
                Price = x.Price,
                CurrentQty = x.CurrentQty,
                Description = x.Description,
                Name = x.Name,
                Id = x.Id,
                StockStatus = x.StockStatus,
                CreatedDate = x.CreatedDate,

            });
            return await query.ToListAsync();

        }
    }
}
