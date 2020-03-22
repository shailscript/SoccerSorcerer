using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerSorcerer.Models
{
    public class EFClubRepository : IClubRepository
    {
        private ApplicationDbContext context;

        public EFClubRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public void AddClub()
        {

        }
        public IQueryable<Club> Clubs => context.Clubs;
    }
}
