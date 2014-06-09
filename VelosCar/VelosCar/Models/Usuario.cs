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
        public string RutPasaporte { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Email { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }

        //declaracion de la relacion entre usuario y reserva
        public virtual ICollection<Reserva> Reserva { get; set; }

    }
}