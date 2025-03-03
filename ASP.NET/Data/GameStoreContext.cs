
using ASP.NET.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET.API.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext>options): DbContext(options)
{
    public DbSet<Game> Games{ get; set; }
}
