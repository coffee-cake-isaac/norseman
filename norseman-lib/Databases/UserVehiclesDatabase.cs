using Norseman.Lib.Databases.Interfaces;
using Norseman.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Databases
{
    public class UserVehiclesDatabase : IUserVehicleDatabase
    {
        public UserVehiclesDatabase() { }

        public Vehicle GetCurrentCar()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetFavoriteVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
