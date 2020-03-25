using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerSorcerer.Models
{
    public class EFPlayerRepository : IPlayerRepository
    {
        private ApplicationDbContext context;

        public EFPlayerRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public void AddPlayer(Player player)
        {
            context.Players.Add(player);
            context.SaveChanges();
        }
        public IQueryable<Player> Players => context.Players;
    }
}
