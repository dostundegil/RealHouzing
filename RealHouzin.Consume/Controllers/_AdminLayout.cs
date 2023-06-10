using Microsoft.AspNetCore.Mvc;

namespace RealHouzin.Consume.Controllers
{
    public class _AdminLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult _HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult _AppBrandDemoPartial()
        {
            return PartialView();
        }
        public PartialViewResult _SidebarPartial()
        {
            return PartialView();
        }
        public PartialViewResult _NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult _FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult _ScriptsPartial()
        {
            return PartialView();
        }
    }
}
