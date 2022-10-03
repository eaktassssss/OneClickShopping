using MediatR;
using OneClickShopping.Application.Features.CQRS.Commands.Product.UpdateProductCommand;
using OneClickShopping.Application.Repositories.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Features.CQRS.Queries.Product.GetByIdProduct
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        private readonly IProductQueryRepository _productQueryRepository;
        public GetByIdProductQueryHandler(IProductQueryRepository productQueryRepository)
        {
            _productQueryRepository = productQueryRepository;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {

            GetByIdProductQueryResponse getByIdProductQueryResponse = new GetByIdProductQueryResponse();


            var product = await _productQueryRepository.GetByIdAsync(request.Id);
            if (product == null)
                return getByIdProductQueryResponse;

            else
            {

                getByIdProductQueryResponse.Description = product.Description;
                getByIdProductQueryResponse.Id = product.Id;
                getByIdProductQueryResponse.Name = product.Name;
                getByIdProductQueryResponse.CategoryId = product.CategoryId;
                getByIdProductQueryResponse.Price = product.Price;
                getByIdProductQueryResponse.CurrentQty = product.CurrentQty;
                getByIdProductQueryResponse.StockStatus = product.StockStatus;
                getByIdProductQueryResponse.CreatedDate = product.CreatedDate;
                getByIdProductQueryResponse.IsDeleted = product.IsDeleted;
                return getByIdProductQueryResponse;
            }
        }
    }
}
