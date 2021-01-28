using AutoMapper;
using Business.Interface;
using BusinessEntities;
using Data.Models;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class VehicleManager : IVehicleManager
    {
        private IVehicleRepository _vehicleRepository;

        public VehicleManager(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public List<VehicleBusinessEntity> GetVehicles(int? custID)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vehicle, VehicleBusinessEntity>());
            IMapper mapper = config.CreateMapper();

            List<Vehicle> vehicles;
            if (custID == null)
                vehicles = _vehicleRepository.GetVehicles().ToList();
            else
                vehicles = _vehicleRepository.GetVehicles().Where(v => v.CustomerID == custID).ToList();
            List<VehicleBusinessEntity> businessEntity = vehicles.Select(x => mapper.Map<Vehicle, VehicleBusinessEntity>(x)).ToList();

            return businessEntity;
        }
    }
}
