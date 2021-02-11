using Business;
using Business.Interface;
using Business.RepositoryHelper;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Service_Booking
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<ICustomerManager,CustomerManager>();
            container.RegisterType<IVehicleManager, VehicleManager>();
            container.RegisterType<IMechnicManager,MechanicManager>();
            container.RegisterType<IServiceManager,ServiceManager>();
            container.AddNewExtension<UnityRepositoryHelper>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}