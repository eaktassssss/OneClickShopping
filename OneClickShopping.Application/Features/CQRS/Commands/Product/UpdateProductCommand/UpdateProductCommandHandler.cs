using MediatR;
using OneClickShopping.Application.Repositories.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Features.CQRS.Commands.Product.UpdateProductCommand
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {

        private readonly IProductCommandRepository _productCommandRepository;
        private readonly IProductQueryRepository _productQueryRepository;
        public UpdateProductCommandHandler(IProductCommandRepository productCommandRepository, IProductQueryRepository productQueryRepository)
        {
            _productCommandRepository = productCommandRepository;
            _productQueryRepository = productQueryRepository;
        }
        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new UpdateProductCommandResponse();
            var product = await _productQueryRepository.GetByIdAsync(request.Id, false);
            if (product == null)
                return response;
            else
            {
                product.Id = request.Id;
                product.Name = request.Name; product.Description = request.Description; product.UpdatedDate = DateTime.Now;
                product.Price = request.Price; product.CurrentQty = request.CurrentQty; product.CategoryId = request.CategoryId;
                product.StockStatus = request.StockStatus;
                var result = await _productCommandRepository.UpdateAsync(product);
                if (result == null)
                    return response;
                else
                {
                    response.Id = result.Id;
                    response.Name = result.Name;
                    response.Description = result.Description;
                    response.Price = result.Price;
                    response.StockStatus = result.StockStatus;
                    response.CategoryId = result.CategoryId;
                    response.CurrentQty = result.CurrentQty;
                    return response;
                }
            }

        }

    }
}
