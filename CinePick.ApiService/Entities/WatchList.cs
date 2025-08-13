using System.ComponentModel.DataAnnotations;

namespace CinePick.ApiService.Entites;

public class WatchList
{
    [Key] 
    public Guid UserId { get; set; }
    public ApplicationUsers ApplicationUser { get; set; }

    public Guid MovieId { get; set; }
    public Movies Movie { get; set; }

    public DateTime AddedAt { get; set; } = DateTime.UtcNow;
}