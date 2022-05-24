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

            List<Spider> spidersList =  _ISpider.GetAllSpiders(0);

            dgrdData.DataContext = spidersList;
        }
    }
}
