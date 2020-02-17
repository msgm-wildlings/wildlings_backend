using System.Collections.Generic;
using wildlings_backend.Models.Enum;
using wildlings_backend.Models.Repo.Interface;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Models.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepo _courseRepo;

        public CourseService(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }

        public void Register(int customerId, EnumCourse courseId)
        {
       
        }

        public IEnumerable<Course> GetCustomerCourse(long id)
        {
            return _courseRepo.GetCourse();

        }

        public IEnumerable<Course> GetAllCourse()
        {
            return _courseRepo.GetCourse();

        }

        public void DeductCourse(int customerId, EnumCourse courseId)
        {
        }

        public void RegisterByCount(int id, int customerId, int courseId)
        {
        }

        public void RegisterByRange(int customerId, int courseId, Period period)
        {
        }
    }
}