using System.Collections.Generic;

namespace wildlings_backend.Models
{
    public class CustomerDetail

    {
        public Customer Customer { get; set; }
        public IEnumerable<Course> CourseDetail { get; set; }
    }
}