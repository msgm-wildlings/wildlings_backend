using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using wildlings_backend.Models;
using wildlings_backend.Models.Enum;
using wildlings_backend.Models.Service;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ICourseService _courseService;

        public CustomerController(ICourseService courseService, ICustomerService customerService)
        {
            _customerService = customerService;
            _courseService = courseService;
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _customerService.GetAllCustomer();
        }

        [HttpGet("{id}")]
        public CustomerDetail GetCustomer(long id)
        {
            var customer = _customerService.GetCustomer(id);
            var customerCourse = _courseService.GetCustomerCourse(id);

            var customerDetail = new CustomerDetail { Customer = customer, CourseDetail = customerCourse };
            return customerDetail;
        }

        [HttpPost("AddCustomer")]
        public int AddCustomer(Customer customer)
        {
            _customerService.AddCustomer(customer);
            return (int)ApiCode.Success;
        }
        [HttpPost("UpdateCustomer")]
        public int UpdateCustomer(Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return (int)ApiCode.Success;
        }
    }
}