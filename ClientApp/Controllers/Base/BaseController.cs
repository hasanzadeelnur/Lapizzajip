using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers.Base;
public class BaseController : Controller
{
    private IMediator _mediator = null!;
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>() ?? null!;
}
