﻿using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
}
