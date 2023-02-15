using Norseman.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public VehicleMake Make { get; set; }

        public string Model { get; set; }
    }
}
