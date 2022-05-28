using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TerrApp.Models.Translation_Config
{
	[XmlRoot(ElementName = "Translation")]
	public class Translation
	{
		[XmlAttribute(AttributeName = "Translate")]
		public string Translate { get; set; }
	}
}
