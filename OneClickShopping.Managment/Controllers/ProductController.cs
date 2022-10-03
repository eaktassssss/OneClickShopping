using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneClickShopping.Application.Features.CQRS.Commands.Product.CreateProductCommand;
using OneClickShopping.Application.Features.CQRS.Commands.Product.DeleteProductCommand;
using OneClickShopping.Application.Features.CQRS.Commands.Product.UpdateProductCommand;
using OneClickShopping.Application.Features.CQRS.Queries.Product.GetAllProductQuery;
using OneClickShopping.Application.Features.CQRS.Queries.Product.GetByIdProduct;

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
            if (response == null)
                return View(request);
            else
                return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<ActionResult> Index(GetAllProductQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return View(response);
        }


        [HttpPost]
        public async Task<ActionResult> Update(UpdateProductCommandRequest request)
        {
            var response = await _mediator.Send(request);
            if (response == null)
                return View(request);
            else
                return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<ActionResult> Update(int id)
        {

            var product = new GetByIdProductQueryRequest();
            product.Id = id;
            var response = await _mediator.Send(product);
            return View(response);
        }


        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {

            var deleteProductRequest = new DeleteProductCommandRequest();
            deleteProductRequest.Id = id;
            var response = await _mediator.Send(deleteProductRequest);
            if (!response.Success)
                return View();
            else
                return RedirectToAction(nameof(Index));
        }
    }
}
