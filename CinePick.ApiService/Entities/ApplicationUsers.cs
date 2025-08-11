using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace CinePick.ApiService.Entites;

public class ApplicationUsers : IdentityUser<Guid>
{
    
    public ICollection<WatchList> Watchlists { get; set; }
    public ICollection<UserMovieInteraction> MovieInteractions { get; set; }
}