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
    public class BaseController : Controller
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
        protected IActionResult GalleryView(string viewName = "Gallery")
        {
            ViewData["ViewName"] = viewName;
            return View();
        }
    }
    public class APController : BaseController { }
    public class AP2Controller : BaseController { }  


    // Add more galleries here: (the controller name and the 'galleryfolder/ folderName should be the same)
    // Uncomment the line below to create a "Family" controller, then add a folder named "Family" to your 'galleryFolder' with images.
    //
    // public class FamilyController : BaseController { }  

}
