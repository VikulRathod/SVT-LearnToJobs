using Microsoft.AspNetCore.Mvc;
using Site.Web.Helpers;
using System.Data;

namespace Site.Web.Areas.User.Controllers
{
    [CustomAuthorize(Roles = "User")]
    [Area("User")]
    public class BaseController : Controller
    {

    }
}
