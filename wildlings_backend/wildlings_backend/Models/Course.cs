using wildlings_backend.Controllers;
using wildlings_backend.Models.Enum;

namespace wildlings_backend.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CourseType Type { get; set; }
        public int Count { get; set; }
        public Period Period { get; set; }
    }
}