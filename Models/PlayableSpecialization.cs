using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WowArenaTracker.Models {
    public class PlayableSpecialization {
        public int ID { get; set; }
        public string Name { get; set; }

        // Foreign keys
        public PlayableClass PlayableClass { get; set; }
        public PlayableSpecializationRole PlayableSpecializationRole { get; set; }
    }
}
