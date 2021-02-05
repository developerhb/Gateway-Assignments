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
    public class DealerManager : IDealerManager
    {
        private IDealerRepository _dealerRepository;

        public DealerManager(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        public List<DealerBusinessEntity> GetDealers()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Dealer,DealerBusinessEntity>()
            .ForMember(destination => destination.NumberOfMechanics, opts => opts.MapFrom(source => source.Mechanics.Count())));
            IMapper mapper = config.CreateMapper();

            var dealers = _dealerRepository.GetDealers().ToList();
            List<DealerBusinessEntity> businessEntity = dealers.Select(x => mapper.Map<Dealer, DealerBusinessEntity>(x)).ToList();

            return businessEntity;
        }

        public bool AddDealer(DealerRegistration registration)
        {
            var dealerConfig = new MapperConfiguration(cfg => cfg.CreateMap<DealerBusinessEntity, Dealer>());
            var mechanicConfig = new MapperConfiguration(cfg => cfg.CreateMap<MechanicBusinessEntity, Mechanic>());

            IMapper dealerMapper = dealerConfig.CreateMapper();
            IMapper mechanicMapper = mechanicConfig.CreateMapper();

            Dealer dealer = dealerMapper.Map<DealerBusinessEntity, Dealer>(registration.Dealer);
            Mechanic mechanic = mechanicMapper.Map<MechanicBusinessEntity, Mechanic>(registration.Mechanic);

            return _dealerRepository.AddDealer(dealer, mechanic);
        }
    }
}
