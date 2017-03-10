using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.EmployeeService.Contracts
{
    [Route("/employees/", "POST")]
    public class AddEmployeeRequest : IPost, IReturn<AddEmployeeResponse>
    {
        public Employee Employee { get; set; }
    }
    public class AddEmployeeResponse
    {
        public int EmployeeId { get; set; }

    }
}
