using Microsoft.AspNetCore.Components;

namespace CinePick.Web.Components.Features.LoginFeature;

public partial class Login:ComponentBase
{
    [Inject] public HttpClient Http { get; set; }
    [Inject] public NavigationManager Navigation { get; set; }

    protected string UserName { get; set; } = string.Empty;
    protected string Password { get; set; } = string.Empty;

    public async Task HandleLogin()
    {
        
    }

}