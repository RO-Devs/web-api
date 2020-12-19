using BussinesLayer.Interfaces.Auth;
using DataLayer.Models.Auth;
using DataLayer.ViewModels.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AuthController(IAuthService service, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _service = service;
            _signInManager = signInManager;
            _userManager = userManager;
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserCreateVM user)
        {
            var response = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, false, false);
            if (!response.Succeeded) return BadRequest("invalid login");
            return Ok(_service.BuildToken(user.UserName));
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserCreateVM user)
        {
            var model = new ApplicationUser { Email = user.UserName, UserName = user.UserName };
            var response = await _userManager.CreateAsync(model, user.Password);
            if (!response.Succeeded) return BadRequest("invalid register. Retry");
            return Ok(_service.BuildToken(user.UserName));
        }


    }
}
