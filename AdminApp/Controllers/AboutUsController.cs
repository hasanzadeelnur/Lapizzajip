using AdminApp.Controllers.Base;
using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace AdminApp.Controllers;

public class AboutUsController(IAboutUsRepository _aboutUsRepository, BaseDbContext db) : BaseController<AboutUs>(db)
{
    private readonly BaseDbContext _db = db;

    public async override Task<IActionResult> Index()
    {
        return View(await _aboutUsRepository.Query().AsNoTracking().ToListAsync());
    }
}
