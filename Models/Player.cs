using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WowArenaTracker.Models {
    public class Player {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TwitchUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string PhotoUrl { get; set; }

        // Foreign keys
        public Team Team { get; set; }
        public Region Region { get; set; }
        public PlayableClass MainClass { get; set; }
        public PlayableClass[] AltClasses { get; set; }
    }
}
