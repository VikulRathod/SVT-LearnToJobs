using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Site.Data.Entities;
using Site.Models;
using Site.Services.Interfaces;

namespace Site.API.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;
        IMapper _mapper;
        ILogger<AuthController> _logger;

        public AuthController(IAuthService authService, ILogger<AuthController> logger, IMapper mapper)
        {
            _authService = authService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Register(UserSignUpModel model)
        {
            _logger.LogInformation($"New user create request arrived @ {DateTime.Today}");

            User user = new User
            {
                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,
                CreatedDate = DateTime.Now
            };

            bool result = _authService.CreateUser(user, model.Role);
            if (result)
            {
                _logger.LogInformation($"New user create request succeeded @ {DateTime.Today}");
                return StatusCode(StatusCodes.Status201Created);
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }            
        }

        [HttpPost]
        public UserModel Validate(LoginModel model)
        {
            _logger.LogInformation($"New user login request arrived @ {DateTime.Today}");
            return _authService.ValidateUser(model.Username, model.Password);
        }
    }
}
