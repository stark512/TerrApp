using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TerrApp.Interfaces;
using TerrApp.Models;
using TerrApp.Models.Translation_Config;
using TerrApp.Services;

namespace TerrApp.Controlers
{
    public static class Globals
    {        
        public static Connection Connection = new();
        private static IUser _IUser = new UserService();
        /// <summary>
        /// User from local DB
        /// </summary>
        public static User LocalUserData = _IUser.GetLocalUserData();
        public static Translations Translations = LoadTranlations();

        private static Translations LoadTranlations()
        {
            string fileName = string.Empty;
            switch (LocalUserData.Language)
            {
                case "PL":
                    fileName = "Lan_PL.xml";
                    break;
                case "ENG":
                    fileName = "Lan_ENG.xml";
                    break;
            }
            XmlSerializer XmlSerializer = new XmlSerializer(typeof(Translations));
            FileStream XmlFileStream = new FileStream(@"../../../Configs/" + fileName, FileMode.Open);
            return (Translations)XmlSerializer.Deserialize(XmlFileStream);
        }

        //private Config ReadXML()
        //{
        //    XmlSerializer XmlSerializer = new XmlSerializer(typeof(Config));
        //    FileStream XmlFileStream = new FileStream(@"../../../JSON_Files/Config.xml", FileMode.Open);
        //    Config config = (Config)XmlSerializer.Deserialize(XmlFileStream);

        //    return config;
        //}

    }
}
