﻿using Food_Orders.Models.DTOs;
using Food_Orders.Models.Entities;
using Food_Orders.Services.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;

        public AccountController(
            UserManager<User> userManager,
            IUserService userService)
        {
            _userManager = userManager;
            _userService = userService;
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);

            if (user != null)
            {
                return BadRequest("The user already exists!");
            }

            var result = await _userService.RegisterUserAsync(dto);

            if (result)
            {
                return Ok(result);
            }

            return BadRequest("Nu s-au bagat bine date");
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO dto)
        {
            var token = await _userService.LoginUser(dto);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(new { token });
        }
    }
}
