using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TerrApp.Models.Translation_Config.grdMainModels
{
	[XmlRoot(ElementName = "SpiderTable")]
	public class SpiderTable
	{
		[XmlAttribute(AttributeName = "Genus_Column")]
		public Translation Genus_Column { get; set; }

		[XmlAttribute(AttributeName = "Species_Column")]
		public Translation Species_Column { get; set; }

		[XmlAttribute(AttributeName = "Sex_Column")]
		public Translation Sex_Column { get; set; }

		[XmlAttribute(AttributeName = "Type_Column")]
		public Translation Type_Column { get; set; }

		[XmlAttribute(AttributeName = "PurchaseDate_Column")]
		public Translation PurchaseDate_Column { get; set; }

		[XmlAttribute(AttributeName = "BirthDate_Column")]
		public Translation BirthDate_Column { get; set; }

		[XmlAttribute(AttributeName = "DeathDate_Column")]
		public Translation DeathDate_Column { get; set; }

		[XmlAttribute(AttributeName = "LastFeedingDate_Column")]
		public Translation LastFeedingDate_Column { get; set; }

		[XmlAttribute(AttributeName = "IsActive_Column")]
		public Translation IsActive_Column { get; set; }
	}
}
