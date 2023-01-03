using Microsoft.AspNetCore.Mvc;

namespace CRM.UI.Layer.ViewComponents.Dashboard
{
    public class _ChartDashboardPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
