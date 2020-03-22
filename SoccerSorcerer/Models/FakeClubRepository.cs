//Shailendra Shukla - 301057291

using System.Collections.Generic;
using System.Linq;

namespace SoccerSorcerer.Models
{
    public class FakeClubRepository //: IClubRepository
    {
        private static List<Club> clubs = new List<Club>
        {
            new Club
            {
                Id = 1,
                Name = "Juventus",
                Manager = "Michael Someone",
                Stadium = "ABC Stadium",
                Owner = "Michael Something",
                Website = "www.example.com",
                Location = "Ontario",
                Description = "World class players. A football club can't get any better."
            },
            new Club
            {
                Id = 2,
                Name = "Soccer Sorcerer",
                Manager = "Shail Napster",
                Stadium = "Best Stadium",
                Owner = "Shail Napster",
                Website = "www.shailendrashukla.com",
                Location = "Yukon",
                Description = "We don't play sport, we breathe sport. A few more lines of club description."
            }
        };

        public static IQueryable<Club> Clubs
        {
            get
            {
                return clubs.AsQueryable<Club>();
            }
        }

        public static void AddClub(Club c)
        {
            clubs.Add(c);
        }
    }
}
