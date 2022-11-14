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
        private static string _applicationDirectoryLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DnD_Simulator";
        private static string _defaultWeaponsListLocation = _applicationDirectoryLocation + "\\Weapons.json";

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
                WeaponName = "ShortSword",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Piercing"
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "Club",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Bludgeoning"
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "Dagger",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Piercing"
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "GreatClub",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Bludgeoning",
                Requirements = new Dictionary<string, string>() { { "Hands", "Two-Handed" } }
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "Handaxe",
                AttackType = "Melee/Ranged",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Slashing"
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "Javelin",
                AttackType = "Melee/Ranged",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Piercing"
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "Light Hammer",
                AttackType = "Melee/Ranged",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Bludgeoning"
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "Mace",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Bludgeoning"
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "QuarterStaff",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Bludgeoning"
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "Sickle",
                AttackType = "Melee",
                DiceAmount = 1,
                DiceType = 4,
                DamageType = "Slashing"
            });

            _weapons.Add(new Weapon
            {
                WeaponName = "Spear",
                AttackType = "Melee/Ranged",
                DiceAmount = 1,
                DiceType = 6,
                DamageType = "Piercing"
            });


            await using FileStream newFileStream = File.Create(_defaultWeaponsListLocation);

            await JsonSerializer.SerializeAsync(newFileStream, _weapons, new JsonSerializerOptions { WriteIndented = true});
        }
    }
}
