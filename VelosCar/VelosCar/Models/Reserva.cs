using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    public class Reserva
    {
        [Key]
        [Column(Order = 1)]
        public int UsuarioId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int VehiculoId { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        public DateTime FechaRetiro { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public DateTime FechaDevolucionReal { get; set; }

        //declaracion de la relacion con usuario
        public virtual Usuario Usuario { get; set; }

        //declaracion de la relacion con vehiculo
        public virtual Vehiculo Vehiculo { get; set; }
    }
}