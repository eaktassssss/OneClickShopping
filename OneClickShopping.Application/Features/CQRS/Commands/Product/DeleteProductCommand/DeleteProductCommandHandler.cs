using MediatR;
using OneClickShopping.Application.Repositories.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Features.CQRS.Commands.Product.DeleteProductCommand
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        private readonly IProductCommandRepository _productCommandRepository;
        private readonly IProductQueryRepository _productQueryRepository;
        public DeleteProductCommandHandler(IProductCommandRepository productCommandRepository, IProductQueryRepository productQueryRepository)
        {
            _productCommandRepository = productCommandRepository;
            _productQueryRepository = productQueryRepository;
        }
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new DeleteProductCommandResponse();

            var product = await _productQueryRepository.GetByIdAsync(request.Id);

            if (product == null)
                return null;
            else
            {
                var result = await _productCommandRepository.RemoveAsync(product);
                if (result == null)
                    response.Success = false;
                else
                {
                    response.Success = true;
                }
            }
            return response;

        }
    }
}
