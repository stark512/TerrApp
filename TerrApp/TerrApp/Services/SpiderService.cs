using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrApp.Controlers;
using TerrApp.Interfaces;
using TerrApp.Models;

namespace TerrApp.Services
{
    public class SpiderService : ISpider
    {
        private SqlConnection _Connection = new(Globals.Connection.GetLocalConnectionString());

        public List<Spider> GetAllSpiders(int userid)
        {
            List<Spider> spiders = new();
            Spider spider = new();
            _Connection.Open();
            using (SqlCommand cmd = _Connection.CreateCommand())
            {
                //cmd.Parameters["@User_id"].Value = userid;
                cmd.CommandText = "SELECT * FROM Spiders WHERE User_id = " + userid;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    spider.SpiderId = int.Parse(reader["Spider_Id"].ToString());
                    spider.UserId = int.Parse(reader["User_id"].ToString());
                    spider.Genus = reader["Genus"].ToString();
                    spider.Species = reader["Species"].ToString();
                    spider.Sex = char.Parse(reader["Sex"].ToString());
                    spider.Type = reader["Type"].ToString();
                    spider.PurchaseDate = DateTime.ParseExact(reader["Purchase_Date"].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    spider.BirthDate = DateTime.ParseExact(reader["Birth_Date"].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    //spider.DeathDate = DateTime.ParseExact(reader["Death_Date"].ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    //spider.WebsideLink = reader["Webside_Link"].ToString();
                    spider.LastFeedingDate = DateTime.ParseExact(reader["Last_Feeding_Date"].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    //spider.Note = reader["Note"].ToString();
                    spider.IsActive = (bool)reader["Is_Active"];

                    spiders.Add(spider);
                }
                else
                {
                    throw new Exception("No spiders found");
                }
            }
            
            _Connection.Close();
            return spiders;
        }
    }
}   
