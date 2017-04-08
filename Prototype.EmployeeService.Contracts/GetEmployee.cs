using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.EmployeeService.Contracts
{
    [Route("/{CompanyId}/employees", "GET")]
    public class GetEmployees: IGet, IReturn<List<Employee>>
    {
        public string CompanyId { get; set; }
    }    
}
