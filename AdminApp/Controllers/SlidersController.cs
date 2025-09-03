using AdminApp.Controllers.Base;
using Core.CrossCuttingConcerns.DevExtreme;
using DevExtreme.AspNet.Data;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Persistence.Contexts;

namespace AdminApp.Controllers;

public class SlidersController(BaseDbContext db) : BaseController<Slider>(db)
{
    private readonly BaseDbContext _db = db;

    [HttpGet]
    public override async Task<IActionResult> DevxList(DevExtremeAPILoadOptions loadOptions)
    {
        return Ok(await DataSourceLoader.LoadAsync(_db!.Set<Slider>().Select(c => new Slider
        {
            Id = c.Id,
            CreatedDate = c.CreatedDate,
            Status = c.Status,
            Order = c.Order,
            ImagePath = c.ImagePath
        }), loadOptions));
    }
}