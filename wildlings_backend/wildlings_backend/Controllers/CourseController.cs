using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using wildlings_backend.Models;
using wildlings_backend.Models.Enum;
using wildlings_backend.Models.Service;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IEnumerable<Course> GetCourse()
        {
            return _courseService.GetAllCourse();
        }

        [HttpPost("DeductCourse")]
        public IActionResult DeductCourse(int customerId, EnumCourse courseId)
        {
            _courseService.DeductCourse(customerId, courseId);
            return Ok();
        }

        [HttpPost("RegisterByCount")]
        public IActionResult RegisterByCount(int customerId, int courseId, int Count)
        {
            _courseService.RegisterByCount(customerId, courseId, Count);
            return Ok();
        }
        [HttpPost("RegisterByRange")]
        public IActionResult RegisterByRange(int customerId, int courseId, Period period)
        {
            _courseService.RegisterByRange(customerId, courseId, period);
            return Ok();
        }
    }
}