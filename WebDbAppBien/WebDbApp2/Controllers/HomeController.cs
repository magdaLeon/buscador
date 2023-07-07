using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebDbApp2.Miscellaneous;

namespace WebDbApp2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private DataAccess _dataaccess;


    public HomeController(DataAccess dataaccess, ILogger<HomeController> logger)
    {
        _dataaccess = dataaccess;
        _logger = logger;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult AltaMateria()
    {
        return View();
    }

    public IActionResult BajaMateria()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}