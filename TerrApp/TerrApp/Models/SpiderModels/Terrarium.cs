using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models.SpiderModels
{
    public  class Terrarium
    {
        public int TerrariumId { get; set; }
        public int SpiderId { get; set; }
        public DateTime Date { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Diameter { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }

        public Terrarium(int terrariumid, int spiderid, DateTime date, int height, int width, int depth, int diameter, string type, string note)
        {
            this.TerrariumId = terrariumid;
            this.SpiderId = spiderid;
            this.Date = date;
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
            this.Diameter = diameter;
            this.Type = type;
            this.Note = note;
        }
    }
}
