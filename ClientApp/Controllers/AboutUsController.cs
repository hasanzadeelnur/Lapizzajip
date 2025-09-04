using Microsoft.AspNetCore.Mvc;
using ClientApp.Repositories;

namespace ClientApp.Controllers;
public class AboutUsController(IGeneralRepository _generalRepository) : Controller
{
    public async Task<IActionResult> Index()
    {
        ViewData[nameof(IGeneralRepository.GetAboutUs)] = await _generalRepository.GetAboutUs();
        ViewData[nameof(IGeneralRepository.GetServices)] = await _generalRepository.GetServices();
        return View();
    }
}
