using System.Collections.Generic;
using wildlings_backend.Models.Enum;

namespace wildlings_backend.Models.Service.Interface
{
    public interface ICourseService
    {
        void Register(int customerId, EnumCourse courseId);
        IEnumerable<Course> GetCustomerCourse(long id);
        IEnumerable<Course> GetAllCourse();
        void DeductCourse(int customerId, EnumCourse courseId);
        void RegisterByCount(int customerId, int courseId, int count);
        void RegisterByRange(int customerId, int courseId, Period period);
    }
}