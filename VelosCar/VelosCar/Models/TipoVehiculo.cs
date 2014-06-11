using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    [Table("TiposVehiculos")]
    public class TipoVehiculo
    {
        public int id { get; set; }

        [Required]
        public string Nombre { get; set; }

        //declaracion de la relacion entre el tipovehiculo y el vehiculo
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}