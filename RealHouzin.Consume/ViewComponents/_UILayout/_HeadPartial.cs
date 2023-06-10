using Microsoft.AspNetCore.Mvc;

namespace RealHouzin.Consume.ViewComponents._UILayout
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
