using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using APNaz.Models;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace APNaz.Controllers
{
    public class SlideshowsController : Controller
    {
        protected IActionResult CustomView(string viewName)
        {
            ViewData["ViewName"] = viewName;
            return View("Slideshows");
        }

        public IActionResult Index() => CustomView("Slideshows");
    }
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

    //public class SlideshowBaseController : Controller
    //{
    //    public IActionResult Index() => SlideshowView();
    //    public IActionResult Slideshow(string viewName) => SlideshowView(viewName);
    //    protected IActionResult SlideshowView(string viewName = "Slideshow")
    //    {
    //        ViewData["ViewName"] = viewName;
    //        return View();
    //    }
    //}
    //public class APNazSlideController : SlideshowBaseController { }
    //public class APSlideController : SlideshowBaseController { }


    // Add more galleries here: (the controller name and the 'galleryfolder/ folderName should be the same)
    // Uncomment the line below to create a "Family" controller, then add a folder named "Family" to your 'galleryFolder' with images.
    //
    // public class FamilyController : GalleriesBaseController { }  

}
