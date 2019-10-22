using System;
using System.Collections.Generic;
using wildlings_backend.Models.Enum;
using wildlings_backend.Models.Repo.Interface;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Models.Service
{
    public class CourseService : ICourseService
    {
        private ICourseRepo _courseRepo;

        public CourseService()
        {
            _courseRepo = new FakeCourseRep();
        }
        public IEnumerable<Course> GetAllCourse()
        {
            throw new System.NotImplementedException();
        }

        public void Register(int customerId, int courseId)
        {
            throw new System.NotImplementedException();
        }

        public void Cancel(int customerId, int courseId)
        {
            throw new System.NotImplementedException();
        }

        public void Renew(int customerId, int courseId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Course> GetCustomerCourse(long id)
        {
            return _courseRepo.GetCustomerCourse(id);
        }
    }

    public class FakeCourseRep : ICourseRepo
    {
        public IEnumerable<Course> GetCustomerCourse(long id)
        {
            return new List<Course>()
            {
                new Course(){Id = 1,Count = 10,Name = "格鬥",Type = CourseType.Count,Period = null},
                new Course(){Id = 2,Count = 0,Name = "格鬥",Type = CourseType.Month,Period = new Period(){Start = new DateTime(2019,10,1),End = new DateTime(2019,11,1)}},
                new Course(){Id = 3,Count = 9,Name = "肌力",Type = CourseType.Count,Period = null},
                new Course(){Id = 4,Count = 0,Name = "肌力",Type = CourseType.Month,Period = new Period(){Start = new DateTime(2019,9,1),End = new DateTime(2019,10,1)}},
                new Course(){Id = 5,Count = 8,Name = "燃脂",Type = CourseType.Count,Period = null},
                new Course(){Id = 6,Count = 0,Name = "燃脂",Type = CourseType.Month,Period = new Period(){Start = new DateTime(2019,8,1),End = new DateTime(2019,10,1)}},

            };
        }
    }
}