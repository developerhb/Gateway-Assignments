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
    public class CustomerManager : ICustomerManager
    {
        ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<CustomerBusinessEntity> GetCustomers()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerBusinessEntity>());
            IMapper mapper = config.CreateMapper();
            return _customerRepository.GetCustomers().Select(x => mapper.Map<Customer, CustomerBusinessEntity>(x)).ToList();
        }

        public bool AddCustomer(CustomerBusinessEntity businessEntity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerBusinessEntity,Customer>());
            IMapper mapper = config.CreateMapper();
            var customer = mapper.Map<CustomerBusinessEntity, Customer>(businessEntity);
            return _customerRepository.AddCustomer(customer);
        }
    }
}
