using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VelosCar
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "raiz",
                url: "",
                defaults: new { controller = "Home", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //rutas del vehiculo

            //listar vehiculos
            routes.MapRoute(
                name: "vehiculos",
                url: "vehiculos",
                defaults: new { controller = "Vehiculo", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //registrar vehiculos
            routes.MapRoute(
                name: "registrar_vehiculos",
                url: "vehiculos/registrar",
                defaults: new { controller = "Vehiculo", action = "Registrar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //Crear vehiculos
            routes.MapRoute(
                name: "crear_vehiculos",
                url: "vehiculos/crear",
                defaults: new { controller = "Vehiculo", action = "Crear" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //editar vehiculos
            routes.MapRoute(
                name: "editar_vehiculo",
                url: "vehiculos/{id}/editar",
                defaults: new { controller = "Vehiculo", action = "Editar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //actualizar vehiculos
            routes.MapRoute(
                name: "actualizar_vehiculo",
                url: "vehiculos/{id}",
                defaults: new { controller = "Vehiculo", action = "Actualizar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //ver vehiculos
            routes.MapRoute(
                name: "ver_vehiculo",
                url: "vehiculos/{id}",
                defaults: new { controller = "Vehiculo", action = "Ver" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );


            //rutas del tipo de vehiculo
            //listar vehiculos
            routes.MapRoute(
                name: "tipos_vehiculo",
                url: "tipos_vehiculo",
                defaults: new { controller = "TipoVehiculo", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //registrar tipo vehiculo
            routes.MapRoute(
                name: "registrar_tipo_vehiculo",
                url: "tipos_vehiculo/registrar",
                defaults: new { controller = "TipoVehiculo", action = "Registrar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //Crear tipo vehiculo
            routes.MapRoute(
                name: "crear_tipo_vehiculo",
                url: "tipos_vehiculo/crear",
                defaults: new { controller = "TipoVehiculo", action = "Crear" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //editar del tipo de vehiculo
            routes.MapRoute(
                name: "editar_tipo_vehiculo",
                url: "tipos_vehiculo/{id}/editar",
                defaults: new { controller = "TipoVehiculo", action = "Editar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //rutas del tipo de vehiculo
            routes.MapRoute(
                name: "actualizar_tipo_vehiculo",
                url: "tipos_vehiculo/{id}",
                defaults: new { controller = "TipoVehiculo", action = "Actualizar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //rutas del tipo de vehiculo
            routes.MapRoute(
                name: "ver_tipo_vehiculo",
                url: "tipos_vehiculo/{id}",
                defaults: new { controller = "TipoVehiculo", action = "Ver" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );
            
            //rutas del combustible
            //listar combustibles
            routes.MapRoute(
                name: "combustibles",
                url: "combustibles",
                defaults: new { controller = "Combustible", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //registrar combustibles
            routes.MapRoute(
                name: "registrar_combustibles",
                url: "combustibles/registrar",
                defaults: new { controller = "Combustible", action = "Registrar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //Crear combustibles
            routes.MapRoute(
                name: "crear_combustibles",
                url: "combustibles/crear",
                defaults: new { controller = "Combustible", action = "Crear" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //editar combustibles
            routes.MapRoute(
                name: "editar_combustibles",
                url: "combustibles/{id}/editar",
                defaults: new { controller = "Combustible", action = "Crear" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //actualizar combustibles
            routes.MapRoute(
                name: "actualizar_combustibles",
                url: "combustibles/{id}",
                defaults: new { controller = "Combustible", action = "Actualizar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //ver combustibles
            routes.MapRoute(
                name: "ver_combustibles",
                url: "combustibles/{id}",
                defaults: new { controller = "Combustible", action = "Ver" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //rutas de los accesorios
            //Listar accesorios
            routes.MapRoute(
                name: "accesorios",
                url: "accesorios",
                defaults: new { controller = "Accesorio", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //registrar accesorios
            routes.MapRoute(
                name: "registrar_accesorio",
                url: "accesorios/registrar",
                defaults: new { controller = "Accesorio", action = "Registrar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //crear accesorios
            routes.MapRoute(
                name: "crear_accesorio",
                url: "accesorios/crear",
                defaults: new { controller = "Accesorio", action = "Crear" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //editar accesorios
            routes.MapRoute(
                name: "editar_accesorio",
                url: "accesorios/{id}/editar",
                defaults: new { controller = "Accesorio", action = "Editar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //actualizar accesorios
            routes.MapRoute(
                name: "actualizar_accesorio",
                url: "accesorios/{id}",
                defaults: new { controller = "Accesorio", action = "Actualizar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //ver accesorios
            routes.MapRoute(
                name: "ver_accesorio",
                url: "accesorios/{id}",
                defaults: new { controller = "Accesorio", action = "Ver" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //rutas de la marca de vehiculo
            
            //Listar marca
            routes.MapRoute(
                name: "marcas",
                url: "marcas",
                defaults: new { controller = "Marca", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //registrar marca
            routes.MapRoute(
                name: "registrar_marca",
                url: "marcas/registrar",
                defaults: new { controller = "Marca", action = "Registrar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //crear marca
            routes.MapRoute(
                name: "crear_marca",
                url: "marcas/crear",
                defaults: new { controller = "Marca", action = "Registrar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //editar marca
            routes.MapRoute(
                name: "editar_marca",
                url: "marcas/{id}/editar",
                defaults: new { controller = "Marca", action = "Editar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //actualizar marca
            routes.MapRoute(
                name: "actualizar_marca",
                url: "marcas/{id}",
                defaults: new { controller = "Marca", action = "Actualizar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //ver marca
            routes.MapRoute(
                name: "ver_marca",
                url: "marcas/{id}",
                defaults: new { controller = "Marca", action = "Ver" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //rutas del equipamiento
            
            //rutas del usuarios
            //listar usuarios
            routes.MapRoute(
                name: "usuarios",
                url: "usuarios",
                defaults: new { controller = "Usuario", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //registrar usuarios
            routes.MapRoute(
                name: "registrar_usuario",
                url: "usuarios/registrar",
                defaults: new { controller = "Usuario", action = "Registrar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //crear usuarios
            routes.MapRoute(
                name: "crear_usuario",
                url: "usuarios/crear",
                defaults: new { controller = "Usuario", action = "Crear" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //editar usuarios
            routes.MapRoute(
                name: "editar_usuario",
                url: "usuarios/{id}/editar",
                defaults: new { controller = "Usuario", action = "Editar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //actualizar usuarios
            routes.MapRoute(
                name: "actualizae_usuario",
                url: "usuarios/{id}",
                defaults: new { controller = "Usuario", action = "Actualizar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //ver usuarios
            routes.MapRoute(
                name: "ver_usuario",
                url: "usuarios/{id}",
                defaults: new { controller = "Usuario", action = "Ver" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //rutas de la reserva
            //listar reservas
            routes.MapRoute(
                name: "reservas",
                url: "reservas",
                defaults: new { controller = "Usuario", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //registrar reservas
            routes.MapRoute(
                name: "registrar_reserva",
                url: "reservas/registrar",
                defaults: new { controller = "Usuario", action = "Registrar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //crear reservas
            routes.MapRoute(
                name: "crear_reserva",
                url: "reservas/crear",
                defaults: new { controller = "Usuario", action = "Crear" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //editar reservas
            routes.MapRoute(
                name: "editar_reserva",
                url: "reservas/{id}/editar",
                defaults: new { controller = "Usuario", action = "Editar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //actualizar reservas
            routes.MapRoute(
                name: "actualizar_reserva",
                url: "reservas/{id}",
                defaults: new { controller = "Usuario", action = "Actualizar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //registrar reservas
            routes.MapRoute(
                name: "ver_reserva",
                url: "reservas/{ver}",
                defaults: new { controller = "Usuario", action = "Ver" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //rutas de las tarifas
            //listar tarifas
            routes.MapRoute(
                name: "tarifas",
                url: "tarifas",
                defaults: new { controller = "Tarifa", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //registrar tarifas
            routes.MapRoute(
                name: "registrar_tarifa",
                url: "tarifas/registrar",
                defaults: new { controller = "Tarifa", action = "Registrar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //crear tarifas
            routes.MapRoute(
                name: "crear_tarifa",
                url: "tarifas/crear",
                defaults: new { controller = "Tarifa", action = "Crear" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //crear tarifas
            routes.MapRoute(
                name: "editar_tarifa",
                url: "tarifas/{id}/editar",
                defaults: new { controller = "Tarifa", action = "Editar" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //actualizar tarifas
            routes.MapRoute(
                name: "actualizar_tarifa",
                url: "tarifas/{id}",
                defaults: new { controller = "Tarifa", action = "Crear" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //ver tarifas
            routes.MapRoute(
                name: "ver_tarifa",
                url: "tarifas/{id}",
                defaults: new { controller = "Tarifa", action = "Ver" },
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "POST" }) }
            );

            //rutas de las sucursales
            //rutas de los informes estadisticos
            //rutas de los informes

        }
    }
}
