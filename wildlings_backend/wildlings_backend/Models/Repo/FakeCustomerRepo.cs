using System;
using System.Collections.Generic;
using System.Linq;
using wildlings_backend.Models.Repo.Interface;

namespace wildlings_backend.Models.Repo
{
    internal class FakeCustomerRepo : ICustomerRepo
    {
        private List<wildlings.Customer> _allCustomer = new List<wildlings.Customer>()
        {
            new wildlings.Customer()
            {
                Id=1,
                Name = "Cloud",
                PersonalId = "A123456789",
                Email = "test01@abc.com",
                Phone = "0987654321",
                Address = "TestAddress",
                Birthday = DateTime.Now,
                EmergencyContact = "Mother",
                EmergencyPhone = "110",
                GuardianName = "Father",
                GuardianBirthday = DateTime.Now,
                GuardianPersonalId = "B123456789",
                GuardianPhone = "110",
                MedicalCase = "1,2"
            },
            new wildlings.Customer()
            {
                Id=2,
                Name = "Tim",
                PersonalId = "B123456789",
                Email = "test02@abc.com",
                Phone = "1987654321",
                Address = "TestAddress2",
                Birthday = DateTime.Now.AddDays(-1),
                EmergencyContact = "Father",
                EmergencyPhone = "119",
                MedicalCase = "2,5,7"
            },
            new wildlings.Customer()
            {
                Id=3,
                Name = "Charlie",
                PersonalId = "C123456789",
                Email = "test03@abc.com",
                Phone = "2987654321",
                Address = "TestAddress3",
                Birthday = DateTime.Now.AddDays(1),
                EmergencyContact = "Father",
                EmergencyPhone = "110",

            },
        };

        public List<wildlings.Customer> GetAllCustomer()
        {
            return _allCustomer;
        }

        public wildlings.Customer GetCustomer(long id)
        {

            return _allCustomer.FirstOrDefault(x => x.Id == id);
        }

        public void AddCustomer(Customer customer)
        {
            _allCustomer.Add(new wildlings.Customer
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
        }

        public void UpdateCustomer(Customer customer)
        {
            var firstOrDefault = _allCustomer.FirstOrDefault(x => x.Id == customer.Id);
            _allCustomer.Remove(firstOrDefault);
            _allCustomer.Add(new wildlings.Customer
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
        }
    }
}