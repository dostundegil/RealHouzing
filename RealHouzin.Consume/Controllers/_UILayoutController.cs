using Microsoft.AspNetCore.Mvc;

namespace RealHouzin.Consume.Controllers
{
    public class _UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
