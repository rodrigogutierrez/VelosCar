using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string RutPasaporte { get; set; }

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string ApellidoPaterno { get; set; }

        [Required]
        public string ApellidoMaterno { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Pais { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Contrasena { get; set; }

        [Required]
        public string Estado { get; set; }

        //declaracion de la relacion entre usuario y reserva
        public virtual ICollection<Reserva> Reserva { get; set; }

    }
}