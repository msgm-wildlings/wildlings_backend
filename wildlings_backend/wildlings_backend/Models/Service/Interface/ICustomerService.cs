using System.Collections.Generic;

namespace wildlings_backend.Models.Service.Interface
{
    public interface ICustomerService 
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomer(long id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}