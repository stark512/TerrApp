using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models.SpiderModels
{
    public class Molt
    {
        public int MoltId { get; set; }
        public int SpiderId { get; set; }
        public DateTime MoltDate { get; set; }

        public Molt(int moltid, int spiderid, DateTime moltdate)
        {
            this.MoltDate = moltdate;
            this.MoltId = moltid;
            this.SpiderId = spiderid;
        }
    }
}
