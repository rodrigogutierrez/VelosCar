namespace VelosCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accesorios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Valor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equipamiento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Estado = c.String(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                        AccesorioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accesorios", t => t.AccesorioId, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculos", t => t.VehiculoId, cascadeDelete: true)
                .Index(t => t.AccesorioId)
                .Index(t => t.VehiculoId);
            
            CreateTable(
                "dbo.Combustible",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehiculos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Patente = c.String(nullable: false, maxLength: 6),
                        Modelo = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        Anio = c.Int(nullable: false),
                        CantidadPuertas = c.Int(nullable: false),
                        CantidadPasajeros = c.Int(nullable: false),
                        Cilindrada = c.Int(nullable: false),
                        FrenosAbs = c.Boolean(nullable: false),
                        AirbagLaterales = c.Boolean(nullable: false),
                        AirbagFrontales = c.Boolean(nullable: false),
                        RutaImagen = c.String(nullable: false),
                        MarcaId = c.Int(nullable: false),
                        TipoVehiculoId = c.Int(nullable: false),
                        CombustibleId = c.Int(nullable: false),
                        TarifaId = c.Int(nullable: false),
                        Sucursal_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: true)
                .ForeignKey("dbo.TiposVehiculos", t => t.TipoVehiculoId, cascadeDelete: true)
                .ForeignKey("dbo.Combustible", t => t.CombustibleId, cascadeDelete: true)
                .ForeignKey("dbo.Tarifas", t => t.TarifaId, cascadeDelete: true)
                .ForeignKey("dbo.Sucursales", t => t.Sucursal_Id)
                .Index(t => t.MarcaId)
                .Index(t => t.TipoVehiculoId)
                .Index(t => t.CombustibleId)
                .Index(t => t.TarifaId)
                .Index(t => t.Sucursal_Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TiposVehiculos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Tarifas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Valor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                        Estado = c.String(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaRetiro = c.DateTime(nullable: false),
                        FechaDevolucion = c.DateTime(nullable: false),
                        FechaDevolucionReal = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.UsuarioId, t.VehiculoId })
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculos", t => t.VehiculoId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.VehiculoId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RutPasaporte = c.String(nullable: false),
                        Nombres = c.String(nullable: false),
                        ApellidoPaterno = c.String(nullable: false),
                        ApellidoMaterno = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Pais = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        Contrasena = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sucursales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Comuna = c.String(nullable: false),
                        Region = c.String(nullable: false),
                        HoraInicioAtencion = c.DateTime(nullable: false),
                        HoraTerminaAtencion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Reservas", new[] { "VehiculoId" });
            DropIndex("dbo.Reservas", new[] { "UsuarioId" });
            DropIndex("dbo.Vehiculos", new[] { "Sucursal_Id" });
            DropIndex("dbo.Vehiculos", new[] { "TarifaId" });
            DropIndex("dbo.Vehiculos", new[] { "CombustibleId" });
            DropIndex("dbo.Vehiculos", new[] { "TipoVehiculoId" });
            DropIndex("dbo.Vehiculos", new[] { "MarcaId" });
            DropIndex("dbo.Equipamiento", new[] { "VehiculoId" });
            DropIndex("dbo.Equipamiento", new[] { "AccesorioId" });
            DropForeignKey("dbo.Reservas", "VehiculoId", "dbo.Vehiculos");
            DropForeignKey("dbo.Reservas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Vehiculos", "Sucursal_Id", "dbo.Sucursales");
            DropForeignKey("dbo.Vehiculos", "TarifaId", "dbo.Tarifas");
            DropForeignKey("dbo.Vehiculos", "CombustibleId", "dbo.Combustible");
            DropForeignKey("dbo.Vehiculos", "TipoVehiculoId", "dbo.TiposVehiculos");
            DropForeignKey("dbo.Vehiculos", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.Equipamiento", "VehiculoId", "dbo.Vehiculos");
            DropForeignKey("dbo.Equipamiento", "AccesorioId", "dbo.Accesorios");
            DropTable("dbo.Sucursales");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Reservas");
            DropTable("dbo.Tarifas");
            DropTable("dbo.TiposVehiculos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Vehiculos");
            DropTable("dbo.Combustible");
            DropTable("dbo.Equipamiento");
            DropTable("dbo.Accesorios");
        }
    }
}
