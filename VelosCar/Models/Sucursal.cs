using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    [Table("Sucursales")]
    public class Sucursal
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Comuna { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        public DateTime HoraInicioAtencion { get; set; }

        [Required]
        public DateTime HoraTerminaAtencion { get; set; }

        //declaracion de la relacion entre sucursal y vehiculo
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}