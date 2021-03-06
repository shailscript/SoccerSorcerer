﻿//Shailendra Shukla - 301057291

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerSorcerer.Models
{
    public class Club
    {
#nullable enable
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public string Stadium { get; set; }
        public string Owner { get; set; }
        public string? Website { get; set; }
        public string Location { get; set; }
        public string? Description { get; set; }
#nullable disable
        public ICollection<Player> Players { get; set; }
    }
}
