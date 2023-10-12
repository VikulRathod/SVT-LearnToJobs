using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Web.API.Client.HttpClients.Account;

namespace Site.Web.API.Client.Services.Account
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthApiController : ControllerBase, IAuthApiController
    {
        IAuthHttpClient _auth;

        public AuthApiController(IAuthHttpClient auth)
        {
            _auth = auth;
        }

        [HttpPost]
        [Route("api/register")]
        public IActionResult Register(UserSignUpModel model)
        {
            return _auth.Register(model);
        }

        [HttpPost]
        [Route("api/validate")]
        public UserModel Validate(LoginModel model)
        {
            return _auth.Validate(model);
        }
    }
}
