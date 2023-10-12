using Microsoft.AspNetCore.Mvc;
using Site.Models;

namespace Site.Web.API.Client.HttpClients.Account
{
    public interface IAuthHttpClient
    {
        IActionResult Register(UserSignUpModel model);
        UserModel Validate(LoginModel model);
    }
}
