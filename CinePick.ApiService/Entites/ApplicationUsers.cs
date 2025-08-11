using System.ComponentModel.DataAnnotations;

namespace CinePick.ApiService.Entites;

public class ApplicationUsers 
{
    
    public ICollection<WatchList> Watchlists { get; set; }
    public ICollection<UserMovieInteraction> MovieInteractions { get; set; }
}