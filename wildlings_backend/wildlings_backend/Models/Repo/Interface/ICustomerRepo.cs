using System.Collections.Generic;

namespace wildlings_backend.Models.Repo.Interface
{
    public interface ICustomerRepo
    {
        List<wildlings.Customer> GetAllCustomer();

        wildlings.Customer GetCustomer(long id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}