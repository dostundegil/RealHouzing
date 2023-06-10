using Microsoft.AspNetCore.Mvc;

namespace RealHouzin.Consume.ViewComponents.Default
{
    public class _CallUsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
