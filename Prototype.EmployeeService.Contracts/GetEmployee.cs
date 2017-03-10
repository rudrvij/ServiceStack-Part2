using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.EmployeeService.Contracts
{
    [Route("/employees/{CompanyId}", "GET")]
    public class GetEmployeesRequest: IGet, IReturn<GetEmployeesResponse>
    {
        public string CompanyId { get; set; }
    }
    public class GetEmployeesResponse
    {
        public List<Employee> Employees { get; set; }

    }
    

}
