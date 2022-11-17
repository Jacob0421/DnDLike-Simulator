using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDLike_Simulator.Classes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DnDLike_Simulator.Initilization
{
    internal class WeaponInitialization
    {
        private static string _defaultWeaponsListLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DnD_Simulator\\Weapons.json";

        public static void CheckForWeaponsList()
        {
            if (!File.Exists(_defaultWeaponsListLocation))
            {
                LoadWeapons();
            }
        }

        private static async void LoadWeapons()
        {
            List<Weapon> _weapons = new List<Weapon>();

            _weapons.Add(new Weapon
            {
                Name = "ShortSword",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Piercing"
            });

            _weapons.Add(new Weapon
            {
                Name = "Club",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Bludgeoning"
            });

            _weapons.Add(new Weapon
            {
                Name = "Dagger",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Piercing"
            });

            _weapons.Add(new Weapon
            {
                Name = "Great Club",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Bludgeoning",
                Requirements = new Dictionary<string, string>() { { "Hands", "Two-Handed" } }
            });

            _weapons.Add(new Weapon
            {
                Name = "Handaxe",
                AttackType = "Melee/Ranged",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Slashing"
            });

            _weapons.Add(new Weapon
            {
                Name = "Javelin",
                AttackType = "Melee/Ranged",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Piercing"
            });

            _weapons.Add(new Weapon
            {
                Name = "Light Hammer",
                AttackType = "Melee/Ranged",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Bludgeoning"
            });

            _weapons.Add(new Weapon
            {
                Name = "Mace",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Bludgeoning"
            });

            _weapons.Add(new Weapon
            {
                Name = "Quarterstaff",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Bludgeoning"
            });

            _weapons.Add(new Weapon
            {
                Name = "Sickle",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Slashing"
            });

            _weapons.Add(new Weapon
            {
                Name = "Spear",
                AttackType = "Melee/Ranged",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Piercing"
            });

            _weapons.Add(new Weapon
            {
                Name = "Light Crossbow",
                AttackType = "Ranged",
                DiceAmount = 1,
                DiceType = 8,
                DamageType = "Piercing",
                Requirements = new Dictionary<string, string>() { { "Hands", "Two-Handed" } }
            });

            _weapons.Add(new Weapon
            {
                Name = "Dart",
                AttackType = "Ranged",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Piercing"
            });

            _weapons.Add(new Weapon
            {
                Name = "Shortbow",
                AttackType = "Ranged",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Piercing",
                Requirements = new Dictionary<string, string>() { { "Hands", "Two-Handed" } }
            });
            

            _weapons.Add(new Weapon
            {
                Name = "Sling",
                AttackType = "Ranged",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Bludgeoning"
            });


            await using FileStream newFileStream = File.Create(_defaultWeaponsListLocation);

            await JsonSerializer.SerializeAsync(newFileStream, _weapons, new JsonSerializerOptions { WriteIndented = true});
        }
    }
}
