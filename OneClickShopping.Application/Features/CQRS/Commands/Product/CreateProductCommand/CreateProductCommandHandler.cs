using MediatR;
using OneClickShopping.Application.Repositories.Product;
using OneClickShopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Features.CQRS.Commands.Product.CreateProductCommand
{

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {

        private readonly IProductCommandRepository _productCommandRepository;
        public CreateProductCommandHandler(IProductCommandRepository productCommandRepository)
        {
            _productCommandRepository = productCommandRepository;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {

            var product = new Products();
            product.Name = request.Name;
            product.CategoryId = request.CategoryId;
            product.Price = request.Price;
            product.CurrentQty = request.CurrentQty;
            product.IsDeleted = false;
            product.CreatedDate = DateTime.Now;
            product.Description = "Bu ürün bu ülke için gönderildi";
            product.StockStatus = request.StockStatus;
            var result = await _productCommandRepository.AddAsync(product);
            var response = new CreateProductCommandResponse();
            if (result == null)
            {
                return response;
            }
            else
            {
                response.Name = result.Name;
                response.CategoryId = result.CategoryId;
                response.Price = result.Price;
                response.CurrentQty = result.CurrentQty;
                response.CreatedDate = DateTime.Now;
                response.Description = result.Description;
                response.StockStatus = result.StockStatus;
                return response;
            }

        }
    }
}
