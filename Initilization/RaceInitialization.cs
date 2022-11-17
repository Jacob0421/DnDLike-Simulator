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
    public class RaceInitialization
    {
        private static string _defaultRaceListLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DnD_Simulator\\Races.json";

        public static void CheckforRaceList()
        {
            if (!File.Exists(_defaultRaceListLocation))
            {
                LoadRaces();
            }
        }

        public static async void LoadRaces()
        {

            List<Race> _races= new List<Race>();

            _races.Add(new Race
            {
                PrimaryRace = "Dwarves",
                SecondaryRace = "Hill Dwarf",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Constituition", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Dwarves",
                SecondaryRace = "Mountain Dwarf",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Constituition", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Elf",
                SecondaryRace = "High Elf",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Dexterity", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Elf",
                SecondaryRace = "Wood Elf",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Dexterity", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Elf",
                SecondaryRace = "Dark Elf (Drow)",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Dexterity", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "HalfLing",
                SecondaryRace = "Lightfoot",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Dexterity", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Elf",
                SecondaryRace = "Stout",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Dexterity", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Human",
                SecondaryRace = "Human",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"All", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Human",
                SecondaryRace = "Variant Human",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"All", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "DragonBorn",
                SecondaryRace = "DragonBorn",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Strength", 2},
                    {"Charisma", 1},
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Gnome",
                SecondaryRace = "Deep Gnome",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Intelligence", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Gnome",
                SecondaryRace = "Rock Gnome",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Intelligence", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Half-Elf",
                SecondaryRace = "Half-Elf",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Choice", 2}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Half-Orc",
                SecondaryRace = "Half-Orc",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Strength", 2},
                    {"Constitution", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Asmodeus",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Baalzebul",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Dispater",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Fierna",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Glasya",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Levistus",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Mommon",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Mephistopheles",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Zariel",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });

            _races.Add(new Race
            {
                PrimaryRace = "Tiefling",
                SecondaryRace = "Variant",
                AbilityBonuses = new Dictionary<string, int>()
                {
                    {"Charisma", 2},
                    {"Intelligence", 1}
                }
            });


            await using FileStream newFileStream = File.Create(_defaultRaceListLocation);

            await JsonSerializer.SerializeAsync(newFileStream, _races, new JsonSerializerOptions { WriteIndented = true });

        }
    }
}
