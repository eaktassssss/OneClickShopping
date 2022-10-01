using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneClickShopping.Application.Features.CQRS.Commands.Product.CreateProductCommand;

namespace OneClickShopping.Managment.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Add(CreateProductCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return View(response);
        }
    }
}
