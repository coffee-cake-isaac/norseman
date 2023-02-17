﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace norseman_lib.Databases
{
    public static class Constants
    {
        public const string VehicleMakeDatabaseFileName = "vehiclemodels.db3";
        public const string VehicleModelDatabaseFileName = "vehiclemake.db3";

        public const SQLite.SQLiteOpenFlags Flags =
        // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string VehicleMakeDatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, VehicleMakeDatabaseFileName);

        public static string VehicleModelDatabasePath =>
           Path.Combine(FileSystem.AppDataDirectory, VehicleModelDatabaseFileName);
    }
}
