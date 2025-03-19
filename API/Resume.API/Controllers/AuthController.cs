using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto;
using Resume.API.PostModels;
using Resume.Core.DTOs;
using Resume.Core.IServices;
using Resume.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resume.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public AuthController(IAuthService authService, IUserService userService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            try
            {
                var (token, user) = await _authService.LoginAsync(login);
                var dtoUser = _mapper.Map<UserDTO>(user);
                return Ok(new { Token = token, User = dtoUser });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserPostModel userPost)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var passwordHash = BCrypt.Net.BCrypt.HashPassword(userPost.PasswordHash);

                var user = new User
                {
                    Username = userPost.Username,
                    Phone = userPost.Phone,
                    Email = userPost.Email,
                    Address = userPost.Adrress,
                    PasswordHash = passwordHash,
                };

                var token = await _authService.RegisterUserAsync(user);
                return Ok(new { Token = token });
            }
            catch (UnauthorizedAccessException ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
