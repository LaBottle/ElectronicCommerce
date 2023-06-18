﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicCommerce.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase {
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService) {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegister request) {
        var response = await _authService.Register(
            new User {
                UserName = request.UserName,
                Address = request.Address
            },
            request.Password);

        if (!response.Success) {
            return BadRequest(response);
        }

        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<ActionResult<ServiceResponse<string>>> Login(UserLogin request) {
        var response = await _authService.Login(request.UserName, request.Password);

        if (!response.Success) {
            return BadRequest(response);
        }

        return Ok(response);
    }
    
    [HttpPost("change-password"), Authorize]
    public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword([FromBody] string newPassword) {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = await _authService.ChangePassword(int.Parse(userId), newPassword);
        
        if (!response.Success) {
            return BadRequest(response);
        }

        return Ok(response);
    }
    
    [HttpPost("change-address"), Authorize]
    public async Task<ActionResult<ServiceResponse<bool>>> ChangeAddress([FromBody] string newAddress) {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = await _authService.ChangeAddress(int.Parse(userId), newAddress);
        
        if (!response.Success) {
            return BadRequest(response);
        }

        return Ok(response);
    }
}