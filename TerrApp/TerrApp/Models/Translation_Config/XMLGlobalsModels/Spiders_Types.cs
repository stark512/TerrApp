using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TerrApp.Models.Translation_Config.XMLGlobalsModels
{
	[XmlRoot(ElementName = "Spiders_Types")]
	public class Spiders_Types
	{
		[XmlElement(ElementName = "Arboreal")]
		public Translation Arboreal { get; set; }

		[XmlElement(ElementName = "Terrestrial")]
		public Translation Terrestrial { get; set; }

		[XmlElement(ElementName = "Subterranean")]
		public Translation Subterranean { get; set; }

		[XmlElement(ElementName = "Other")]
		public Translation Other { get; set; }
	}
}
