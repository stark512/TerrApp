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

namespace TerrApp.User_Controls
{
    public partial class SpidersTab : UserControl
    {
        private SqlConnection _Connection = new(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Environment.CurrentDirectory + @"\UserData.mdf;Integrated Security = True");

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
    }
}
