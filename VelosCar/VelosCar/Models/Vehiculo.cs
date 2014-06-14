using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(6, MinimumLength=6)]
        public string Patente { get; set; }

        [Required]
        public string Marca { get; set; }
        
        [Required]
        public string Modelo { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int Anio { get; set; }

        [Required]
        public int CantidadPuertas { get; set; }

        [Required]
        public int CantidadPasajeros { get; set; }

        [Required]
        public int Cilindrada { get; set; }
        
        [Required]
        public bool FrenosAbs { get; set; }

        [Required]
        public bool AirbagLaterales { get; set; }

        [Required]
        public bool AirbagFrontales { get; set; }

        [Required]
        public string RutaImagen { get; set; }
        
        //declaracion de la relacion entre vehiculo y marca
        //public int MarcaId { get; set; }
        //public virtual Marca Marca { get; set; }

        //declaracion de la relacion entre vehiculo y tipovehiculo
        public int TipoVehiculoId { get; set; }
        public virtual TipoVehiculo TipoVehiculo { get; set; }

        //declaracion de la relacion entre vehiculo y combustible
        public int CombustibleId { get; set; }
        public virtual Combustible Combustible { get; set; }

        //declaracion de la relacion entre vehiculo y equipamiento
        public virtual ICollection<Equipamiento> Equipamiento { get; set; }

        //declaracion de la relacion entre vehiculo y tarifa
        public int TarifaId { get; set; }
        public virtual Tarifa Tarifa { get; set; }

        //declaracion de la relacion entre vahiculo y reserva
        public virtual ICollection<Reserva> Reserva { get; set; }
    }
}