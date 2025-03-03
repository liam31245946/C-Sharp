

namespace ASP.NET.API.Entities;

public class Game
{
    public int GenreId { get; set; }
    public Genre? Genre { get; set; }
    public decimal Price { get; set; }

    public DateOnly ReleaseDate{ get; set; }
}
