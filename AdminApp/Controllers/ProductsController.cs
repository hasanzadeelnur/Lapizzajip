using AdminApp.Controllers.Base;
using Application.Services.Repositories;
using Application.Services.Repositories.Translations;
using AutoMapper;
using Core.CrossCuttingConcerns.DevExtreme;
using DevExtreme.AspNet.Data;
using Domain.Entities;
using Domain.Entities.Translations;
using Infrastructure.Dtos.Products;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace AdminApp.Controllers;

public class ProductsController(
    IProductRepository _productRepository, 
    IProductCategoryRepository _productCategoryRepository, 
    IProductTranslationRepository _productTranslationRepository, 
    BaseDbContext db,
    IMapper _mapper) : BaseController<Product, ProductCommandDto>(db)
{
    [HttpPost]
    [ValidateAntiForgeryToken]
    public override async Task<IActionResult> Create(ProductCommandDto model)
    {
        ViewData["ProductCategories"] = await ProductCategories();

        return await base.Create(model);
    }

    [HttpGet]
    public override async Task<IActionResult> Create()
    {
        ViewData["ProductCategories"] = await ProductCategories();

        return await base.Create();
    }

    [HttpGet]
    public override async Task<IActionResult> Edit(Guid id)
    {
        ViewData["ProductCategories"] = await ProductCategories();

        return await base.Edit(id);
    }

    [HttpPost]
    public override async Task<IActionResult> Edit(Guid id, ProductCommandDto request)
    {
        ViewData["ProductCategories"] = await ProductCategories();
        ViewData["Languages"] = PopulateLanguages();
        try
        {
            if (ModelState.IsValid)
            {
                Product? product = await _productRepository.Query().FirstOrDefaultAsync(e => e.Id == id);
                request.Translations = _mapper.Map<ICollection<ProductTranslationCommandDto>>(product?.Translations);
                product = _mapper.Map(request, product);
                await _productRepository.UpdateAsync(product!);
                TempData["SuccessMessage"] = SuccessMessage;
                return RedirectToAction(nameof(Index));
            }
            else
                return View(request);
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = ErrorMessage;
            return View(request);
        }
    }

    [HttpGet]
    public override async Task<IActionResult> DevxList(DevExtremeAPILoadOptions loadOptions)
    {
        return Ok(await DataSourceLoader.LoadAsync(_productRepository!.Query().Select(c => new
        {
            c.Id,
            c.CreatedDate,
            c.Status,
            c.Translations.FirstOrDefault(s => s.LanguageKey == "en")!.Name
        }), loadOptions));
    }

    [HttpGet]
    public async Task<IActionResult> CreateTranslation(Guid id)
    {
        Product? data = await _productRepository?.Query().FirstOrDefaultAsync(x => x.Id == id)!;
        TempData["Translation"] = id;
        ViewData["Languages"] = PopulateLanguages(data?.Translations.Select(t => t.LanguageKey).ToArray()!);
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTranslation(ProductTranslationCommandDto request)
    {
        Product? data = await _productRepository?.Query()?.FirstOrDefaultAsync(x => x.Id == request.ProductId)!;
        ViewData["Languages"] = PopulateLanguages(data?.Translations.Select(t => t.LanguageKey).ToArray()!);
        if (ModelState.IsValid)
        {
            ProductTranslation productTranslation = request.Adapt<ProductTranslation>();
            await _productTranslationRepository!.AddAsync(productTranslation);
            return RedirectToAction(nameof(Edit), new { id = request.ProductId });
        }
        return View(request);
    }

    [HttpGet]
    public async Task<IActionResult> EditTranslation(Guid id)
    {
        ProductTranslation? translation = await _productTranslationRepository?.Query().FirstOrDefaultAsync(x => x.Id == id)!;
        ProductTranslationCommandDto productTranslation = translation.Adapt<ProductTranslationCommandDto>();
        ViewData["Languages"] = PopulateLanguages([translation?.LanguageKey!]);
        return View(productTranslation);
    }

    [HttpPost]
    public async Task<IActionResult> EditTranslation(ProductTranslationCommandDto request)
    {
        ProductTranslation? translation = await _productTranslationRepository?.Query().FirstOrDefaultAsync(x => x.Id == request.Id)!;
        ViewData["Languages"] = PopulateLanguages([translation?.LanguageKey!]);
        if (ModelState.IsValid)
        {
            translation = _mapper.Map(request, translation);
            await _productTranslationRepository.UpdateAsync(translation!);
            return RedirectToAction(nameof(Edit), new { id = request.ProductId });
        }
        return View(request);
    }

    [HttpPost]
    public async Task<IActionResult> RemoveTranslation(Guid id)
    {
        ViewData["Languages"] = PopulateLanguages();
        ProductTranslation? translation = await _productTranslationRepository.GetAsync(predicate: P => P.Id == id);
        if (translation is not null)
        {
            await _productTranslationRepository.DeleteAsync(translation);
            return RedirectToAction(nameof(Edit), new { id = translation!.ProductId });
        }
        return RedirectToAction(nameof(Index));
    }

    public async Task<SelectList> ProductCategories()
    {
        var categories = await _productCategoryRepository
            .Query()
            .AsNoTracking()
            .Select(c => new
            {
                c.Id,
                c.Translations.FirstOrDefault(s => s.LanguageKey == "en")!.Name
            }).ToListAsync();

        return new SelectList(categories, nameof(ProductCategory.Id), nameof(ProductCategoryTranslation.Name));
    }
}