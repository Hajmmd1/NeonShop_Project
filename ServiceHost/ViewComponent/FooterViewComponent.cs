using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class FooterViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
