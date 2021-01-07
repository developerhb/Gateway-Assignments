using HotelManagement.BAL;
using HotelManagement.BAL.Helper;
using HotelManagement.BAL.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace HotelManagement.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IHotelManager, HotelManager>();
            container.RegisterType<IRoomManager, RoomManager>();
            container.AddNewExtension<UnityRepositoryHelper>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}