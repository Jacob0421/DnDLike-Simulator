using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
using DnDLike_Simulator.Classes;
using DnDLike_Simulator.Initilization;

string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string applicationDirectoryPath = filePath + "\\DnD_Simulator";

if (!Directory.Exists(applicationDirectoryPath))
    Directory.CreateDirectory(applicationDirectoryPath);

ConfigInitialization.StartInitialization();

WeaponInitialization.CheckForWeaponsList();

// Maybe Save State via JSON in documentsFolder
// Add Config file for where filepaths have been set
//Check if File Exists, if not then Add

// Weapon
    // Weapon Damage
    // Weapon Damage Type
    // isRanged
// Spell/Attack
    // DamageMin
    // DamageMax 
    // Damage Type
    // Description
    // Move Type (Action, Bonus Action)
    // RequiresSavingThrow?
    // SavingThrowType
    // AddSpell
    // Advantage/Normal/Disadvantage
// Character
    // Character Class
    // Character Level
    // Hit Points
    // Armor Class
    // Primary Stats (Strength, Dex, Consitution, Intelligence, Wisdom, Charisma)
// Battle
    // Character
    // Character Initiative
    // Move Order
    // IsAlive