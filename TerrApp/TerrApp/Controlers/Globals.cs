using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TerrApp.Interfaces;
using TerrApp.Models;
using TerrApp.Models.TranslateModels;
using TerrApp.Services;

namespace TerrApp.Controlers
{
    public static class Globals
    {        
        public static Connection Connection = new();
        private static IUser _IUser = new UserService();
        public static User LocalUserData = _IUser.GetLocalUserData();
        public static Root TranslationCore = DeserializeJson();

        private static Root DeserializeJson()
        {
            string jsonString = string.Empty;
            //LocalUserData.Language = "ENG";
            if (LocalUserData.Language == "PL")
            {
                if (File.Exists(@"..\..\..\Configs\Lan_PL.json"))
                {
                    jsonString = File.ReadAllText(@"..\..\..\Configs\Lan_PL.json");
                }
                else
                {
                    throw new Exception("File not fund! : Translations PL");
                }
            }
            else if (LocalUserData.Language == "ENG")
            {
                if (File.Exists(@"..\..\..\Configs\Lan_ENG.json"))
                {
                    jsonString = File.ReadAllText(@"..\..\..\Configs\Lan_ENG.json");
                }
                else
                {
                    throw new Exception("File not fund! : Translations ENG");
                }                
            }
            return JsonConvert.DeserializeObject<Root>(jsonString);
        }

    }
}
