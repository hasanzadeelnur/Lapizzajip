using AdminApp.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Persistence.Contexts;
using System.Diagnostics;

namespace AdminApp.Controllers;
[Authorize]
public class HomeController(IConfiguration _configuration, BaseDbContext _db) : Controller
{
    public IActionResult Index()
    {
        ViewData["MessageCount"] = _db?.Set<CustomerMessage>()?.Count();
        ViewData["ProductCount"] = _db?.Set<Product>()?.Count();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet("clearcache")]
    public async Task<IActionResult> ClearCache()
    {
        string currentUrl = Request.GetDisplayUrl();
        string url = Request.Headers.Referer.ToString();
        using (HttpClient client = new())
        {
            client.BaseAddress = new Uri(_configuration["WebAppUri"]!);
            HttpResponseMessage message = await client.PostAsync("/clearcache", null);
        }

        if (currentUrl == url)
            return RedirectToAction(nameof(Index));
        else
            return Redirect(url);
    }
}