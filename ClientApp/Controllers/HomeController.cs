using ClientApp.Repositories;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers;
public class HomeController(IGeneralRepository _generalRepository) : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Route("language")]
    public IActionResult OnGetSetCultureCookie(string culture)
    {
        string currentUrl = Request.GetDisplayUrl();
        string url = Request.Headers.Referer.ToString();
        Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
         );
        if (currentUrl == url)
            return RedirectToAction(nameof(Index));
        else
            return Redirect(url);
    }

    [HttpPost("clearcache")]
    public IActionResult ClearCache()
    {
        _generalRepository.RemoveCache();
        return Ok();
    }
}
