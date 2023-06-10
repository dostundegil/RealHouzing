using Microsoft.AspNetCore.Mvc;

namespace RealHouzin.Consume.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
