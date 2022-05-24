using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Controlers
{
    public class Connection
    {
        private string _localConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Environment.CurrentDirectory + @"\UserData.mdf;Integrated Security = True";

        public string GetLocalConnectionString()
        {
            return _localConnectionString;
        }
    }
}
