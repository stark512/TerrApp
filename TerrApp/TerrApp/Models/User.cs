using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string Theme { get; set; }
        public List<Spider> SpidersList { get; set; }

        public User(int id, string name, string language, string theme, List<Spider> spiderlist)
        {
            this.Id = id;
            this.Name = name;
            this.Language = language;
            this.Theme = theme;
            this.SpidersList = spiderlist;
        }

        public User()
        {

        }
    }
}
