using AdminApp.Controllers.Base;
using Core.CrossCuttingConcerns.DevExtreme;
using DevExtreme.AspNet.Data;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Persistence.Contexts;

namespace AdminApp.Controllers;

public class ServicesController(BaseDbContext db) : BaseController<Service>(db)
{
    private readonly BaseDbContext _db = db;

    [HttpGet]
    public override async Task<IActionResult> DevxList(DevExtremeAPILoadOptions loadOptions)
    {
        return Ok(await DataSourceLoader.LoadAsync(_db!.Set<Service>().Select(c => new Service
        {
            Id = c.Id,
            CreatedDate = DateTime.Now,
            Status = c.Status,
            Order = c.Order,
            LanguageKey = c.LanguageKey,
            Title = c.Title,
            ImagePath = c.ImagePath
        }), loadOptions));
    }
}