using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrApp.Models.SpiderModels;

namespace TerrApp.Models
{
    public class Spider
    {
        public int SpiderId { get; set; }
        public int UserId { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public char Sex { get; set; }
        public string Type { get; set; }
        public DateOnly? PurchaseDate { get; set; }
        public DateOnly? BirthDate { get; set; }
        public DateOnly? DeathDate { get; set; }
        public string WebsideLink { get; set; }
        public DateOnly? LastFeedingDate { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
        public List<Molt> MoltList { get; set; }
        public List<Size> SizeList { get; set; }
        public List<Terrarium> TerrariumList { get; set; }
        public List<Escape> EscapeList { get; set; }
        public List<Reproduction> ReproductionsList { get; set; }
        public List<Cocoon> CocoonList { get; set; }
        public List<Note> NotesList { get; set; }

        public Spider()
        {

        }

        public Spider(int spiderid,
                      int userid,
                      string genus,
                      string species,
                      char sex,
                      string type,
                      DateOnly purchasedate,
                      DateOnly birthdate,
                      DateOnly deathdate,
                      string websidelink,
                      DateOnly lastfeedingdate,
                      string note,
                      bool isactive,
                      List<Molt> moltlist,
                      List<Size> sizelist,
                      List<Terrarium> terrariumlist,
                      List<Escape> escapelist,
                      List<Reproduction> reproductionslist,
                      List<Cocoon> cocoonslist,
                      List<Note> noteslist)
        {
            this.SpiderId = spiderid;
            this.UserId = userid;
            this.Genus = genus;
            this.Species = species;
            this.Sex = sex;
            this.Type = type;
            this.PurchaseDate = purchasedate;
            this.BirthDate = birthdate;
            this.DeathDate = deathdate;
            this.WebsideLink = websidelink;
            this.LastFeedingDate = lastfeedingdate;
            this.Note = note;
            this.IsActive = isactive;
            this.MoltList = moltlist;
            this.SizeList = sizelist;
            this.TerrariumList = terrariumlist;
            this.EscapeList = escapelist;
            this.ReproductionsList = reproductionslist;
            this.CocoonList = cocoonslist;
            this.NotesList = noteslist;
        }
    }
}
