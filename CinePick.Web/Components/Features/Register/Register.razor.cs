using Microsoft.AspNetCore.Components;

namespace CinePick.Web.Components.Features.Register;

public partial class Register:ComponentBase
{
    [Inject] public HttpClient Http { get; set; }
    [Inject] public NavigationManager Navigation { get; set; }

    protected string Username { get; set; } = string.Empty;
    protected string Password { get; set; } = string.Empty;
    protected string Email { get; set; } = string.Empty;
    protected string reEnteredPassword { get; set; } = string.Empty;

    public async Task HandleSignUp()
    {
        
    }
}