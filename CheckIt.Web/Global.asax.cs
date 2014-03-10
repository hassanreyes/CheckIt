using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.Web;
using CheckIt.Domain;
using CheckIt.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CheckIt.Web
{
    public class MvcApplication : System.Web.HttpApplication, IContainerProviderAccessor
    {
        // Provider that holds the application container.
        static IContainerProvider _containerProvider;

        // Instance property that will be used by Autofac HttpModules
        // to resolve and inject dependencies.
        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }


        protected void Application_Start()
        {
            // Once you're done registering things, set the container
            // provider up with your registrations.
            _containerProvider = new ContainerProvider(BootstrapContainer());

            DependencyResolver.SetResolver(new AutofacDependencyResolver(_containerProvider.ApplicationContainer));

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            System.Data.Entity.Database.SetInitializer<CheckIt.Domain.CheckItContext>(null);
        }

        /// <summary>
        /// Bootstrapper is the place where you create and configure your container
        /// </summary>
        /// <returns>An Autofac container</returns>
        private IContainer BootstrapContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // You can make property injection available to your MVC views by adding the ViewRegistrationSource to your ContainerBuilder before building the application container.
            //builder.RegisterSource(new ViewRegistrationSource());
            // An example of a module that registers the dependencies for a ServiceLayer of your application
            builder.RegisterModule(new IoCResolver.InfrastructureModule());
            builder.RegisterModule(new IoCResolver.IdentityModule());
            builder.RegisterModule(new IoCResolver.RepositoriesModule());
            builder.RegisterModule(new IoCResolver.ServicesModule());
            
            return builder.Build();
        }

    }

}
