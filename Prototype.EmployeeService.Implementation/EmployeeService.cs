using Prototype.EmployeeService.Contracts;
using Prototype.EmployeeService.Implementation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.EmployeeService.Implementation
{
    public class EmployeeService: ServiceStack.Service
    {
        public IEmployeeRepository repo { get; set; }

        public GetEmployeesResponse Get(GetEmployeesRequest request)
        {
            return new GetEmployeesResponse()
            {
                Employees = repo.GetEmployeesByCompany(request.CompanyId)
            };
        }
    }
}
