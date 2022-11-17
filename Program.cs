using System;
using DnDLike_Simulator.Initilization;


string applicationDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DnD_Simulator";

if (!Directory.Exists(applicationDirectoryPath))
    Directory.CreateDirectory(applicationDirectoryPath);

ConfigInitialization.StartInitialization();
WeaponInitialization.CheckForWeaponsList();
RaceInitialization.LoadRaces();
