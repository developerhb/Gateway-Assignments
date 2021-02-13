using Business.Interface;
using BusinessEntities;
using AutoMapper;
using Data.Model;
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
        IVehicleRepository _vehicleRepository;

        public VehicleManager(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public List<VehicleBusinessEntity> GetVehicles()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vehicle, VehicleBusinessEntity>());
            IMapper mapper = config.CreateMapper();
            return _vehicleRepository.GetVehicles().Select(x => mapper.Map<Vehicle, VehicleBusinessEntity>(x)).ToList();
        }

        public bool AddVehicle(VehicleBusinessEntity businessEntity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<VehicleBusinessEntity, Vehicle>());
            IMapper mapper = config.CreateMapper();
            var vehicle = mapper.Map<VehicleBusinessEntity, Vehicle>(businessEntity);
            return _vehicleRepository.AddVehicle(vehicle);
        }

        public bool DeleteVehicle(int ID)
        {
            return _vehicleRepository.DeleteVehicle(ID);
        }
    }
}
