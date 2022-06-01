using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Controlers
{
    public class Connection
    {
        //private string _localConnectionString = @"Data Source = " + Environment.CurrentDirectory + "/Database/TerrAppDatabase.db" + "; Synchronous=Off;Compress=True;UTF8Encoding=True;Version=3";
        private string _localConnectionString = @"Data Source = " + Environment.CurrentDirectory + "/Database/TerrAppDatabase.db";
        //private string _localConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dawid Kaczmarek\source\repos\TerrApp\TerrApp\TerrApp\Database\UserData.mdf;Integrated Security = True";

        public string GetLocalConnectionString()
        {
            return _localConnectionString;
        }
    }
}
