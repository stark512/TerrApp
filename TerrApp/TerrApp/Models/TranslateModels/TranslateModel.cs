using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models.TranslateModels
{
    public class ConfigGlobals
    {
        public SpidersTypes SpidersTypes { get; set; }
        public SpidersGender SpidersGender { get; set; }
    }

    public class GrdContent
    {
        public SpidersTab SpidersTab { get; set; }
    }

    public class GrdMain
    {
        public SpnSideMenu spnSideMenu { get; set; }
        public GrdContent grdContent { get; set; }
    }

    public class Root
    {
        public Root()
        {

        }
        public Translation Translation { get; set; }
    }

    public class SpidersGender
    {
        public string Female { get; set; }
        public string Male { get; set; }
    }

    public class SpidersTab
    {
        public SpiderTable SpiderTable { get; set; }
    }

    public class SpidersTypes
    {
        public string Arboreal { get; set; }
        public string Terrestrial { get; set; }
        public string Subterranean { get; set; }
        public string Other { get; set; }
    }

    public class SpiderTable
    {
        public string GenusColumn { get; set; }
        public string SpeciesColumn { get; set; }
        public string SexColumn { get; set; }
        public string TypeColumn { get; set; }
        public string PurchaseDateColumn { get; set; }
        public string BirthDateColumn { get; set; }
        public string DeathDateColumn { get; set; }
        public string LastFeedingDateColumn { get; set; }
        public string IsActiveColumn { get; set; }
    }

    public class SpnSideMenu
    {
        public string AddButton { get; set; }
        public string AddSpiderButton { get; set; }
        public string AddMoltButton { get; set; }
        public string AddCopulationButton { get; set; }
        public string MainMenuButton { get; set; }
        public string SpidersButton { get; set; }
        public string MoltsButton { get; set; }
        public string CopulationsButton { get; set; }
        public string StatsButton { get; set; }
        public string SettingsButton { get; set; }
    }

    public class Translation
    {
        public ConfigGlobals ConfigGlobals { get; set; }
        public GrdMain grdMain { get; set; }
    }
}
