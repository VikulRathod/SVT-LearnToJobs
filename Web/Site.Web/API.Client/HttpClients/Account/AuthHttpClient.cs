using Microsoft.AspNetCore.Mvc;
using Site.Models;
using System.Text.Json;

namespace Site.Web.API.Client.HttpClients.Account
{
    public class AuthHttpClient : BaseHttpClient, IAuthHttpClient
    {
        public AuthHttpClient(IConfiguration config) : base(config) { }

        public IActionResult Register(UserSignUpModel userInfo)
        {
            using (ServiceClient)
            {
                var resource = string.Format("auth/register");
                var response = ServiceClient.PostAsJsonAsync(resource, userInfo).Result;

                if (response.IsSuccessStatusCode)
                    return new OkResult();

                return new BadRequestResult();
            }
        }

        public UserModel Validate(LoginModel model)
        {
            UserModel userModel = new UserModel();

            var resource = string.Format("auth/validate");
            var response = ServiceClient.PostAsJsonAsync(resource, model).Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                userModel = JsonSerializer.Deserialize<UserModel>(jsonString);
            }

            return userModel;
        }
    }
}
