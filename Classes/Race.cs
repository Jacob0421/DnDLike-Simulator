using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLike_Simulator.Classes
{
    public class Race
    {
        public string PrimaryRace { get; set; }
        public string SecondaryRace { get; set; }
        public Dictionary<string, int> AbilityBonuses { get; set; }
    }
}
