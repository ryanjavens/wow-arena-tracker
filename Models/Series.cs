using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WowArenaTracker.Models {
    public class Series {
        public int ID { get; set; }
        
        // Foreign keys
        public Team[] Teams { get; set; }
        public int WinningTeamScore { get; set; }
        public int LosingTeamScore { get; set; }
        public Game[] Games { get; set; }
    }
}
