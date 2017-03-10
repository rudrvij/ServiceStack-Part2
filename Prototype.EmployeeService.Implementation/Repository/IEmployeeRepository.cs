using Prototype.EmployeeService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.EmployeeService.Implementation.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployeesByCompany(string companyId);
        int AddEmployee(Employee employee, string companyId);
    }
}
