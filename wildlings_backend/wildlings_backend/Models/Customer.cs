using System;

namespace wildlings_backend.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PersonalId { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public string GuardianName { get; set; }
        public string GuardianPersonalId { get; set; }
        public string GuardianPhone { get; set; }
        public DateTime? GuardianBirthday { get; set; }
        public string MedicalCase { get; set; }
    }
}