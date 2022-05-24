using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models.SpiderModels
{
    public  class Cocoon
    {
        public int CocoonId { get; set; }
        public DateTime FoldingTheCocoonDate { get; set; }
        public DateTime CocoonPickingDate { get; set; }
        public DateTime CocoonOpeningDate { get; set; }
        public long SpidersCount { get; set; }
        public string EmbryonicStage { get; set; }
        public int MinIncubationTemperature { get; set; }
        public int MaxIncubationTemperature { get; set; }
        public int MinIncubationHumidity { get; set; }
        public int MaxIncubationHumidity { get; set; }
        public DateTime EndOfIncubationDate { get; set; }
        public DateTime Nymph_1_Date { get; set; }
        public DateTime Nymph_2_Date { get; set; }
        public DateTime FirstMoltDate { get; set; }

        public Cocoon(int cocoonid, DateTime foldingthecocoondate, DateTime cocoonpickingdate, DateTime cocoonopeningdate, long spiderscount, 
            string embryonicstage, int maxincubationtemperature, int minincubationtemperature, int minincubationhumidity, int maxincubationhumidity,
            DateTime endofincubationdate, DateTime nymph_1_date, DateTime nymph_2_date, DateTime firstmoltdate)
        {
            this.CocoonId = cocoonid;
            this.FoldingTheCocoonDate = foldingthecocoondate;
            this.CocoonPickingDate = cocoonpickingdate;
            this.CocoonOpeningDate = cocoonopeningdate;
            this.SpidersCount = spiderscount;
            this.EmbryonicStage = embryonicstage;
            this.MinIncubationTemperature = minincubationtemperature;
            this.MaxIncubationTemperature = maxincubationtemperature;
            this.MinIncubationHumidity = minincubationhumidity;
            this.MaxIncubationHumidity = maxincubationhumidity;
            this.EndOfIncubationDate = endofincubationdate;
            this.Nymph_1_Date = nymph_1_date;
            this.Nymph_2_Date = nymph_2_date;
            this.FirstMoltDate = firstmoltdate;
        }
    }
}
