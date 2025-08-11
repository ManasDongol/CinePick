namespace CinePick.ApiService.Entites;

public class WatchList
{
    public int UserId { get; set; }
    public ApplicationUsers ApplicationUser { get; set; }

    public int MovieId { get; set; }
    public Movies Movie { get; set; }

    public DateTime AddedAt { get; set; } = DateTime.UtcNow;
}