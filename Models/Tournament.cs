using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WowArenaTracker.Models {
    public class Tournament {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        // Foreign keys
        public Series[] SeriesList { get; set; }
        // TODO: WinningTeam may be unneeded...
        public Team WinningTeam { get; set; }
    }
}
