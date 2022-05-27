using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TerrApp.Models;
using TerrApp.User_Controls;

namespace TerrApp.Views
{
    public partial class MainWindow : Window
    {
        //public ObservableCollection<Spider> SpidersList { get; set; }
        public string TempText { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //SpidersTable.DataContext = SpidersList;
        #if DEBUG
            DebugTest();
        #endif
        }

        public void DebugTest()
        {
            
        }

        private void OpenSpidersTab(object sender, RoutedEventArgs e)
        {
            SpidersTab spidersTab = new();
            Grid.SetColumn(spidersTab, 1);
            grdMain.Children.Add(spidersTab);
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (ToggleButton tglButton in SideMenu.Children)
            {
                if (tglButton != (ToggleButton)sender)
                {
                    tglButton.IsChecked = false;
                }
                else
                {
                    tglButton.IsChecked = true;
                }
            }
        }
    }
}
