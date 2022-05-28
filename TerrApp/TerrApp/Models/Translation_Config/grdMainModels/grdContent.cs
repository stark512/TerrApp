using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TerrApp.Models.Translation_Config.grdMainModels
{
	[XmlRoot(ElementName = "grdContent")]
	public class grdContent
	{
		//[XmlElement(ElementName = "Add_Tab")]
		//public Add_Tab Add_Tab { get; set; }

		//[XmlElement(ElementName = "AddSpider_Tab")]
		//public AddSpider_Tab AddSpider_Tab { get; set; }

		//[XmlElement(ElementName = "AddMolt_Tab")]
		//public AddMolt_Tab AddMolt_Tab { get; set; }

		//[XmlElement(ElementName = "AddCopulation_Tab")]
		//public AddCopulation_Tab AddCopulation_Tab { get; set; }

		//[XmlElement(ElementName = "MainMenu_Tab")]
		//public MainMenu_Tab MainMenu_Tab { get; set; }

		[XmlElement(ElementName = "Spiders_Tab")]
		public Spiders_Tab Spiders_Tab { get; set; }

		//[XmlElement(ElementName = "Molts_Tab")]
		//public Molts_Tab Molts_Tab { get; set; }

		//[XmlElement(ElementName = "Copulations_Tab")]
		//public Copulations_Tab Copulations_Tab { get; set; }

		//[XmlElement(ElementName = "Stats_Tab")]
		//public Stats_Tab Stats_Tab { get; set; }

		//[XmlElement(ElementName = "Settings_Tab")]
		//public Settings_Tab Settings_Tab { get; set; }
	}
}
