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

    [HttpGet]
    public IActionResult Data()
    {
        var data = _service.GetDataTable();
        return View(data);
    }

    [HttpPost]
    public IActionResult InsertData([FromBody] List<udt_Personal> udt_Personals)
    {
        string errorMessage;
        _service.InsertDataTable(udt_Personals, out errorMessage);
        return Json(errorMessage);
    }
}
