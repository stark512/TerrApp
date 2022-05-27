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
            List<Spider> spidersList = _ISpider.GetAllSpiders(Globals.LocalUserData.Id);

            string[] columnNames = { "ID pająka", "ID Użytkownika", "Gatunek", "Rodzaj", "Płeć", "Typ", "Data zakupu", "Data urodzin", "Data ostatniego karmienia", "Aktywny" };
            using (DataTable dataTable = new())
            {
                for (int i = 0; i < columnNames.Length; i++)
                {
                    dataTable.Columns.Add(columnNames[i]);
                }

                foreach (Spider spider in spidersList)
                {
                    dataTable.Rows.Add(spider.SpiderId, spider.UserId, spider.Genus, spider.Species, spider.Sex, spider.Type, spider.PurchaseDate, spider.BirthDate,
                        spider.LastFeedingDate, spider.IsActive);
                }
                dgrdData.ItemsSource = dataTable.AsDataView();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == "btnDelete")
            {                
                _ISpider.DeleteSpider(int.Parse(tbxdeletespiderid.Text), Globals.LocalUserData.Id);
            }
            else
            {
                Spider spider = new();
                spider.UserId = int.Parse(tbxuserid.Text);
                spider.Genus = tbxgenus.Text;
                spider.Species = tbxspecies.Text;
                spider.Sex = char.Parse(tbxsex.Text);
                spider.Type = tbxtype.Text;
                spider.PurchaseDate = DateTime.ParseExact(tbxpursache.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                spider.BirthDate = DateTime.ParseExact(tbxbirth.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                spider.DeathDate = spider.BirthDate = DateTime.ParseExact(tbxdeath.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                spider.WebsideLink = tbxwebside.Text;
                spider.LastFeedingDate = DateTime.ParseExact(tbxlastfeeding.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                spider.Note = tbxnote.Text;
                spider.IsActive = bool.Parse(tbxisactive.Text);

                _ISpider.SaveSpiderInDb(spider, spider.UserId);
            }         
        }
        private static ObservableCollection<T> ConvertDataTable<T>(DataTable dt)
        {
            ObservableCollection<T> data = new ObservableCollection<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
