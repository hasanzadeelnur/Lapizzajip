﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminApp.Controllers;

[Authorize]
public class FileManagerController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
