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
    public class UserService : IUser
    {
        private SqlConnection _Connection = new(Globals.Connection.GetLocalConnectionString());

        public User GetLocalUserData()
        {
            User user = new();
            _Connection.Open();
            using (SqlCommand cmd = _Connection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM User_Data";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user.Id = int.Parse(reader["Id"].ToString());
                    user.Name = reader["Name"].ToString();
                    user.Language = reader["Launguage"].ToString();
                    user.Theme = reader["Theme"].ToString();
                }
                else 
                {
                    throw new Exception("No user data");
                }
            }
            return user;
        }
    }
}
