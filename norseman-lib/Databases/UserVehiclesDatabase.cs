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
        /// <summary>
        /// Default Constructor
        /// </summary>
        public UserVehiclesDatabase() { }

        /// <summary>
        /// Gets the current selected car for the logged in user
        /// </summary>
        /// <returns>An object representing the user's current <see cref="Vehicle"/></returns>
        public Vehicle GetCurrentCar()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the current favorite car for the logged in user
        /// </summary>
        /// <returns>An object representing the user's favorite <see cref="Vehicle"/></returns>
        public Vehicle GetFavoriteVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
