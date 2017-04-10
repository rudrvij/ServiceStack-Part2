using Prototype.EmployeeService.Contracts;
using Prototype.EmployeeService.Implementation.Repository;
using ServiceStack;
using ServiceStack.Logging;
using System.Collections.Generic;

namespace Prototype.EmployeeService.Implementation
{
    public class EmployeeService: ServiceStack.Service
    {
        public IEmployeeRepository repo { get; set; }
        public ILog logger { get; set; }

        public List<Employee> Get(GetEmployees request)
        {
            #region Logging
            logger.Debug("In GetEmployees method - Debug");
            //logger.Error("In GetEmployees method - Error");
            //logger.Fatal("In GetEmployees method - fatal");
            //logger.Info("In GetEmployees method - Info");
            //logger.Warn("In GetEmployees method - Warn");

            #endregion
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
