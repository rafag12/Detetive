﻿using Detetive.Business.Business;
using Detetive.Business.Business.Interfaces;
using Detetive.Business.Data.Interfaces;
using Detetive.Data.Repository;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace Detetive.Injection
{
    public static class InjectionDependency
    {
        public static void Register()
        {
            Container container = new Container();

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Business
            container.Register<IAnotacaoArmaBusiness, AnotacaoArmaBusiness>(Lifestyle.Scoped);
            container.Register<IAnotacaoLocalBusiness, AnotacaoLocalBusiness>(Lifestyle.Scoped);
            container.Register<IAnotacaoSuspeitoBusiness, AnotacaoSuspeitoBusiness>(Lifestyle.Scoped);

            // Data
            container.Register<IArmaRepository, ArmaRepository>(Lifestyle.Scoped);
            container.Register<ILocalRepository, LocalRepository>(Lifestyle.Scoped);
            container.Register<ISalaRepository, SalaRepository>(Lifestyle.Scoped);
            container.Register<ISuspeitoRepository, SuspeitoRepository>(Lifestyle.Scoped);

            container.Register<IAnotacaoArmaRepository, AnotacaoArmaRepository>(Lifestyle.Scoped);
            container.Register<IAnotacaoLocalRepository, AnotacaoLocalRepository>(Lifestyle.Scoped);
            container.Register<IAnotacaoSuspeitoRepository, AnotacaoSuspeitoRepository>(Lifestyle.Scoped);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
