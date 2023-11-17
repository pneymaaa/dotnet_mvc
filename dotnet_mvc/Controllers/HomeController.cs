using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_mvc.Models;
using dotnet_mvc.Data.Services;

namespace dotnet_mvc.Controllers;

public class HomeController : Controller
{
    private readonly IHomeServices _service;

    public HomeController(IHomeServices service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetSeed()
    {
        var data = _service.GenerateSeed();
        return View(data);
    }
}
