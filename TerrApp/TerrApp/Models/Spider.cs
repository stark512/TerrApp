using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models
{
    public class Spider
    {
        public string Genus { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }

        public Spider(string genus, string species, string sex, string type, bool isActive)
        {
            Genus = genus;
            Species = species;
            Sex = sex;
            Type = type;
            IsActive = isActive;
        }
    }
}
