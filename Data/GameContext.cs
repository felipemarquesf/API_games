using Games.Models;
using Microsoft.EntityFrameworkCore;

namespace Games.Data;

public class GamesContext : DbContext
{
    public DbSet<GamesModel> Game {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=games.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}