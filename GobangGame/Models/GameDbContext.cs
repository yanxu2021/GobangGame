using Microsoft.EntityFrameworkCore;

namespace GobangGame.Models
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options):base(options) { }
        public DbSet<Game> Games { get; set; }
    }
}