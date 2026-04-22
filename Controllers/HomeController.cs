using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using top01.Models;

namespace top01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        grupo grupo = new grupo();
        ViewBag.integrantes = grupo.DevolverIntegrantes();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult SelectIntegrante(int dni)
    {
       grupo grupo = new grupo();
       ViewBag.integranteSeleccionado = grupo.GetIntegrante(dni);
       ViewBag.dni = dni;
       return View("infoIntegrante");
    }
}
