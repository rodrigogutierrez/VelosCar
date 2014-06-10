using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    public class TipoVehiculo
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }

        //declaracion de la relacion entre la tarifa y el vehiculo
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}