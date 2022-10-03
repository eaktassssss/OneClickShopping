using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Features.CQRS.Commands.Product.DeleteProductCommand
{
    public  class DeleteProductCommandRequest:IRequest<DeleteProductCommandResponse>
    {
        public int Id { get; set; }
    }
}
