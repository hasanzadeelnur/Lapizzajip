using Application.Features.ProductCategories.Queries.GetList;
using Application.Features.Products.Queries.GetList;
using ClientApp.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers;
public class MenuController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        ViewData[nameof(GetListProductCategoryQuery)] = await Mediator.Send(new GetListProductCategoryQuery());    
        ViewData[nameof(GetListProductQuery)] = await Mediator.Send(new GetListProductQuery());    
        return View();
    }
}
