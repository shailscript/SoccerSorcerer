using Microsoft.EntityFrameworkCore;
namespace SoccerSorcerer.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}