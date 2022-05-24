using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models.SpiderModels
{
    public class Note
    {
        public int NoteId { get; set; }
        public int SpiderId { get; set; }
        public string note { get; set; }
        public DateTime NoteAddingDate { get; set; }

        public Note(int noteid, int spiderid, string note, DateTime noteaddingdate)
        {
            NoteId = noteid;
            SpiderId = spiderid;
            this.note = note;
            NoteAddingDate = noteaddingdate;
        }
    }
}
