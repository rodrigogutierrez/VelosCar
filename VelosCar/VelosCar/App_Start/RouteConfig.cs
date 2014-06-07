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
                defaults: new { controller = "Home", action = "Index"},
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //rutas del vehiculo

            //listar vehiculos
            routes.MapRoute(
                name: "vehiculos",
                url: "vehiculos",
                defaults: new { controller = "Vehiculo", action = "Index"},
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //registrar vehiculos
            routes.MapRoute(
                name: "registrar_vehiculos",
                url: "vehiculos/registrar",
                defaults: new { controller = "Vehiculo", action = "Registrar"},
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //editar vehiculos
            routes.MapRoute(
                name: "editar_vehiculo",
                url: "vehiculos/{id}/registrar",
                defaults: new { controller = "Vehiculo", action = "Editar"},
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            //editar vehiculos
            routes.MapRoute(
                name: "ver_vehiculo",
                url: "vehiculos/{id}",
                defaults: new { controller = "Vehiculo", action = "Ver"},
                constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );
                //rutas del tipo de vehiculo
                //rutas del combustible
                //rutas de los accesorios
                //rutas de la marca de vehiculo
                //rutas del equipamiento
            //rutas del usuarios
            //rutas de la reserva
            //rutas de las tarifas
            //rutas de las sucursales
            
        }
    }
