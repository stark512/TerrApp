using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models.SpiderModels
{
    public class Reproduction
    {
        public int ReproductionId { get; set; }
        public int SpiderFemaleId { get; set; }
        public DateTime CopulationDate { get; set; }
        public bool IsSuccessful { get; set; }
        public bool IsSpiderMaleEaten { get; set; }
        public bool IsCoccon { get; set; }
        public string Note { get; set; }

        public Reproduction(int reproductionid, int spiderfemalied, DateTime copulationdate, bool issuccessful, bool isspidermaleeaten, bool iscoccon,
            string note)
        {
            this.ReproductionId = reproductionid;
            this.SpiderFemaleId = spiderfemalied;
            this.CopulationDate = copulationdate;
            this.IsSuccessful = issuccessful;
            this.IsSpiderMaleEaten = isspidermaleeaten;
            this.IsCoccon = iscoccon;
            this.Note = note;
        }
    }
}
