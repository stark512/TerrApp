using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrApp.Models;

namespace TerrApp.Interfaces
{
    public interface IUser
    {
        public User GetLocalUserData();
    }
}
