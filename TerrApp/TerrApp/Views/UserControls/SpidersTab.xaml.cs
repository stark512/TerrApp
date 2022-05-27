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
using System.Collections.ObjectModel;
using TerrApp.Models;
using System.Reflection;

namespace TerrApp.User_Controls
{
    public partial class SpidersTab : UserControl
    {
        private SqlConnection _Connection = new(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Environment.CurrentDirectory + @"\UserData.mdf;Integrated Security = True");
        public ObservableCollection<Spider> SpidersList { get; set; }

        public SpidersTab()
        {
            InitializeComponent();
            GetSpiderData();
        }

        public void GetSpiderData()
        {
            try
            {
                _Connection.Open();                
                using (SqlCommand cmd = _Connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * " +
                        "FROM Spiders s, Molt m " +
                        "WHERE s.Spider_Id = 1 AND m.Spider_Id = 1";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgrdData.ItemsSource = dataTable.AsDataView();

                        SpidersList = ConvertDataTable<Spider>(dataTable);
                        SpidersTable.DataContext = SpidersList;
                    }
                }

                _Connection.Close();
            }
            catch (Exception ex)
            {
                _Connection.Close();
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
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
