using Microsoft.AspNetCore.Mvc;

namespace Core.Project.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
