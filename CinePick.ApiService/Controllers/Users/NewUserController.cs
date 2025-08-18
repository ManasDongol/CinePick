using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CinePick.ApiService.Controllers.Users.UserDto;
using CinePick.ApiService.Entites;

[ApiController]
[Route("api/[controller]")]
public class NewUserController : ControllerBase
{
    private readonly UserManager<ApplicationUsers> _userManager;

    public NewUserController(UserManager<ApplicationUsers> userManager)
    {
        _userManager = userManager;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var user = new ApplicationUsers
        {
            UserName = model.UserName,
            Email = model.Email
            
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            return Ok(new { message = "User created successfully." });
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return BadRequest(ModelState);
    }
}