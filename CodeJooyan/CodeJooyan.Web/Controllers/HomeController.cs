using Microsoft.AspNetCore.Mvc;

namespace CodeJooyan.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
