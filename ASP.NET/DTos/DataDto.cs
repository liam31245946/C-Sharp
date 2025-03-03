
namespace ASP.NET.DTos;

public record DataDTos(
int Id, 
string Name, 
string Genre, 
decimal Price, 
DateOnly ReleaseDate
);