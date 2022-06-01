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
using TerrApp.Controlers;
using TerrApp.Models;
using TerrApp.Models.TranslateModels;
using TerrApp.User_Controls;
using SpidersTab = TerrApp.User_Controls.SpidersTab;

namespace TerrApp.Views
{
    public partial class MainWindow : Window
    {
        #region PropertiesForBinding
        public string addBtnContent { get; set; }
        public string addSpiderBtnContent { get; set; }
        public string addMoltBtnContent { get; set; }
        public string addCopulationBtnContent { get; set; }
        public string mainMenuBtnContent { get; set; }
        public string spidersBtnContent { get; set; }
        public string moltsBtnContent { get; set; }
        public string copulationsBtnContent { get; set; }
        public string statsBtnContent { get; set; }
        public string settingsBtnContent { get; set; }
        #endregion

        public MainWindow()
        {
            InitializeComponent();            
        }

        private void CheckChosenToggleButton(ToggleButton chosenToggleButton, UIElementCollection uiElements)
        {
            foreach (var uIElement in uiElements)
            {
                if (uIElement.GetType() != typeof(StackPanel))
                {
                    ToggleButton tglButton = (ToggleButton)uIElement;
                    if (tglButton != chosenToggleButton)
                    {
                        tglButton.IsChecked = false;
                    }
                    else
                    {
                        tglButton.IsChecked = true;
                    }
                }
                else
                {
                    CheckChosenToggleButton(chosenToggleButton, ((StackPanel)uIElement).Children);
                }
            }
        }

        private void SideMenuButton_Checked(object sender, RoutedEventArgs e)
        {
            ToggleButton sideMenuButton = (ToggleButton)sender;

            CheckChosenToggleButton(sideMenuButton, spnlSideMenu.Children);

            grdContent.Children.Clear();

            switch (sideMenuButton.Name)
            {
                case "AddSpider":
                    break;

                case "AddMolt":
                    break;

                case "AddCopulation":
                    break;

                case "MainMenu":
                    break;

                case "Spiders":
                    SpidersTab newTab = new();
                    Grid.SetColumn(newTab, 1);
                    grdContent.Children.Add(newTab);
                    break;

                case "Molts":
                    break;

                case "Copulations":
                    break;

                case "Stats":
                    break;

                case "Settings":
                    break;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Add_InnerMenu.Visibility == Visibility.Collapsed)
            {
                Add_InnerMenu.Visibility = Visibility.Visible;
            }
            else
            {
                Add_InnerMenu.Visibility = Visibility.Collapsed;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BindingData();
        }

        /// <summary>
        /// Bind side menu data
        /// </summary>
        private void BindingData()
        {
            this.DataContext = this;
            addBtnContent = Globals.Translation.grdMain.spnSideMenu.AddButton;
            addSpiderBtnContent = Globals.Translation.grdMain.spnSideMenu.AddSpiderButton;
            addMoltBtnContent = Globals.Translation.grdMain.spnSideMenu.AddMoltButton;
            addCopulationBtnContent = Globals.Translation.grdMain.spnSideMenu.AddCopulationButton;
            mainMenuBtnContent = Globals.Translation.grdMain.spnSideMenu.MainMenuButton;
            spidersBtnContent = Globals.Translation.grdMain.spnSideMenu.SpidersButton;
            moltsBtnContent = Globals.Translation.grdMain.spnSideMenu.MoltsButton;
            copulationsBtnContent = Globals.Translation.grdMain.spnSideMenu.CopulationsButton;
            statsBtnContent = Globals.Translation.grdMain.spnSideMenu.StatsButton;
            settingsBtnContent = Globals.Translation.grdMain.spnSideMenu.SettingsButton;
        }
    }
}
