using JWTImplementationDemo.Context;
using JWTImplementationDemo.Interfaces;
using JWTImplementationDemo.Models;

namespace JWTImplementationDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JWTContext jwtContext;

        public EmployeeService(JWTContext jwtContext)
        {
            this.jwtContext = jwtContext;
        }
        public Employee AddEmployee(Employee employee)
        {
          var emp = jwtContext.Add(employee);
            jwtContext.SaveChanges();
            return emp.Entity;
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                var emp = jwtContext.Employees.SingleOrDefault(s => s.Id == id);
                if (emp == null)
                {
                    throw new Exception("User not found..");
                }
                else
                {
                    jwtContext.Employees.Remove(emp);
                    jwtContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            }

        public List<Employee> GetEmployeeDetails()
        {
            var employees = jwtContext.Employees.ToList();
            return employees;
        }

        public Employee GetEmployeeDetails(int id)
        {
            var emp = jwtContext.Employees.SingleOrDefault(s => s.Id == id);
            if(emp == null)
            {
                throw new Exception("User not found..");
            }
            else
            {
                return emp;
            }
        }

        public Employee UpdateEmployee(Employee employee)
        {
           var updated= jwtContext.Employees.Update(employee);  
            jwtContext.SaveChanges();
            return updated.Entity;
        }
    }
}
