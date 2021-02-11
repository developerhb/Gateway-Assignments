using Data.Repository;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;

namespace Business.RepositoryHelper
{
    public class UnityRepositoryHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ICustomerRepository, CustomerRepository>();
            Container.RegisterType<IVehicleRepository, VehicleRespository>();
            Container.RegisterType<IMechanicRepository, MechanicRepository>();
            Container.RegisterType<IServiceRepository, ServiceRepository>();
        }
    }
}
