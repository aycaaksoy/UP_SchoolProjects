using Microsoft.AspNetCore.Mvc;

namespace CRM.UI.Layer.ViewComponents.Dashboard
{
    public class _HeadDashboardPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
