using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLike_Simulator.Classes
{
    internal class Weapon
    {
        public string WeaponName { get; set; }
        public string AttackType { get; set; }
        public int DiceAmount { get; set; } = 1;
        public int DiceType { get; set; } = 4;
        public string DamageType { get; set; }
        public Dictionary<string,string>? Requirements { get; set; }

        public int RollDamage()
        {
            int sum = 0;
            Random DiceRoll = new Random();

            for(int i = 0; i < DiceAmount; i++)
                sum += DiceRoll.Next(1, DiceType);

            return sum;
        }
    }
}
