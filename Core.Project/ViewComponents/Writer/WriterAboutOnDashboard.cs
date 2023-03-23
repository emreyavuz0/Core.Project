using Microsoft.AspNetCore.Mvc;

namespace Core.Project.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
