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
    public class ServiceManager : IServiceManager
    {
        private IServiceRepository _serviceRepository;

        public ServiceManager(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public List<ServiceBusinessEntity> GetServices()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Service, ServiceBusinessEntity>());
            IMapper mapper = config.CreateMapper();
            return _serviceRepository.GetServices().Select(x => mapper.Map<Service, ServiceBusinessEntity>(x)).ToList();
        }

        public bool AddService(ServiceBusinessEntity businessEntity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiceBusinessEntity, Service>());
            IMapper mapper = config.CreateMapper();
            var service = mapper.Map<ServiceBusinessEntity, Service>(businessEntity);
            return _serviceRepository.AddService(service);
        }

        public bool BookService(ServiceBusinessEntity businessEntity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiceBusinessEntity, Service>());
            IMapper mapper = config.CreateMapper();
            var service = mapper.Map<ServiceBusinessEntity, Service>(businessEntity);
            return _serviceRepository.BookService(service);
        }
    }
}
