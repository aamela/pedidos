using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Threading;
using System.Data.Entity;
using Microsoft.AspNet.Identity.Owin;
using System.Configuration;
using System.Web.Security;

namespace pedidos
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class Pedidos : System.Web.HttpApplication
    {
    

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FormsAuthentication.EnableFormsAuthentication(ConfigurationManager.AppSettings);
            RegisterRoutes(RouteTable.Routes);
            

        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "/pedidos/Home/CargarSubfamilia",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "CargarSubfamilia" }
            );

            routes.MapRoute(
                name: "/pedidos/Home/SeleccionarCliente",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "SeleccionarCliente" }
            );

            routes.MapRoute(
               name: "/pedidos/Pedido/ObtenerTotalPedido",
               url: "{controller}/{action}",
               defaults: new { controller = "Pedido", action = "ObtenerTotalPedido" }
           );

            routes.MapRoute(
                name: "/pedidos/Home/Salir",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Salir" }
            );

            routes.MapRoute(
               name: "/pedidos/Pedido/ObtenerTotalPedido",
               url: "{controller}/{action}",
               defaults: new { controller = "Pedido", action = "ObtenerTotalPedido" }
           );
        }

    }
}