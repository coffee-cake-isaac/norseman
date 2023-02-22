using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Models
{
    public class CarModel
    {
        /// <summary>
        /// Id belonging to the car model
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// The manufacturer, or <see cref="CarMake"/> of the model
        /// </summary>
        [Required]
        [ForeignKey("CarMake")]
        public CarMake CarMake { get; set; }

        /// <summary>
        /// The name of the model assigned by the <see cref="CarMake"/>
        /// </summary>
        [Required]
        public string Model { get; set; }
    }
}
