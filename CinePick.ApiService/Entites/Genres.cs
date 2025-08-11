using System.ComponentModel.DataAnnotations;

namespace CinePick.ApiService.Entites;

public class Genre
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<MovieGenres> MovieGenres { get; set; }
}