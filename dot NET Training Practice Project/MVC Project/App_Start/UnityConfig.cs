using Business;
using Business.Interface;
using Business.Repository_Helper;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVC_Project
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<ICustomerManager, CustomerManager>();
            container.RegisterType<IVehicleManager, VehicleManager>();
            container.RegisterType<IDealerManager, DealerManager>();
            container.RegisterType<IMechanicManager, MechanicManager>();
            container.AddNewExtension<UnityRepositoryHelper>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}