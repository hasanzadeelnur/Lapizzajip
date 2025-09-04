using AdminApp.Controllers.Base;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Persistence.Contexts;

namespace AdminApp.Controllers;

[Authorize]
public class MessagesController(BaseDbContext context) : BaseController<CustomerMessage>(context)
{
}
