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

            using (var t = _db.Database.BeginTransaction())
            {
                _db.Customer.Add(new wildlings.Customer
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Address = customer.Address,
                    Email = customer.Email,
                    PersonalId = customer.PersonalId,
                    Birthday = customer.Birthday,
                    Phone = customer.Phone,
                    EmergencyContact = customer.EmergencyContact,
                    EmergencyPhone = customer.EmergencyPhone,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    GuardianName = customer.GuardianName,
                    GuardianPersonalId = customer.GuardianPersonalId,
                    GuardianPhone = customer.GuardianPhone,
                    GuardianBirthday = customer.GuardianBirthday,
                    MedicalCase = customer.MedicalCase
                });
                _db.SaveChanges();
                t.Commit();
            }

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

            using (var t = _db.Database.BeginTransaction())
            {
                var origin = _db.Customer.Find(customer.Id);
                _db.Entry(origin).CurrentValues.SetValues(customer);
                _db.SaveChanges();
                t.Commit();
            }
        }

        private bool IsUserExist(Customer customer)
        {
            return _db.Customer.Count(x => x.Id == customer.Id) != 0;
        }
    }
}