using Microsoft.AspNetCore.Mvc;

namespace RealHouzin.Consume.ViewComponents._UILayout
{
    public class _ScriptsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
