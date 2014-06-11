using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    [Table("Equipamiento")]
    public class Equipamiento
    {
        public int Id { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public int IdVehiculo { get; set; }

        [Required]
        public int IdAccesorio { get; set; }
    }
}