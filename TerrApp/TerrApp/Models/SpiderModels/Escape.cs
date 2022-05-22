using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models.SpiderModels
{
    public class Escape
    {
        public int EscapeId { get; set; }
        public int SpiderId { get; set; }
        public DateTime DateOfDisapperance { get; set; }
        public DateTime DateOfFinding { get; set; }
        public string Note { get; set; }

        public Escape(int escapeid, int spiderid, DateTime dateofdisapperance, DateTime dateoffinding, string note)
        {
            this.EscapeId = escapeid;
            this.SpiderId = spiderid;
            this.DateOfDisapperance = dateofdisapperance;
            this.DateOfFinding = dateoffinding;
            this.Note = note;
        }
    }
}
