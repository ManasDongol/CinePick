using System.ComponentModel.DataAnnotations;

namespace CinePick.ApiService.Entites;

public class UserMovieInteraction
{
    [Key]
    public Guid UserId { get; set; }
    public ApplicationUsers ApplicationUser { get; set; }

    public Guid MovieId { get; set; }
    public Movies Movie { get; set; }

    public double? Rating { get; set; } // 1 to 5 stars
    public bool IsLiked { get; set; } = false;
    public bool IsWatched { get; set; } = false;

    public DateTime InteractionDate { get; set; } = DateTime.UtcNow;
}