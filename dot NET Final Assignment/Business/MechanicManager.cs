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
    public class MechanicManager : IMechnicManager
    {
        private IMechanicRepository _mechanicRepository;

        public MechanicManager(IMechanicRepository mechanicRepository)
        {
            _mechanicRepository = mechanicRepository;
        }

        public List<MechanicBusinessEntity> GetMechanics()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Mechanic, MechanicBusinessEntity>());
            IMapper mapper = config.CreateMapper();
            return _mechanicRepository.GetMechanics().Select(x => mapper.Map<Mechanic, MechanicBusinessEntity>(x)).ToList();
        }

        public bool AddMechanic(MechanicBusinessEntity businessEntity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<MechanicBusinessEntity,Mechanic>());
            IMapper mapper = config.CreateMapper();
            var mechanic = mapper.Map<MechanicBusinessEntity, Mechanic>(businessEntity);
            return _mechanicRepository.AddMechanic(mechanic);
        }

        public List<ServiceBusinessEntity> GetServices(MechanicBusinessEntity mechanic)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Service, ServiceBusinessEntity>());
            IMapper mapper = config.CreateMapper();
            var services = _mechanicRepository.GetMechanics().Where(x => x.ID == mechanic.ID).First().Services;
            return services.Select(x => mapper.Map<Service, ServiceBusinessEntity>(x)).ToList();
        }
    }
}
