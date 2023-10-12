using Microsoft.AspNetCore.Mvc;

namespace Site.Web.Areas.User.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
