using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TerrApp.Models.Translation_Config.grdMainModels
{
	[XmlRoot(ElementName = "Spiders_Tab")]
	public class Spiders_Tab
	{
		[XmlAttribute(AttributeName = "SpiderTable")]
		public SpiderTable SpiderTable { get; set; }
	}
}
