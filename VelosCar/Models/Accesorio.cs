using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    [Table ("Accesorios")]
    public class Accesorio
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Valor { get; set; }

        public virtual ICollection<Equipamiento> Equipamientos { get; set; }
    }

}