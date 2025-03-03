

using ASP.NET.API.DTos;
using ASP.NET.DTos;

namespace ASP.NET.API.Endpoints;

public static class GamesEndpoints
{
const string GetGameEndpointName = "GetGame";

private static readonly List<DataDTos> games = new()
{
    new(1, "The Last Kingdom", "Action", 49.99m, new DateOnly(2023, 5, 12)),
    new (2, "Mystic Quest", "RPG", 59.99m, new DateOnly(2024, 1, 18)),
    new (3, "Cyber Odyssey", "Sci-Fi", 39.99m, new DateOnly(2022, 11, 5)),
    new (4, "Shadow Strike", "Shooter", 29.99m, new DateOnly(2021, 7, 22))
}; 

public static WebApplication MapGamesEndpoints(this WebApplication app){

    // GET (Read) all games
app.MapGet("/games",() => games);

// Get(Read) each games
app.MapGet("/games/{id}", (int id) => {
    var game = games.Find(game => game.Id == id);
    return game is not null ? Results.Ok(game) : Results.NotFound($"Game with ID {id} not found.");
}).WithName(GetGameEndpointName);

//Post(Create) or add a game
app.MapPost("/games", (CreateGameDTo newGame)=>{

    if(string.IsNullOrEmpty(newGame.Name)){
        return Results.BadRequest("Name is required");
    }

    DataDTos game = new DataDTos(
        games.Count+1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate
    );
    games.Add(game);

    return Results.CreatedAtRoute(GetGameEndpointName, new{id=game.Id}, game);
});

//put (Update) games
app.MapPut("games/{id}", (int id, UpdateGameDto updatedGame) =>
{
    var index = games.FindIndex(game => game.Id == id);
    if (index == -1)
    {
        return Results.NotFound();
    }

    // Update the existing game object
    games[index] = new DataDTos
    (
        id,  // Keep the same Id
        updatedGame.Name,
        updatedGame.Genre,
        updatedGame.Price,
        updatedGame.ReleaseDate
    );

    return Results.NoContent();
});

//Delete a game
app.MapDelete("/games/{id}", (int id) =>{
    games.RemoveAll(game => game.Id != id);
    return Results.NoContent();
});

return app;

}

} 
