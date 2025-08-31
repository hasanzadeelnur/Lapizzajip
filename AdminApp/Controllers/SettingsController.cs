using AdminApp.Controllers.Base;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace AdminApp.Controllers;

public class SettingsController(BaseDbContext context) : BaseController<Setting>(context)
{
    private readonly BaseDbContext _db = context;

    public async override Task<IActionResult> Index()
    {
        return View(await _db.Set<Setting>()!.ToListAsync());
    }
}
