using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
//using Core;
//using Core.Interfaces;
//using DependencyResolution;
using StructureMap;
using IDependencyResolver = System.Web.Mvc.IDependencyResolver;

namespace CisionTranslationsPortal
{
    public class StructureMapDependencyResolver : IDependencyResolver
    {
        public StructureMapDependencyResolver(IContainer container)
        {
            _container = container;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType.IsAbstract || serviceType.IsInterface)
            {
                return _container.TryGetInstance(serviceType);
            }
            else
            {
                return _container.GetInstance(serviceType);
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAllInstances<object>()

                .Where(s => s.GetType() == serviceType);
        }

        private readonly IContainer _container;
    }
}