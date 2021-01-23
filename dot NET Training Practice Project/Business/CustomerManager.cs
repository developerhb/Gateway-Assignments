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
            var customers = _customerRepository.GetCustomers().ToList();
            List<CustomerBusinessEntity> businessEntity = new List<CustomerBusinessEntity>();
            CustomerBusinessEntity customerBusinessEntity = new CustomerBusinessEntity();
            foreach (var customer in customers)
            {
                customerBusinessEntity.ID = customer.ID;
                customerBusinessEntity.FirstName = customer.FirstName;
                customerBusinessEntity.LastName = customer.LastName;
                customerBusinessEntity.Email = customer.Email;
                customerBusinessEntity.Contact = customer.Contact;
                customerBusinessEntity.NumberOfVehicles = customer.Vehicles.Count();

                businessEntity.Add(customerBusinessEntity);
            }

            return businessEntity;
        }
    }
}
