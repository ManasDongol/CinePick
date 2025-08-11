using System.ComponentModel.DataAnnotations;

namespace CinePick.ApiService.Entites;

public class Genres
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<Genres> MovieGenres { get; set; }
}