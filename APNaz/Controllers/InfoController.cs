using APNaz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace APNaz.Controllers;

public class InfoController : Controller   {

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

    public IActionResult CaptchaEmail()
    {
        ViewBag.Message = "CaptchaEmail";
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}

public class BibleController : Controller
{    

    public IActionResult Index()
    {
        ViewBag.Message = "Bible";
        return View();
    }

    public IActionResult OldTestament()
    {
        ViewBag.Message = "OldTestament";
        return View();
    }
    public IActionResult Amos()
    {
        ViewBag.Message = "Amos";
        return View();
    }

    public IActionResult Chronicles1()
    {
        ViewBag.Message = "Chronicles1";
        return View();
    }

    public IActionResult Chronicles2()
    {
        ViewBag.Message = "Chronicles2";
        return View();
    }

    public IActionResult Daniel()
    {
        ViewBag.Message = "Daniel";
        return View();
    }

    public IActionResult Deuteronomy()
    {
        ViewBag.Message = "Deuteronomy";
        return View();
    }

    public IActionResult Ecclesiastes()
    {
        ViewBag.Message = "Ecclesiastes";
        return View();
    }

    public IActionResult Esther()
    {
        ViewBag.Message = "Esther";
        return View();
    }

    public IActionResult Exodus()
    {
        ViewBag.Message = "Exodus";
        return View();
    }

    public IActionResult Ezekiel()
    {
        ViewBag.Message = "Ezekiel";
        return View();
    }

    public IActionResult Genesis()
    {
        ViewBag.Message = "Genesis";
        return View();
    }

    public IActionResult Habakkuk()
    {
        ViewBag.Message = "Habakkuk";
        return View();
    }

    public IActionResult Haggai()
    {
        ViewBag.Message = "Haggai";
        return View();
    }

    public IActionResult Hosea()
    {
        ViewBag.Message = "Hosea";
        return View();
    }

    public IActionResult Isaiah()
    {
        ViewBag.Message = "Isaiah";
        return View();
    }

    public IActionResult Jeremiah()
    {
        ViewBag.Message = "Jeremiah";
        return View();
    }
    public IActionResult Job()
    {
        ViewBag.Message = "Job";
        return View();
    }

    public IActionResult Joel()
    {
        ViewBag.Message = "Joel";
        return View();
    }
    public IActionResult Jonah()
    {
        ViewBag.Message = "Jonah";
        return View();
    }
    public IActionResult Joshua()
    {
        ViewBag.Message = "Joshua";
        return View();
    }
    public IActionResult Judges()
    {
        ViewBag.Message = "Judges";
        return View();
    }
    public IActionResult Kings1()
    {
        ViewBag.Message = "Kings1";
        return View();
    }
    public IActionResult Kings2()
    {
        ViewBag.Message = "Kings2";
        return View();
    }
    public IActionResult Lamentations()
    {
        ViewBag.Message = "Lamentations";
        return View();
    }
    public IActionResult Leviticus()
    {
        ViewBag.Message = "Leviticus";
        return View();
    }
    public IActionResult Malachi()
    {
        ViewBag.Message = "Malachi.";
        return View();
    }
    public IActionResult Micah()
    {
        ViewBag.Message = "Micah";
        return View();
    }
    public IActionResult Nahum()
    {
        ViewBag.Message = "Nahum";
        return View();
    }
    public IActionResult Nehemiah()
    {
        ViewBag.Message = "Nehemiah";
        return View();
    }
    public IActionResult Numbers()
    {
        ViewBag.Message = "Numbers";
        return View();
    }
    public IActionResult Obadiah()
    {
        ViewBag.Message = "Obadiah";
        return View();
    }
    public IActionResult Proverbs()
    {
        ViewBag.Message = "Proverbs";
        return View();
    }
    public IActionResult Psalms()
    {
        ViewBag.Message = "Psalms";
        return View();
    }
    public IActionResult Ruth()
    {
        ViewBag.Message = "Ruth";
        return View();
    }
    public IActionResult Samuel1()
    {
        ViewBag.Message = "Samuel1";
        return View();
    }
    public IActionResult Samuel2()
    {
        ViewBag.Message = "Samuel2";
        return View();
    }
    public IActionResult SongofSolomon()
    {
        ViewBag.Message = "SongofSolomon";
        return View();
    }
    public IActionResult Zechariah()
    {
        ViewBag.Message = "Zechariah";
        return View();
    }
    public IActionResult Zephaniah()
    {
        ViewBag.Message = "Zephaniah";
        return View();
    }

    public IActionResult NewTestament()
    {
        ViewBag.Message = "NewTestament";
        return View();
    }

    public IActionResult Matthew()
    {
        ViewBag.Message = "Matthew";
        return View();
    }

    public IActionResult Mark()
    {
        ViewBag.Message = "Mark";
        return View();
    }

    public IActionResult Luke()
    {
        ViewBag.Message = "Luke";
        return View();
    }

    public IActionResult John()
    {
        ViewBag.Message = "John";
        return View();
    }

    public IActionResult Acts()
    {
        ViewBag.Message = "Acts";
        return View();
    }

    public IActionResult Romans()
    {
        ViewBag.Message = "Romans";
        return View();
    }

    public IActionResult Corinthians1()
    {
        ViewBag.Message = "Corinthians1";
        return View();
    }

    public IActionResult Corinthians2()
    {
        ViewBag.Message = "Corinthians2";
        return View();
    }

    public IActionResult Galatians()
    {
        ViewBag.Message = "Galatians";
        return View();
    }

    public IActionResult Ephesians()
    {
        ViewBag.Message = "Ephesians";
        return View();
    }

    public IActionResult Philippians()
    {
        ViewBag.Message = "Philippians";
        return View();
    }

    public IActionResult Colossians()
    {
        ViewBag.Message = "Colossians";
        return View();
    }

    public IActionResult Thessalonians1()
    {
        ViewBag.Message = "Thessalonians1";
        return View();
    }

    public IActionResult Thessalonians2()
    {
        ViewBag.Message = "Thessalonians2";
        return View();
    }

    public IActionResult Timothy1()
    {
        ViewBag.Message = "Timothy1";
        return View();
    }

    public IActionResult Timothy2()
    {
        ViewBag.Message = "Timothy2";
        return View();
    }

    public IActionResult Titus()
    {
        ViewBag.Message = "Titus";
        return View();
    }

    public IActionResult Philemon()
    {
        ViewBag.Message = "Philemon";
        return View();
    }

    public IActionResult Hebrews()
    {
        ViewBag.Message = "Hebrews";
        return View();
    }

    public IActionResult James()
    {
        ViewBag.Message = "James";
        return View();
    }

    public IActionResult Peter1()
    {
        ViewBag.Message = "Peter1";
        return View();
    }

    public IActionResult Peter2()
    {
        ViewBag.Message = "Peter2";
        return View();
    }

    public IActionResult John1()
    {
        ViewBag.Message = "John1";
        return View();
    }

    public IActionResult John2()
    {
        ViewBag.Message = "John2";
        return View();
    }

    public IActionResult John3()
    {
        ViewBag.Message = "John3";
        return View();
    }

    public IActionResult Jude()
    {
        ViewBag.Message = "Jude";
        return View();
    }

    public IActionResult Revelation()
    {
        ViewBag.Message = "Revelation";
        return View();
    }

    public IActionResult Emergency()
    {
        ViewBag.Message = "Emergency";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
