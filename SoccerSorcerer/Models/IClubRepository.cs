using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerSorcerer.Models
{
    public interface IClubRepository
    {
        IQueryable<Club> Clubs { get; }
        public void AddClub();
    }
}
