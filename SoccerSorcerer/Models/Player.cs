//Shailendra Shukla - 301057291

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerSorcerer.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }
        public int JerseyNumber { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }

        public int ClubId { get; set; } // Foreign Key relationship, created as a shadow prop when not defined explicitly
        public Club Club { get; set; } // Navigation Property
    }
}
