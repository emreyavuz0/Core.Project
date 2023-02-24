using Core.Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.ViewComment
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID= 1,
                    UserName="Emre"
                },
                new UserComment
                {
                    ID= 2,
                    UserName="Murat"
                },
                new UserComment
                {
                    ID= 3,
                    UserName="Ayşe"
                }

            };

            return View(commentvalues);
        }
    }
}
