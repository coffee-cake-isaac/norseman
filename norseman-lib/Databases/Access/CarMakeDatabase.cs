using Norseman.Lib.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Databases.Access
{
    public class CarMakeDatabase
    {
        /// <summary>
        /// Connection used to access sqlite database
        /// </summary>
        SQLiteAsyncConnection database;

        /// <summary>
        /// Default, parameterless constructor
        /// </summary>
        public CarMakeDatabase() { }

        /// <summary>
        /// Initializes the <see cref="database"/> object if it has not been already created.
        /// Otherwise, returns the instantiated object for accessing the local sqlite database
        /// </summary>
        /// <returns></returns>
        public async Task Init()
        {
            if (database is not null)
                return;

            database = new SQLiteAsyncConnection(Constants.VehicleMakeDatabasePath, Constants.Flags);
            await database.CreateTableAsync<CarMake>();
        }
        
        public async Task SeedDefaultData()
        {
            var makes = await GetCarMakesAsync();

            if (makes.Any()) return;

            foreach (var make in Enum.GetValues(typeof(Make)))
            {
                await SaveCarMakeAsync(new CarMake
                {
                    Name = make.ToString(),
                });
            }
        }

        /// <summary>
        /// Returns a list of all <see cref="CarMake"/> objects store the in local sqlite database
        /// </summary>
        /// <returns></returns>
        public async Task<List<CarMake>> GetCarMakesAsync()
        {
            await Init();
            return await database.Table<CarMake>().ToListAsync();
        }

        /// <summary>
        /// Returns a single <see cref="CarMake"/> from the local sqlite database
        /// </summary>
        /// <param name="carMake">The name of the car make to return data for</param>
        /// <returns>A <see cref="CarMake"/>object belonging to the user requested make</returns>
        public async Task<CarMake> GetCarMakeAsync(string carMake)
        {
            await Init();
            return await database.Table<CarMake>().Where(x => x.Name == carMake).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Updates an existing <see cref="CarMake"/>, if exist.
        /// Otherwise, creates a new entry in the local sqlite database.
        /// </summary>
        /// <param name="make">The name of the car make used for upsert</param>
        /// <returns>All information regarding the user requested <see cref="CarMake"/></returns>
        public async Task<int> SaveCarMakeAsync(CarMake make)
        {
            await Init();
            if (make.Id != 0)
                return await database.UpdateAsync(make);
            else
                return await database.InsertAsync(make);
        }
    }
}
