using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Features.CQRS.Queries.Product.GetAllProductQuery
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {
    }
}
