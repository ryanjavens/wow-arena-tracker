using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WowArenaTracker.Models {
    public class Talent {
        public int ID { get; set; }
        public string Name { get; set; }
        // Use spell ID so we can look it up via Wowhead or Blizz api for effects
        public string SpellId { get; set; }
        public string LogoUrl { get; set; }
        // Use flag to denote PvP talents instead of creating a separate data model
        public bool isPvp { get; set; }

        // Foreign key
        public PlayableClass PlayableClass { get; set; }
    }
}
