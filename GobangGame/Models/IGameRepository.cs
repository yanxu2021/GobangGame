using System.Linq;

namespace GobangGame.Models
{
    public interface IGameRepository
    {
        IQueryable<Game> Games { get; }
    }
}