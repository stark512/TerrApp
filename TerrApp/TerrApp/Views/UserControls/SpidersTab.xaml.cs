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

        public SpidersTab()
        {
            InitializeComponent();
            GetSpiderData();
        }

        public void GetSpiderData()
        {
            _ISpider = new SpiderService();
            ObservableCollection<Spider> spidersList = _ISpider.GetAllSpiders(Globals.LocalUserData.Id);


            dgrdSpiders.DataContext = spidersList;
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
    }
}
