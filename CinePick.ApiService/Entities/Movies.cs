using System.ComponentModel.DataAnnotations;

namespace CinePick.ApiService.Entites;

public class Movies
{
    public Guid Id { get; set; }

    [Required, MaxLength(255)]
    public string Title { get; set; }

    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }

    public ICollection<Genres> Genres { get; set; }
    public ICollection<WatchList> Watchlists { get; set; }
    public ICollection<UserMovieInteraction> Interactions { get; set; }
    
    //total ratings of all users basically average ratings and no' of ratings
    public double? AverageRating { get; set; }
    public int? RatingCount { get; set; }
}