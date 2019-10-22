using System;
using System.Collections.Generic;
using System.Linq;
using wildlings_backend.Models.Exception;
using wildlings_backend.Models.Repo.Interface;
using wildlings_backend.wildlings;

namespace wildlings_backend.Models.Repo
{
    public class CustomerRepo : ICustomerRepo
    {
        private wildlingsContext _db = new wildlingsContext();

        public void AddCustomer(Customer customer)
        {
            if (IsUserExist(customer))
            {
                throw new AddCustomerException();
            }

            _db.Customer.Add(new wildlings.Customer
            {
                Id = customer.Id,
            });
        }

        public List<wildlings.Customer> GetAllCustomer()
        {
            return _db.Customer.ToList();
        }

        public wildlings.Customer GetCustomer(long id)
        {
            return _db.Customer.FirstOrDefault(x => x.Id == id);
        }
        public void UpdateCustomer(Customer customer)
        {
            if (!IsUserExist(customer))
            {
                throw new UpdateCustomerException();
            }

            _db.Customer.Update(new wildlings.Customer
            {
                Id = customer.Id,
            });
        }

        private bool IsUserExist(Customer customer)
        {
            return _db.Customer.Count(x => x.Id == customer.Id) != 0;
        }
    }
}