using Microsoft.AspNetCore.Mvc;
using Site.Web.Helpers;
using System.Data;

namespace Site.Web.Areas.Admin.Controllers
{
    [CustomAuthorize(Roles = "Admin")]
    [Area("Admin")]
    public class BaseController : Controller
    {

    }
}
