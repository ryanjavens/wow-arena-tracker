using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WowArenaTracker.Models {
    public class Team {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string WebsiteUrl { get; set; }

        // Foreign keys
        public Region Region { get; set; }
        public Player[] TeamMembers { get; set; }
    }
}
