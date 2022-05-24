using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models.SpiderModels
{
    public class Size
    {
        public int SizeId { get; set; }
        public int SpiderId { get; set; }
        public int SpiderSize { get; set; }
        public DateTime SizeDate { get; set; }
        public string Note { get; set; }

        public Size(int sizeid, int spiderid, int spidersize, DateTime sizedate, string note)
        {
            this.SizeId = sizeid;
            this.SpiderId = spiderid;
            this.SpiderSize = spidersize;
            this.SizeDate = sizedate;
            this.Note = note;
        }
    }
}
