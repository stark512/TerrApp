using System;
using System.Collections.Generic;
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
using TerrApp.User_Controls;

namespace TerrApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

#if DEBUG
            DebugTest();
#endif
        }

        public void DebugTest()
        {
            Button button = new();
            button.Height = 50;
            button.Width = 70;
            button.Content = "Test";
            button.Click += Button_Click;
            grdMain.Children.Add(button);            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spContent.Children.Clear();
            SpidersTab spiderTab = new();
            spContent.Children.Add(spiderTab);
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
