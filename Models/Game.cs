using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WowArenaTracker.Models {
    public class Game {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        // Foreign keys
        public Team[] Teams { get; set; }
        public Team Winner { get; set; }
        public Team Loser { get; set; }
        // TODO: Need a Game-->Team-->Players association table
        // TODO: Need a Game-->Team-->Players-->Classes association
        // TODO: Need a Game-->Team-->Players-->Classes-->Races association
        // TODO: Need a Game-->Team-->Players-->Classes-->Talents association
        // TODO: Need a Game-->Team-->Players-->classes-->Covenants association
    }
}
