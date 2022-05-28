using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TerrApp.Models.Translation_Config.grdMainModels
{
	[XmlRoot(ElementName = "spnlSideMenu")]
	public class spnlSideMenu
	{
		[XmlElement(ElementName = "Add_Button")]
		public Translation Add_Button { get; set; }

		[XmlElement(ElementName = "AddSpider_Button")]
		public Translation AddSpider_Button { get; set; }

		[XmlElement(ElementName = "AddMolt_Button")]
		public Translation AddMolt_Button { get; set; }

		[XmlElement(ElementName = "AddCopulation_Button")]
		public Translation AddCopulation_Button { get; set; }

		[XmlElement(ElementName = "MainMenu_Button")]
		public Translation MainMenu_Button { get; set; }

		[XmlElement(ElementName = "Spiders_Button")]
		public Translation Spiders_Button { get; set; }

		[XmlElement(ElementName = "Molts_Button")]
		public Translation Molts_Button { get; set; }

		[XmlElement(ElementName = "Copulations_Button")]
		public Translation Copulations_Button { get; set; }

		[XmlElement(ElementName = "Stats_Button")]
		public Translation Stats_Button { get; set; }

		[XmlElement(ElementName = "Settings_Button")]
		public Translation Settings_Button { get; set; }

	}
}
