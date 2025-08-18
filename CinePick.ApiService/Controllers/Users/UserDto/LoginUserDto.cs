using System.ComponentModel.DataAnnotations;

namespace CinePick.ApiService.Controllers.Users.UserDto;

public class LoginUserDto
{
    [Required] 
    public string UserName { get; set; }
    

    [Required] 
    [MinLength(6)] 
    public string Password { get; set; }
}