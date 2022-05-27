using System;
using System.Collections.Generic;
using System.Data;
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
            _Connection.Open();
            using (SqlCommand cmd = _Connection.CreateCommand())
            {
                cmd.Parameters.AddWithValue("@User_id", userid);
                cmd.CommandText = "SELECT * FROM Spiders WHERE User_id = @User_id";

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Spider spider = new();
                    spider.SpiderId = int.Parse(reader["Spider_Id"].ToString());
                    spider.UserId = int.Parse(reader["User_id"].ToString());
                    spider.Genus = reader["Genus"].ToString();
                    spider.Species = reader["Species"].ToString();
                    if (!String.IsNullOrEmpty(reader["Sex"].ToString()))
                    {
                        spider.Sex = char.Parse(reader["Sex"].ToString());
                    }
                    spider.Type = reader["Type"].ToString();
                    if (!String.IsNullOrEmpty(reader["Purchase_Date"].ToString()))
                    {
                        spider.PurchaseDate = DateTime.ParseExact(reader["Purchase_Date"].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (!String.IsNullOrEmpty(reader["Birth_Date"].ToString()))
                    {
                        spider.BirthDate = DateTime.ParseExact(reader["Birth_Date"].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    }                    
                    if (!String.IsNullOrEmpty(reader["Death_Date"].ToString()))
                    {
                        spider.DeathDate = DateTime.ParseExact(reader["Death_Date"].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    spider.WebsideLink = reader["Webside_Link"].ToString();
                    if (!String.IsNullOrEmpty(reader["Last_Feeding_Date"].ToString()))
                    {
                        spider.LastFeedingDate = DateTime.ParseExact(reader["Last_Feeding_Date"].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    }                    
                    spider.Note = reader["Note"].ToString();
                    spider.IsActive = (bool)reader["Is_Active"];                   

                    spiders.Add(spider);
                }

                if (spiders.Count <= 0)
                {
                    throw new Exception("No spiders found");
                }
            }
            
            _Connection.Close();
            return spiders;
        }

        public void SaveSpiderInDb(Spider spider, int userid)
        {
            _Connection.Open();

            using (SqlCommand cmd = _Connection.CreateCommand())
            {
                cmd.Parameters.AddWithValue("@User_id", spider.UserId);
                cmd.Parameters.AddWithValue("@Genus", spider.Genus);
                cmd.Parameters.AddWithValue("@Species", spider.Species);
                cmd.Parameters.AddWithValue("@Sex", spider.Sex);
                cmd.Parameters.AddWithValue("@Type", spider.Type);
                cmd.Parameters.AddWithValue("@Purchase_Date", spider.PurchaseDate);
                cmd.Parameters.AddWithValue("@Birth_Date", spider.BirthDate);
                cmd.Parameters.AddWithValue("@Death_Date", spider.DeathDate);
                cmd.Parameters.AddWithValue("@Webside_Link", spider.WebsideLink);
                cmd.Parameters.AddWithValue("@Last_Feeding_Date", spider.LastFeedingDate);
                cmd.Parameters.AddWithValue("@Note", spider.Note);
                cmd.Parameters.AddWithValue("@Is_Active", spider.IsActive);

                cmd.CommandText = "INSERT INTO Spiders(User_id, Genus, Species, Sex, Type, Purchase_Date, Birth_Date, Death_Date, Webside_Link, Last_Feeding_Date, Note, Is_Active)" +
                "VALUES(@User_id, @Genus, @Species, @Sex, @Type, @Purchase_Date, @Birth_Date, @Death_Date, @Webside_Link, @Last_Feeding_Date, @Note, @Is_Active)";

                cmd.ExecuteNonQuery();

                _Connection.Close();
            }
        }

        public void DeleteSpider(int spiderid, int userid)
        {
            _Connection.Open();

            using (SqlCommand cmd = _Connection.CreateCommand())
            {
                cmd.Parameters.AddWithValue("@Spider_Id", spiderid);
                cmd.Parameters.AddWithValue("@User_id", userid);

                cmd.CommandText = "DELETE FROM Spiders WHERE Spider_Id = @Spider_Id AND User_id = @User_id";
                cmd.ExecuteNonQuery();

                _Connection.Close();
            }
        }
    }
}   
