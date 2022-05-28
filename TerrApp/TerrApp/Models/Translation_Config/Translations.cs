using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TerrApp.Controlers;

namespace TerrApp.Models.Translation_Config
{
	[XmlRoot(ElementName = "Translations")]
	public class Translations
	{
		[XmlElement(ElementName = "XML_Globals")]
		public XMLGlobals XML_Globals { get; set; }

		[XmlElement(ElementName = "grdMain")]
		public grdMain grdMain { get; set; }
	}
}
