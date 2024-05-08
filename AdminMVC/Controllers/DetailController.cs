using Microsoft.AspNetCore.Mvc;

namespace AdminMVC.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
