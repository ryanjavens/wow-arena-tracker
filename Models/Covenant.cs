using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WowArenaTracker.Models {
    public class Covenant {
        public int ID { get; set; }
        public string Name { get; set; }
        // To look up info via API
        public int CovenantId { get; set; }
        public string LogoUrl { get; set; }
    }
}
