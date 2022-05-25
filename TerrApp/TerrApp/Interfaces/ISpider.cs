using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrApp.Models;

namespace TerrApp.Interfaces
{
    public interface ISpider
    {
        public List<Spider> GetAllSpiders(int userid);
        public void SaveSpiderInDb(Spider spider, int userid);
        public void DeleteSpider(int spiderid, int userid);
    }
}
