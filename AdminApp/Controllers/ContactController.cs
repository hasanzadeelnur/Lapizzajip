using AdminApp.Controllers.Base;
using Application.Services.Repositories;
using Domain.Entities;
using Domain.Entities.Translations;
using Infrastructure.Dtos.ContactUs;
using Infrastructure.Dtos.Products;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Xml.Linq;

namespace AdminApp.Controllers;

public class ContactController(IContactUsRepository _contactUsRepository, BaseDbContext db) : BaseController<ContactUs,ContactUsCommandDto>(db)
{
    private readonly BaseDbContext _db = db;

    public async override Task<IActionResult> Index()
    {
        return View(await _contactUsRepository.Query().AsNoTracking().ToListAsync());
    }

    [HttpGet]
    public async Task<IActionResult> CreateTranslation(Guid id)
    {
        ContactUs? data = await _db?.Set<ContactUs>()?.FirstOrDefaultAsync(x => x.Id == id)!;
        TempData["Translation"] = id;
        ViewData["Languages"] = PopulateLanguages(data?.Translations.Select(t => t.LanguageKey).ToArray()!);
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTranslation(ContactUsTranslationCommandDto request)
    {
        ContactUs? data = await _db?.Set<ContactUs>()?.FirstOrDefaultAsync(x => x.Id == request.ContactUsId)!;
        ViewData["Languages"] = PopulateLanguages(data?.Translations.Select(t => t.LanguageKey).ToArray()!);
        if (ModelState.IsValid)
        {
            ContactUsTranslation contactUsTranslation = request.Adapt<ContactUsTranslation>();
            await _db!.Set<ContactUsTranslation>()!.AddAsync(contactUsTranslation);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Edit), new { id = request.ContactUsId });
        }
        return View(request);
    }

    [HttpGet]
    public async Task<IActionResult> EditTranslation(Guid id)
    {
        ContactUsTranslation? translation = await _db?.Set<ContactUsTranslation>()!?.FirstOrDefaultAsync(x => x.Id == id)!;
        ViewData["Languages"] = PopulateLanguages([translation?.LanguageKey!]);
        ContactUsTranslationCommandDto contactUsTranslation = translation.Adapt<ContactUsTranslationCommandDto>();
        return View(contactUsTranslation);
    }

    [HttpPost]
    public async Task<IActionResult> EditTranslation(ContactUsTranslationCommandDto request)
    {
        ContactUsTranslation? translation = await _db?.Set<ContactUsTranslation>().AsNoTracking()?.FirstOrDefaultAsync(x => x.Id == request.Id)!;
        ViewData["Languages"] = PopulateLanguages([translation?.LanguageKey!]);
        if (ModelState.IsValid)
        {
            ContactUsTranslation contactUsTranslation = request.Adapt<ContactUsTranslation>();
            _db!.Set<ContactUsTranslation>()!.Update(contactUsTranslation);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Edit), new { id = request.ContactUsId });
        }
        return View(request);
    }

    [HttpPost]
    public async Task<IActionResult> RemoveTranslation(Guid id)
    {
        ViewData["Languages"] = PopulateLanguages();
        ContactUsTranslation? translation = await _db.Set<ContactUsTranslation>()!.FindAsync(id);
        if (translation is not null)
        {
            _db!.Set<ContactUsTranslation>()!.Remove(translation);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Edit), new { id = translation!.ContactUsId });
        }
        return RedirectToAction(nameof(Index));
    }
}