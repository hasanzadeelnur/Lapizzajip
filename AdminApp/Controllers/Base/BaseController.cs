using Core.CrossCuttingConcerns.DevExtreme;
using Core.Persistence.Repositories;
using DevExtreme.AspNet.Data;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace AdminApp.Controllers.Base;
[Authorize]
public class BaseController<T, V>(BaseDbContext db) : Controller where T : Entity<Guid>
{
    private readonly BaseDbContext _db = db;
    internal readonly string SuccessMessage = "The operation was completed successfully.";
    internal readonly string ErrorMessage = "An error occurred.";
    internal readonly string NotDataFound = "No data found.";

    public virtual async Task<IActionResult> Index()
    {
        ViewData["Languages"] = PopulateLanguages();
        return await Task.FromResult(View());
    }

    [HttpPost]
    public virtual async Task<IActionResult> Index(T request)
    {
        if (ModelState.IsValid)
        {
            await _db!.Set<T>().AddAsync(request);
            await _db!.SaveChangesAsync();
            TempData["SuccessMessage"] = SuccessMessage;
            return View();
        }
        else
        {
            TempData["ErrorMessage"] = ErrorMessage;
            return View(request);
        }
    }

    public async virtual Task<IActionResult> Create()
    {
        ViewData["Languages"] = PopulateLanguages();
        return await Task.FromResult(View());
    }

    [HttpPost]
    public virtual async Task<IActionResult> Create(V model)
    {
        ViewData["Languages"] = PopulateLanguages();
        try
        {
            ModelState.Clear();
            if (TryValidateModel(model!))
            {
                T entity = model.Adapt<T>();
                entity.CreatedDate = DateTime.Now;
                _db.Add(entity);
                await _db.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction(nameof(Index));
            }
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
        }

        return View(model);
    }

    [HttpGet]
    public virtual async Task<IActionResult> DevxList([FromQuery] DevExtremeAPILoadOptions loadOptions)
    {
        loadOptions.StringToLower = true;

        return Ok(await DataSourceLoader.LoadAsync(_db!.Set<T>().AsNoTracking(), loadOptions));
    }

    [HttpPost]
    public virtual async Task<IActionResult> Remove(Guid id)
    {
        try
        {
            T? result = await _db!.Set<T>()!.FindAsync(id);
            if (result is object)
            {
                _db.Set<T>().Remove(result);
                await _db.SaveChangesAsync();
                TempData["SuccessMessage"] = SuccessMessage;
            }
            else
            {
                TempData["ErrorMessage"] = NotDataFound;
            }
            return Ok();
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = ErrorMessage;
            return StatusCode(500);
        }
    }

    [HttpPost]
    public virtual async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            T? result = await _db!.Set<T>()!.FindAsync(id);
            if (result is object)
            {
                _db.Set<T>().Remove(result);
                await _db.SaveChangesAsync();
                TempData["SuccessMessage"] = SuccessMessage;
            }
            else
                TempData["ErrorMessage"] = NotDataFound;

            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = ErrorMessage;
            return RedirectToAction(nameof(Index));
        }
    }

    [HttpGet]
    public virtual async Task<IActionResult> Edit(Guid id)
    {
        ViewData["Languages"] = PopulateLanguages();

        T? result = await _db!.Set<T>()!.FindAsync(id);

        V model = result.Adapt<V>();

        return View(model);
    }

    [HttpPost]
    public virtual async Task<IActionResult> Edit(Guid id, V request)
    {
        ViewData["Languages"] = PopulateLanguages();
        try
        {
            if (ModelState.IsValid)
            {
                T? data = await _db.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
                data = request.Adapt<T>();
                _db.Set<T>().Update(data);
                await _db.SaveChangesAsync();
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
    public virtual async Task<List<T>> GetList()
    {
        try
        {
            List<T> result = await _db.Set<T>().ToListAsync();
            await _db.SaveChangesAsync();
            TempData["SuccessMessage"] = SuccessMessage;
            return result;
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = ErrorMessage;
            return null!;
        }
    }

    protected SelectList PopulateLanguages(string[] langs = null!)
    {
        Dictionary<string, string> languages = [];
        languages.Add("en", "English");
        languages.Add("az", "Azerbaijan");
        languages.Add("ru", "Russian");

        foreach (var language in langs ?? [])
            languages.Remove(language);

        return new SelectList(languages, "Key", "Value");
    }
}

[Authorize]
public class BaseController<T>(BaseDbContext db) : Controller where T : class
{
    private readonly BaseDbContext _db = db;
    private readonly string SuccessMessage = "The operation was completed successfully.";
    private readonly string ErrorMessage = "An error occurred.";
    private readonly string NotDataFound = "No data found.";

    public virtual async Task<IActionResult> Index()
    {
        ViewData["Languages"] = PopulateLanguages();
        return await Task.FromResult(View());
    }

    [HttpPost]
    public virtual async Task<IActionResult> Index(T request)
    {
        if (ModelState.IsValid)
        {
            await _db!.Set<T>().AddAsync(request);
            await _db!.SaveChangesAsync();
            TempData["SuccessMessage"] = SuccessMessage;
            return View();
        }
        else
        {
            TempData["ErrorMessage"] = ErrorMessage;
            return View(request);
        }
    }

    public async virtual Task<IActionResult> Create()
    {
        ViewData["Languages"] = PopulateLanguages();
        return await Task.FromResult(View());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public virtual async Task<IActionResult> Create(T model)
    {
        ViewData["Languages"] = PopulateLanguages();
        try
        {
            ModelState.Clear();
            if (TryValidateModel(model))
            {
                _db.Add(model);
                await _db.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction(nameof(Index));
            }
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
        }

        return View(model);
    }

    [HttpGet]
    public virtual async Task<IActionResult> DevxList([FromQuery] DevExtremeAPILoadOptions loadOptions)
    {
        loadOptions.StringToLower = true;

        return Ok(await DataSourceLoader.LoadAsync(_db!.Set<T>().AsNoTracking(), loadOptions));
    }

    [HttpPost]
    public virtual async Task<IActionResult> Remove(Guid id)
    {
        try
        {
            T? result = await _db!.Set<T>()!.FindAsync(id);
            if (result is object)
            {
                _db.Set<T>().Remove(result);
                await _db.SaveChangesAsync();
                TempData["SuccessMessage"] = SuccessMessage;
            }
            else
            {
                TempData["ErrorMessage"] = NotDataFound;
            }
            return Ok();
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = ErrorMessage;
            return StatusCode(500);
        }
    }

    [HttpPost]
    public virtual async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            T? result = await _db!.Set<T>()!.FindAsync(id);
            if (result is object)
            {
                _db.Set<T>().Remove(result);
                await _db.SaveChangesAsync();
                TempData["SuccessMessage"] = SuccessMessage;
            }
            else
                TempData["ErrorMessage"] = NotDataFound;

            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = ErrorMessage;
            return RedirectToAction(nameof(Index));
        }
    }

    [HttpGet]
    public virtual async Task<IActionResult> Edit(Guid id)
    {
        ViewData["Languages"] = PopulateLanguages();

        T? result = await _db!.Set<T>()!.FindAsync(id);

        return View(result);
    }

    [HttpPost]
    public virtual async Task<IActionResult> Edit(Guid id, T request)
    {
        ViewData["Languages"] = PopulateLanguages();
        try
        {
            if (ModelState.IsValid)
            {
                _db.Set<T>().Update(request);
                await _db.SaveChangesAsync();
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
    public virtual async Task<IActionResult> Update(int id)
    {
        ViewData["Languages"] = PopulateLanguages();

        T? result = await _db!.Set<T>()!.FindAsync(id);

        return View(result);
    }

    [HttpPost]
    public virtual async Task<IActionResult> Update(int id, T request)
    {
        ViewData["Languages"] = PopulateLanguages();
        try
        {
            if (ModelState.IsValid)
            {
                _db.Set<T>().Update(request);
                await _db.SaveChangesAsync();
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
    public virtual async Task<List<T>> GetList()
    {
        try
        {
            List<T> result = await _db.Set<T>().ToListAsync();
            await _db.SaveChangesAsync();
            TempData["SuccessMessage"] = SuccessMessage;
            return result;
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = ErrorMessage;
            return null!;
        }
    }

    protected SelectList PopulateLanguages(string[] langs = null!)
    {
        Dictionary<string, string> languages = [];
        languages.Add("en", "English");
        languages.Add("az", "Azerbaijan");
        languages.Add("ru", "Russian");

        foreach (var language in langs ?? [])
            languages.Remove(language);

        return new SelectList(languages, "Key", "Value");
    }

}