using AdminApp.Controllers.Base;
using Application.Services.Repositories;
using Application.Services.Repositories.Translations;
using AutoMapper;
using Core.CrossCuttingConcerns.DevExtreme;
using DevExtreme.AspNet.Data;
using Domain.Entities;
using Domain.Entities.Translations;
using Infrastructure.Dtos.Products;
using Infrastructure.Dtos.Sliders;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace AdminApp.Controllers;

public class SlidersController(ISliderRepository _sliderRepository,
    ISliderTranslationRepository _sliderTranslationRepository,
    BaseDbContext db,
    IMapper _mapper) :BaseController<Slider, SliderCommandDto>(db)
{
    [HttpPost]
    [ValidateAntiForgeryToken]
    public override async Task<IActionResult> Create(SliderCommandDto model)
    {
        return await base.Create(model);
    }

    [HttpGet]
    public override async Task<IActionResult> Create()
    {
        return await base.Create();
    }

    [HttpGet]
    public override async Task<IActionResult> Edit(Guid id)
    {
        return await base.Edit(id);
    }

    [HttpPost]
    public override async Task<IActionResult> Edit(Guid id, SliderCommandDto request)
    {
        ViewData["Languages"] = PopulateLanguages();
        try
        {
            if (ModelState.IsValid)
            {
                Slider? slider = await _sliderRepository.Query().FirstOrDefaultAsync(e => e.Id == id);
                request.Translations = _mapper.Map<ICollection<SliderTranslationCommandDto>>(slider?.Translations);
                slider = _mapper.Map(request, slider);
                await _sliderRepository.UpdateAsync(slider!);
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
        return Ok(await DataSourceLoader.LoadAsync(_sliderRepository!.Query().Select(c => new
        {
            c.Id,
            c.CreatedDate,
            c.Status,
            c.Translations.FirstOrDefault(s => s.LanguageKey == "en")!.Title
        }), loadOptions));
    }

    [HttpGet]
    public async Task<IActionResult> CreateTranslation(Guid id)
    {
        Slider? data = await _sliderRepository?.Query().FirstOrDefaultAsync(x => x.Id == id)!;
        TempData["Translation"] = id;
        ViewData["Languages"] = PopulateLanguages(data?.Translations.Select(t => t.LanguageKey).ToArray()!);
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTranslation(SliderTranslationCommandDto request)
    {
        Slider? data = await _sliderRepository?.Query()?.FirstOrDefaultAsync(x => x.Id == request.SliderId)!;
        ViewData["Languages"] = PopulateLanguages(data?.Translations.Select(t => t.LanguageKey).ToArray()!);
        if (ModelState.IsValid)
        {
            SliderTranslation sliderTranslation = request.Adapt<SliderTranslation>();
            await _sliderTranslationRepository!.AddAsync(sliderTranslation);
            return RedirectToAction(nameof(Edit), new { id = request.SliderId });
        }
        return View(request);
    }

    [HttpGet]
    public async Task<IActionResult> EditTranslation(Guid id)
    {
        SliderTranslation? translation = await _sliderTranslationRepository?.Query().FirstOrDefaultAsync(x => x.Id == id)!;
        SliderTranslationCommandDto productTranslation = translation.Adapt<SliderTranslationCommandDto>();
        ViewData["Languages"] = PopulateLanguages([translation?.LanguageKey!]);
        return View(productTranslation);
    }

    [HttpPost]
    public async Task<IActionResult> EditTranslation(SliderTranslationCommandDto request)
    {
        SliderTranslation? translation = await _sliderTranslationRepository?.Query().FirstOrDefaultAsync(x => x.Id == request.Id)!;
        ViewData["Languages"] = PopulateLanguages([translation?.LanguageKey!]);
        if (ModelState.IsValid)
        {
            translation = _mapper.Map(request, translation);
            await _sliderTranslationRepository.UpdateAsync(translation!);
            return RedirectToAction(nameof(Edit), new { id = request.SliderId });
        }
        return View(request);
    }

    [HttpPost]
    public async Task<IActionResult> RemoveTranslation(Guid id)
    {
        ViewData["Languages"] = PopulateLanguages();
        SliderTranslation? translation = await _sliderTranslationRepository.GetAsync(predicate: P => P.Id == id);
        if (translation is not null)
        {
            await _sliderTranslationRepository.DeleteAsync(translation);
            return RedirectToAction(nameof(Edit), new { id = translation!.SliderId });
        }
        return RedirectToAction(nameof(Index));
    }
}