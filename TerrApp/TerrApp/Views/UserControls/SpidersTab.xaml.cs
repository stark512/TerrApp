using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using TerrApp.Interfaces;
using TerrApp.Services;
using TerrApp.Models;
using TerrApp.Controlers;
using System.Collections.ObjectModel;
using System.Reflection;

namespace TerrApp.User_Controls
{
    public partial class SpidersTab : UserControl
    {
        private ISpider _ISpider;
        #region PropertiesForBinding
        public string genusColumnText { get; set; }
        public string speciesColumnText { get; set; }
        public string sexColumnText { get; set; }
        public string typeColumnText { get; set; }
        public string purchaseDateColumnText { get; set; }
        public string birthDateColumnText { get; set; }
        public string deathDateColumnText { get; set; }
        public string lastFeedingDateColumnText { get; set; }
        public string activeColumnText { get; set; }
        #endregion

        public SpidersTab()
        {
            InitializeComponent();
            GetSpiderData();
        }

        public void GetSpiderData()
        {
            _ISpider = new SpiderService();
            try
            {
                ObservableCollection<Spider> spidersList = _ISpider.GetAllSpiders(Globals.LocalUserData.Id);
                dgrdSpiders.DataContext = spidersList;
            }
            catch (Exception ex)
            {
                Globals.Log.WriteLog(this.GetType().Name, ex.Message, LogType.Error, Globals.LocalUserData.Id);
            }            
        }

        private void Button_Click(object sender, RoutedEventArgs e) // add spider
        {
            //Button button = sender as Button;
            //if (button.Name == "btnDelete")
            //{
            //    _ISpider.DeleteSpider(int.Parse(tbxdeletespiderid.Text), Globals.LocalUserData.Id);
            //}
            //else
            //{
            //    Spider spider = new();
            //    spider.UserId = int.Parse(tbxuserid.Text);
            //    spider.Genus = tbxgenus.Text;
            //    spider.Species = tbxspecies.Text;
            //    spider.Sex = char.Parse(tbxsex.Text);
            //    spider.Type = tbxtype.Text;
            //    spider.PurchaseDate = DateTime.ParseExact(tbxpursache.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //    spider.BirthDate = DateTime.ParseExact(tbxbirth.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //    spider.DeathDate = spider.BirthDate = DateTime.ParseExact(tbxdeath.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //    spider.WebsideLink = tbxwebside.Text;
            //    spider.LastFeedingDate = DateTime.ParseExact(tbxlastfeeding.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //    spider.Note = tbxnote.Text;
            //    spider.IsActive = bool.Parse(tbxisactive.Text);

            //    _ISpider.SaveSpiderInDb(spider, spider.UserId);
            //}
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            BindingData();
        }

        /// <summary>
        /// Bind side menu data
        /// </summary>
        private void BindingData()
        {
            //this.DataContext = this;
            genusColumnText = Globals.Translation.grdMain.grdContent.SpidersTab.SpiderTable.GenusColumn;
            speciesColumnText = Globals.Translation.grdMain.grdContent.SpidersTab.SpiderTable.SpeciesColumn;
            sexColumnText = Globals.Translation.grdMain.grdContent.SpidersTab.SpiderTable.SexColumn;
            typeColumnText = Globals.Translation.grdMain.grdContent.SpidersTab.SpiderTable.TypeColumn;
            purchaseDateColumnText = Globals.Translation.grdMain.grdContent.SpidersTab.SpiderTable.PurchaseDateColumn;
            birthDateColumnText = Globals.Translation.grdMain.grdContent.SpidersTab.SpiderTable.BirthDateColumn;
            deathDateColumnText = Globals.Translation.grdMain.grdContent.SpidersTab.SpiderTable.DeathDateColumn;
            lastFeedingDateColumnText = Globals.Translation.grdMain.grdContent.SpidersTab.SpiderTable.LastFeedingDateColumn;
            activeColumnText = Globals.Translation.grdMain.grdContent.SpidersTab.SpiderTable.IsActiveColumn;
        }
    }
}
