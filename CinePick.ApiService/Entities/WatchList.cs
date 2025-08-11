namespace CinePick.ApiService.Entites;

public class WatchList
{
    public Guid UserId { get; set; }
    public ApplicationUsers ApplicationUser { get; set; }

    public Guid MovieId { get; set; }
    public Movies Movie { get; set; }

    public DateTime AddedAt { get; set; } = DateTime.UtcNow;
}