using AdminApp.Controllers.Base;
using Core.CrossCuttingConcerns.DevExtreme;
using DevExtreme.AspNet.Data;
using Domain.Entities;
using Domain.Entities.Translations;
using Infrastructure.Dtos.ProductCategories;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Xml.Linq;

namespace AdminApp.Controllers;
public class ProductCategoriesController(BaseDbContext db) : BaseController<ProductCategory, ProductCategoryCommandDto>(db)
{
    private readonly BaseDbContext _db = db;

    [HttpGet]
    public override async Task<IActionResult> DevxList(DevExtremeAPILoadOptions loadOptions)
    {
        return Ok(await DataSourceLoader.LoadAsync(_db!.Set<ProductCategory>().Select(c => new
        {
            c.Id,
            CreatedDate = DateTime.Now,
            c.Status,
            c.Order,
            c.Translations.FirstOrDefault(s => s.LanguageKey == "en")!.Name
        }), loadOptions));
    }

    [HttpGet]
    public override async Task<IActionResult> Create()
    {
        ViewData["ProductCategories"] = await ProductCategories();
        return await base.Create();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public override async Task<IActionResult> Create(ProductCategoryCommandDto model)
    {
        ViewData["ProductCategories"] = await ProductCategories();
        return await base.Create(model);
    }

    [HttpGet]
    public override async Task<IActionResult> Edit(Guid id)
    {
        ViewData["ProductCategories"] = await ProductCategories();
        return await base.Edit(id);
    }

    [HttpPost]
    public override async Task<IActionResult> Edit(Guid id, ProductCategoryCommandDto request)
    {
        ViewData["ProductCategories"] = await ProductCategories();
        return await base.Edit(id, request);
    }

    [HttpGet]
    public async Task<IActionResult> CreateTranslation(Guid id)
    {
        ProductCategory? data = await _db?.Set<ProductCategory>()?.FirstOrDefaultAsync(x => x.Id == id)!;
        TempData["Translation"] = id;
        ViewData["Languages"] = PopulateLanguages(data?.Translations.Select(t => t.LanguageKey).ToArray()!);
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTranslation(ProductCategoryTranslationCommandDto request)
    {
        ProductCategory? data = await _db?.Set<ProductCategory>()?.FirstOrDefaultAsync(x => x.Id == request.CategoryId)!;
        ViewData["Languages"] = PopulateLanguages(data?.Translations.Select(t => t.LanguageKey).ToArray()!);
        ProductCategoryTranslation categoryTranslation = request.Adapt<ProductCategoryTranslation>();
        await _db!.Set<ProductCategoryTranslation>()!.AddAsync(categoryTranslation);
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Edit), new { id = request.CategoryId });
    }

    [HttpGet]
    public async Task<IActionResult> EditTranslation(Guid id)
    {
        ProductCategoryTranslation? translation = await _db?.Set<ProductCategoryTranslation>()?.FirstOrDefaultAsync(x => x.Id == id)!;
        ViewData["Languages"] = PopulateLanguages([translation?.LanguageKey!]);
        return View(translation);
    }

    [HttpPost]
    public async Task<IActionResult> EditTranslation(ProductCategoryTranslationCommandDto request)
    {
        ProductCategoryTranslation? translation = await _db?.Set<ProductCategoryTranslation>().AsNoTracking()?.FirstOrDefaultAsync(x => x.Id == request.Id)!;
        ViewData["Languages"] = PopulateLanguages([translation?.LanguageKey!]);
        ProductCategoryTranslation categoryTranslation = request.Adapt<ProductCategoryTranslation>();
        _db!.Set<ProductCategoryTranslation>()!.Update(categoryTranslation);
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Edit), new { id = request.CategoryId });
    }

    [HttpPost]
    public async Task<IActionResult> RemoveTranslation(Guid id)
    {
        ViewData["Languages"] = PopulateLanguages();
        ProductCategoryTranslation? translation = await _db.Set<ProductCategoryTranslation>()!.FindAsync(id);
        if (translation is not null)
        {
            _db!.Set<ProductCategoryTranslation>()!.Remove(translation);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Edit), new { id = translation!.CategoryId });
        }
        return RedirectToAction(nameof(Index));
    }

    public async Task<SelectList> ProductCategories()
    {
        var mainCategories = await _db!.Set<ProductCategory>()!.AsNoTracking().Select(c => new
        {
            c.Id,
            c.Translations.FirstOrDefault(s => s.LanguageKey == "en")!.Name
        }).ToListAsync();

        return new SelectList(mainCategories, "Id", "Name");
    }
}
