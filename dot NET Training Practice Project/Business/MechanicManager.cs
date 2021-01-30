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
    public class MechanicManager : IMechanicManager
    {
        private IMechanicRepository _mechanicRepository;

        public MechanicManager(IMechanicRepository mechanicRepository)
        {
            _mechanicRepository = mechanicRepository;
        }

        public List<MechanicBusinessEntity> GetMechanics()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Mechanic,MechanicBusinessEntity>());
            IMapper mapper = config.CreateMapper();

            var mechanics = _mechanicRepository.GetMechanics().ToList();
            List<MechanicBusinessEntity> businessEntity = mechanics.Select(x => mapper.Map<Mechanic, MechanicBusinessEntity>(x)).ToList();

            return businessEntity;
        }
    }
}
