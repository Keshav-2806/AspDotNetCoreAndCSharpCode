using JWTImplementationDemo.Interfaces;
using JWTImplementationDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTImplementationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public List<Employee> Get()
        {
            var employees = employeeService.GetEmployeeDetails();
            return employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            var employee= employeeService.GetEmployeeDetails(id);
            return employee;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public Employee Post([FromBody] Employee employee)
        {
            var emp = employeeService.AddEmployee(employee);
            return emp;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public Employee Put(int id, [FromBody] Employee employee)
        {
            var emp = employeeService.UpdateEmployee(employee);
            return emp;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var isDeleted = employeeService.DeleteEmployee(id); 
            return isDeleted;
        }
    }
}
