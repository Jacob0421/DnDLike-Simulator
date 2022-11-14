using System;
using DnDLike_Simulator.Initilization;

string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string applicationDirectoryPath = filePath + "\\DnD_Simulator";

if (!Directory.Exists(applicationDirectoryPath))
    Directory.CreateDirectory(applicationDirectoryPath);

ConfigInitialization.StartInitialization();

WeaponInitialization.CheckForWeaponsList();

