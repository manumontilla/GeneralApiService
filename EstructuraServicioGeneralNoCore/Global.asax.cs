using EstructuraServicioGeneral.Interfaces.Maps;
using EstructuraServicioGeneral.Interfaces.Respository;
using EstructuraServicioGeneral.Interfaces.Services;
using EstructuraServicioGeneral.Maps;
using EstructuraServicioGeneral.Repository;
using EstructuraServicioGeneral.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimpleInjector;
using EstructuraServicioGeneralNoCore.App_Start;

namespace EstructuraServicioGeneralNoCore
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            
            var container = new Container();
            container.Register<IFooMap, FooMap>();
            container.Register<IFooService, FooService>();
            container.Register<IFooRepository, FooRepository>();

            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorDependencyResolver(container);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalConfiguration.Configuration.EnsureInitialized();
        }
    }
}
