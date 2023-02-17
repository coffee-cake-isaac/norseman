using Norseman.Lib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Models
{
    public class Vehicle
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The make of the current vehicle
        /// </summary>
        public VehicleMake Make { get; set; }

        /// <summary>
        /// The model of the current selected vehicle
        /// </summary>
        public string Model { get; set; }
    }
}
