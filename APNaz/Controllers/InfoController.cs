using APNaz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace APNaz.Controllers;

public class InfoController : Controller   {

    private readonly ILogger<InfoController> _logger;

    public InfoController(ILogger<InfoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Message = "Home";
        return View();
    }

    public IActionResult Contact()
    {
        ViewBag.Message = "Contact";                       
        return View();
    }
    public IActionResult Members()
    {
        ViewBag.Message = "Members";
        return View();
    }    
    public IActionResult Worship()
    {
        ViewBag.Message = "Worship";
        return View();
    }
    public IActionResult TOS()
    {
        ViewBag.Message = "TOS";
        return View();
    }
    public IActionResult Privacy()
    {
        ViewBag.Message = "Privacy";
        return View();
    }
    public IActionResult Calendar()        
    {
        ViewBag.Message = "Calendar";            
        return View();
    }
    public IActionResult Staff()
    {
        ViewBag.Message = "Staff";
        return View();
    }
    public IActionResult Purpose()
    {
        ViewBag.Message = "Purpose";
        return View();
    }
    public IActionResult Nazarenes()
    {
        ViewBag.Message = "Nazarenes";
        return View();
    }
    public IActionResult Links()
    {
        ViewBag.Message = "Links";
        return View();
    }
    
    public IActionResult Colors()
    {
        ViewBag.Message = "Colors";
        return View();
    }    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
