using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Models
{
    public class CarMake
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public enum Make
    {
        AUDI,
        BMW,
        CADILLAC,
        CHEVROLET,
        FORD,
        GENESIS,
        GMC,
        HONDA,
        HYUNDAI,
        JAGUAR,
        KIA,
        LUCID,
        MERCEDES,
        MINI,
        NISSAN,
        POLESTAR,
        PORSCHE,
        RAM,
        RIVIAN,
        SUBARU,
        TESLA,
        TOYOTA,
        VOLKSWAGEN,
        VOLVO,
    }
}
