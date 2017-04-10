using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.EmployeeService.Contracts
{
    [Route("/{CompanyName}/employees/", "POST")]
    public class AddEmployee : IPost, IReturn<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string EmailAddress { get; set; }
        public string CompanyName { get; set; }

    }    
}
