using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _05_WebAPP.MVC.Models;

namespace _05_WebAPP.MVC.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    public IActionResult UserEntrar()
    {
        return View();
    }

    public IActionResult UserForm()
    {
        return View();
    }

}
