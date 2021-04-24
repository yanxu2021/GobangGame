using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace GobangGame.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            GameDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<GameDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Games.Any())
            {
                context.Games.AddRange(
                new Game
                {
                    ID = "1",
                    PlayerID = "yanX",
                    PlayerName = "YanXu"
                },
                new Game
                {
                    ID = "2",
                    PlayerID = "NeverTo",
                    PlayerName = "Kelly"
                },
                new Game
                {
                    ID="3",
                    PlayerID = "LOVE",
                    PlayerName = "Susan"
                },
                new Game
                {
                    ID="4",
                    PlayerID = "Gofor",
                    PlayerName = "Wang"
                });
                context.SaveChanges();
            }
        }
    }
}