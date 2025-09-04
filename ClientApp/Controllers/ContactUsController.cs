using Infrastructure.Dtos.Messages;
using Microsoft.AspNetCore.Mvc;
using ClientApp.Repositories;

namespace ClientApp.Controllers;
public class ContactUsController(IGeneralRepository _generalRepository) : Controller
{
    public async Task<IActionResult> Index()
    {
        ViewData[nameof(IGeneralRepository.GetContactUs)] = await _generalRepository.GetContactUs();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(CreateMessageDto createMessageDto)
    {
        ViewData[nameof(IGeneralRepository.GetContactUs)] = await _generalRepository.GetContactUs();
        var textTranslations = await _generalRepository.GetTranslations();

        if (ModelState.IsValid)
        {
            var response = await _generalRepository.CreateCustomerMessage(createMessageDto);
            TempData["SuccessMessage"] = textTranslations["success_message"];
            TempData["SuccessMessageTitle"] = textTranslations["success_message_title"];
            return RedirectToAction("Index", "Home");
        }

        TempData["ErrorMessage"] = textTranslations["error_message"];
        TempData["ErrorMessageTitle"] = textTranslations["error_message_title"];
        return View(createMessageDto);
    }
}
