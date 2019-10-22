using System.Collections.Generic;
using System.Linq;
using wildlings_backend.Models.Repo;
using wildlings_backend.Models.Repo.Interface;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Models.Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepo _customerRepo = new CustomerRepo();

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _customerRepo.GetAllCustomer().Select(x => new Customer() { Id = x.Id, Name = x.Name, PersonalId = x.PersonalId });
        }

        public Customer GetCustomer(long id)
        {
            var customer = _customerRepo.GetCustomer(id);

            return new Customer()
            {
                Id = customer.Id,
                Name = customer.Name,
                PersonalId = customer.Name,
                Email = customer.Email,
                Address = customer.Address

            }; ;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepo.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepo.UpdateCustomer(customer);
        }
    }
}