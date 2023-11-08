using Microsoft.AspNetCore.Mvc;

namespace NetCoreAreas_0.Areas.Admin.Controllers
{

    //Area'lar Attribute olarak tanımlanmadan calıstırılamaz (Yer tutucu operatorlerine .Net 7 itibariyle giremiyor)

    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
