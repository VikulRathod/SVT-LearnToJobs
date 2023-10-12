using Microsoft.AspNetCore.Mvc;

namespace Site.Web.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
