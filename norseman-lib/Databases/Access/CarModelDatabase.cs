using Norseman.Lib.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Databases.Access
{
    public class CarModelDatabase
    {
        /// <summary>
        /// Connection used to access sqlite database
        /// </summary>
        SQLiteAsyncConnection database;

        /// <summary>
        /// Default, parameterless constructor
        /// </summary>
        public CarModelDatabase() { }

        /// <summary>
        /// Initializes the <see cref="database"/> object if it has not been already created.
        /// Otherwise, returns the instantiated object for accessing the local sqlite database
        /// </summary>
        /// <returns></returns>
        async Task Init()
        {
            if (database is not null)
                return;

            database = new SQLiteAsyncConnection(Constants.VehicleMakeDatabasePath, Constants.Flags);
            var result = await database.CreateTableAsync<CarModel>();
        }

        /// <summary>
        /// Returns a list of all <see cref="CarModel"/> objects store the in local sqlite database
        /// </summary>
        /// <returns></returns>
        public async Task<List<CarModel>> GetCarMakesAsync()
        {
            await Init();
            return await database.Table<CarModel>().ToListAsync();
        }

        /// <summary>
        /// Returns a single <see cref="CarModel"/> from the local sqlite database
        /// </summary>
        /// <param name="carMake">The name of the car make to return data for</param>
        /// <returns>A <see cref="CarModel"/>object belonging to the user requested make</returns>
        public async Task<CarModel> GetCarMakeAsync(string carModel)
        {
            await Init();
            return await database.Table<CarModel>().Where(x => x.Model == carModel).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Updates an existing <see cref="CarMake"/>, if exist.
        /// Otherwise, creates a new entry in the local sqlite database.
        /// </summary>
        /// <param name="make">The name of the car make used for upsert</param>
        /// <returns>All information regarding the user requested <see cref="CarMake"/></returns>
        public async Task<int> SaveCarMakeAsync(CarModel make)
        {
            await Init();
            if (make.Id != 0)
                return await database.UpdateAsync(make);
            else
                return await database.InsertAsync(make);
        }
    }
}
