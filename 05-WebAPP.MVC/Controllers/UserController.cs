using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _05_WebAPP.MVC.Models;
using _05_WebAPP.MVC.Interfaces;

namespace _05_WebAPP.MVC.Controllers;

public class UserController : Controller
{
    protected IUserService _userService;

    private readonly ILogger<UserController> _logger;

    public UserController(
        ILogger<UserController> logger,
        IUserService userService
    )
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpPost]
    public IActionResult Add([FromForm] User user)
    {
        try
        {
            var result = _userService.Add(user);
            return Ok(user);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.GetBaseException().Message);
        }
    }
}
