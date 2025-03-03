
namespace ASP.NET.API.DTos;

public record class CreateGameDTo(
string Name, 
string Genre, 
decimal Price, 
DateOnly ReleaseDate
);
