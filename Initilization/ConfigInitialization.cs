using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDLike_Simulator.Initilization;
using System.Xml;
using System.Xml.Linq;

namespace DnDLike_Simulator.Initilization
{
    internal class ConfigInitialization
    {
        private static string _applicationDirectoryLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DnD_Simulator";
        private static string _defaultConfigLocation = _applicationDirectoryLocation + "\\FileConfig.xml";

        public static void StartInitialization()
        {
            if (!File.Exists(_defaultConfigLocation))
            {
                try
                {
                    XDocument xDocument = new XDocument(
                        new XElement("Config",
                            new XElement("File",
                                new XElement("Name", "Config"),
                                new XElement("Path", _defaultConfigLocation))));

                    xDocument.Save(_defaultConfigLocation);
                } catch (Exception e)
                {
                    throw new Exception("Error occured while creating config at " + _defaultConfigLocation + ": " + e);
                }


                XDocument xmlDoc = new XDocument();
                if (!xmlDoc.Descendants("File").Where(x => x.Element("Name").Value == "Weapons").Any())
                {
                    try
                    {
                        XElement ConfigLevel = xmlDoc.Element("Config");
                        string weaponsFilePath = _applicationDirectoryLocation + "\\Weapons.json";

                        ConfigLevel.Add(
                                new XElement("File",
                                    new XElement("Name", "Weapons"),
                                    new XElement("Path", weaponsFilePath)));
                        xmlDoc.Save(_defaultConfigLocation);
                    } catch (Exception e)
                    {
                        throw new Exception("Error occured while adding weapons to config file: " + e);
                    }
                }
            }
        }
    }
}
