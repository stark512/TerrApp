using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TerrApp.Models.Translation_Config.XMLGlobalsModels
{
	[XmlRoot(ElementName = "Spiders_Gender")]
	public class Spiders_Gender
	{
		[XmlElement(ElementName = "Female")]
		public Translation Female { get; set; }

		[XmlElement(ElementName = "Male")]
		public Translation Male { get; set; }
	}
}
