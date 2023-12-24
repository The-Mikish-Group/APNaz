using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using APNaz.Models;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace APNaz.Controllers
{
    public class BaseController : Controller
    {
        protected IActionResult GalleryView(string viewName = "Gallery")
        {
            ViewData["ViewName"] = viewName;
            return View();
            }
        }

    public class GalleriesController : BaseController
    {
        public IActionResult Index() => View("Galleries");
    }

    // AP Gallery
    public class APController : BaseController
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
    }

    // AP Gallery 2
    public class AP2Controller : BaseController
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
    }

    // MV Gallery (Follow format to add more galleries) ;
    // make sure to create a gallery folder under
    // wwwroot\gallery with the same name.
    // That is it for adding additional galleries.

    public class MVController : BaseController
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
    }
   
}
