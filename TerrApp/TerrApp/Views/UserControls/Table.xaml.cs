using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using TerrApp.Models;

namespace TerrApp.Views.UserControls
{
    public partial class Table : UserControl
    {
        public List<Spider> SourceData { get; set; }

        public Table()
        {
            InitializeComponent();

            Spider tempSpider = new();
            int index = 0;
            foreach (PropertyInfo property in tempSpider.GetType().GetProperties())
            {
                TableGrid.ColumnDefinitions.Add(new());
                TextBlock textBlock = new TextBlock();
                textBlock.Text = property.Name;
                Grid.SetColumn(textBlock, index);
                Grid.SetRow(textBlock, 0);
                this.TableGrid.Children.Add(textBlock);

                index++;
            }
        }
    }
}
