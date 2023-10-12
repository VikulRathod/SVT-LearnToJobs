using Microsoft.AspNetCore.Mvc;
using Site.Models;

namespace Site.Web.API.Client.Services.Account
{
    public interface IAuthApiController
    {
        IActionResult Register(UserSignUpModel model);
        UserModel Validate(LoginModel model);
    }
}
