using Norseman.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Databases.Interfaces
{
    public interface IUserVehicleDatabase
    {
        public Vehicle GetCurrentCar();

        public Vehicle GetFavoriteVehicle();
    }
}
