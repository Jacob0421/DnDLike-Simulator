using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLike_Simulator.Classes
{
    internal class Character
    {
        public int CharacterId { get; set; }
        public Dictionary<string,int> Classes { get; init; }
        public string Name { get; init; }
        public int HealthPoints { get; init; }
        public int CharacterLevel { get; init; } = 1;
        public Dictionary<Item,int> Inventory { get; set; }
        public Dictionary<string,int> Stats { get; init; }
        public List<Effects> CurrentEffects { get; set; }

        private int GetCharacterId()
        {
            throw new NotImplementedException();
        }

        private bool verifyCharacterLevel()
        {
            throw new NotImplementedException();
        }

        private bool AddToInventory(Item itemToAdd)
        {
            throw new NotImplementedException();
        }

        private bool RemoveFromInventory()
        {
            throw new NotImplementedException();
        }

    }
}
