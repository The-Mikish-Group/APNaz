using Microsoft.AspNetCore.Mvc;
namespace APNaz.Controllers;

public class GalleryController : Controller {

    private readonly ILogger<GalleryController> _logger;

    public GalleryController(ILogger<GalleryController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        ViewBag.Message = "Gallery";
        return View();
    }

    // Our Views
    public IActionResult Gallery()
    {
        ViewBag.Message = "Gallery";
        return View();
    }
    public IActionResult Pictures01()
    {
        ViewBag.Message = "Pictures01";
        return View();
    }
    public IActionResult Pictures02()
    {
        ViewBag.Message = "Pictures02";
        return View();
    }
    public IActionResult Pictures03()
    {
        ViewBag.Message = "Pictures03";
        return View();
    }
    public IActionResult Videos01()
    {
        ViewBag.Message = "Videos01";
        return View();
    }
    public IActionResult Videos02()
    {
        ViewBag.Message = "Videos02";
        return View();
    }
    public IActionResult Videos03()
    {
        ViewBag.Message = "Videos03";
        return View();
    }
    public IActionResult WebArtSVG()
    {
        ViewBag.Message = "WebArtSVG";            
        return View();
    }
    public IActionResult WebArtJPG()
    {
        ViewBag.Message = "WebArtJPG";            
        return View();
    }
    public IActionResult WebArtPNG()
    {
        ViewBag.Message = "WebArtPNG";
        return View();
    }
    public IActionResult WebArtZIP()
    {
        ViewBag.Message = "WebArtZIP";            
        return View();
    }
    public IActionResult Logo()
    {
        ViewBag.Message = "Avon Park Nazarene Logo";
        return View();
    }
    public IActionResult Seal()
    {
        ViewBag.Message = "Nazarene Seal";
        return View();
    }
}
