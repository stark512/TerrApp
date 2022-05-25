using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrApp.Interfaces;
using TerrApp.Models;
using TerrApp.Services;

namespace TerrApp.Controlers
{
    public static class Globals
    {        
        public static Connection Connection = new();
        private static IUser _IUser = new UserService();
        /// <summary>
        /// User from local DB
        /// </summary>
        public static User LocalUserData = _IUser.GetLocalUserData();

    }
}
