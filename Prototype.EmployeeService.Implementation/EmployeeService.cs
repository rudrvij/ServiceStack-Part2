using Prototype.EmployeeService.Contracts;
using Prototype.EmployeeService.Implementation.Repository;
using ServiceStack;
using System.Collections.Generic;

namespace Prototype.EmployeeService.Implementation
{
    public class EmployeeService: ServiceStack.Service
    {
        public IEmployeeRepository repo { get; set; }

        public List<Employee> Get(GetEmployees request)
        {            
            return repo.GetEmployeesByCompany(request.CompanyId);
        }
        public int Post(AddEmployee request)
        {
            //Using ServiceStack's Mapping
            Employee employeeToAdd = new Employee().PopulateWith(request);
            return repo.AddEmployee(employeeToAdd, request.CompanyName);
        }
    }
}
