using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TerrApp.Models.Translation_Config.grdMainModels;

namespace TerrApp.Models.Translation_Config
{
	[XmlRoot(ElementName = "grdMain")]
	public class grdMain
	{
		[XmlElement(ElementName = "spnlSideMenu")]
		public spnlSideMenu spnlSideMenu { get; set; }

		[XmlElement(ElementName = "grdContent")]
		public grdContent grdContent { get; set; }
	}
}
