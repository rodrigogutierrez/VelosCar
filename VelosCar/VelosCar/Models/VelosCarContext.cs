using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VelosCar.Models
{
    public class VelosCarContext : DbContext
    {
        public DbSet<Accesorio> Accesorios { get; set; }
        public DbSet<Combustible> Combustibles { get; set; }
        public DbSet<Equipamiento> Equipamientos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Tarifa> Tarifas { get; set; }
        public DbSet<TipoVehiculo> TiposVehiculo { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}