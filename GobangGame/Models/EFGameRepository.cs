using System.Linq;

namespace GobangGame.Models
{
    public class EFGameRepository : IGameRepository
    {
        private GameDbContext context;
        public EFGameRepository(GameDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Game> Games => context.Games;
    }
}