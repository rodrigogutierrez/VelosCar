using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    [Table("Combustible")]
    public class Combustible
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

    }
}