using Microsoft.AspNetCore.Mvc;

namespace RealHouzin.Consume.ViewComponents._UILayout
{
    public class _CustomizerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
