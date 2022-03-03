using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
