using System.Collections.Generic;

namespace wildlings_backend.Models.Repo.Interface
{
    public interface ICourseRepo
    {
        IEnumerable<Course> GetCustomerCourse(long id);
    }
}