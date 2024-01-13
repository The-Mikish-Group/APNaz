using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using APNaz.Models;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace APNaz.Controllers
{
    public class GalleriesController : Controller
    {
        protected IActionResult CustomView(string viewName)
        {
            ViewData["ViewName"] = viewName;
            return View("Galleries");
        }

        public IActionResult Index() => CustomView("Galleries");
    }

    public class GalleryBaseController : Controller
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
        protected IActionResult GalleryView(string imagefolder = "Gallery")
        {
            ViewData["ViewName"] = imagefolder;
            return View();
        }
    }
    public class APNazController : GalleryBaseController { }
    public class APController : GalleryBaseController { }
    public class APNazSlideController : GalleryBaseController { }
    public class APSlideController : GalleryBaseController { }
    
    // public class FamilyController : GalleriesBaseController { }  

}
