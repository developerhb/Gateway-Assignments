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
    public class CustomerManager : ICustomerManager
    {
        private ICustomerRespository _customerRepository;

        public CustomerManager(ICustomerRespository customerRespository)
        {
            _customerRepository = customerRespository;
        }

        public List<CustomerBusinessEntity> GetCustomers()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerBusinessEntity>()
            .ForMember(destination => destination.NumberOfVehicles, opts => opts.MapFrom(source => source.Vehicles.Count())));
            IMapper mapper = config.CreateMapper();

            var customers = _customerRepository.GetCustomers().ToList();
            List<CustomerBusinessEntity> businessEntity = customers.Select(x => mapper.Map<Customer, CustomerBusinessEntity>(x)).ToList();

            return businessEntity;
        }
    }
}
