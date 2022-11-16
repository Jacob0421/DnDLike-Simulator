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
        public Dictionary<string, int> Classes { get; set; }
        public string Name { get; init; }
        public int MaxHealthPoints { get; set; }
        public int CurrentHealthPoints { get; set; }
        public bool IsUnconscious { get; set; }
        public int CharacterLevel { get; set; } = 1;
        public Dictionary<Item, int> Inventory { get; set; }
        public Dictionary<string, int> PrimaryStats { get; set; } = new Dictionary<string, int>(){
            {"Strength", 8},
            {"Dexterity", 8},
            {"Constitution", 8},
            {"Intelligence", 8},
            {"Wisdom", 8},
            {"Charisma", 8}
        };
        public Dictionary<string, int> SecondaryStats { get; set; } = new Dictionary<string, int>(){
            {"Acrobatics", 8},
            {"Animal Handling", 8},
            {"Arcana", 8},
            {"Athletics", 8},
            {"Deception", 8},
            {"History", 8},
            {"Insight", 8},
            {"Intimidation", 8},
            {"Investigation", 8},
            {"Medicine", 8},
            {"Nature", 8},
            {"Perception", 8},
            {"Performance", 8},
            {"Persuasion", 8},
            {"Religion", 8},
            {"Sleight of Hand", 8},
            {"Stealth", 8},
            {"Survival", 8},
        };
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

        private int GetStatMod()
        {
            throw new NotImplementedException();
        }

        private void AddHealth(int healthGained)
        {
            if(CurrentHealthPoints == 0)
            {
                IsUnconscious = false;
            }
            CurrentHealthPoints += healthGained;
        }

        private void RemoveHealth(int healthLost)
        {
            CurrentHealthPoints -= healthLost;
            if (CurrentHealthPoints <= 0)
            {
                CurrentHealthPoints = 0;
                IsUnconscious = true;
            }
        }

    }
}
