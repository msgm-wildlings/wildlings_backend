using System.Collections.Generic;
using wildlings_backend.Models.Repo.Interface;

namespace wildlings_backend.Models.Service.Interface
{
    public class CourseRepo : ICourseRepo
    {
        public IEnumerable<Course> GetCustomerCourse(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Course> GetCourse()
        {
            throw new System.NotImplementedException();
        }
    }
}