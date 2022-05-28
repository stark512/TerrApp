using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TerrApp.Models.Translation_Config.XMLGlobalsModels;

namespace TerrApp.Models.Translation_Config
{
	[XmlRoot(ElementName = "XML_Globals")]
	public class XMLGlobals
	{
		[XmlElement(ElementName = "Spiders_Types")]
		public Spiders_Types Spiders_Types { get; set; }

		[XmlElement(ElementName = "Spiders_Gender")]
		public Spiders_Gender Spiders_Gender { get; set; }
	}
}
