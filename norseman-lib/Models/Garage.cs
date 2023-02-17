using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Models
{
    public class Garage
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
