using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    [Table("Tarifas")]
    public class Tarifa
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Valor { get; set; }

        //declaracion de la relacion entre la tarifa y el vehiculo
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}