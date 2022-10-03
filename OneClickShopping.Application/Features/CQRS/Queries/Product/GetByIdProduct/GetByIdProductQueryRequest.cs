using MediatR;
using OneClickShopping.Application.Features.CQRS.Commands.Product.UpdateProductCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Features.CQRS.Queries.Product.GetByIdProduct
{
    public  class GetByIdProductQueryRequest:IRequest<GetByIdProductQueryResponse>
    {
        public int Id { get; set; }
    }
}
