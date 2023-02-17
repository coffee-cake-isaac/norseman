using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Databases
{
    public static class Constants
    {
        /// <summary>
        /// The name of the database for the vehicle models
        /// </summary>
        public const string VehicleMakeDatabaseFileName = "vehiclemodels.db3";

        /// <summary>
        /// The name of the databsae for the vehicle makes
        /// </summary>
        public const string VehicleModelDatabaseFileName = "vehiclemake.db3";

        /// <summary>
        /// Flags used to grant permissions to the SQLite database
        /// </summary>
        public const SQLite.SQLiteOpenFlags Flags =
        // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        /// <summary>
        /// The path the vehicle make database will be located
        /// </summary>
        public static string VehicleMakeDatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, VehicleMakeDatabaseFileName);

        /// <summary>
        /// The path the vehicle model database will be located
        /// </summary>
        public static string VehicleModelDatabasePath =>
           Path.Combine(FileSystem.AppDataDirectory, VehicleModelDatabaseFileName);
    }
}
