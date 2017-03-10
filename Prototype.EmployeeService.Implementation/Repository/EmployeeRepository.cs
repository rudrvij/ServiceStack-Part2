using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.EmployeeService.Contracts;

namespace Prototype.EmployeeService.Implementation.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public int AddEmployee(Employee employee, string companyId)
        {
            return 100;
        }

        public List<Employee> GetEmployeesByCompany(string companyId)
        {
            if(companyId == "ATP")
            {
                return new List<Employee>()
                {
                    new Employee() { EmployeeId = 1, FirstName = "Roger", LastName ="Federer", SSN="111-11-1111"  },
                    new Employee() { EmployeeId = 2, FirstName = "Novak", LastName ="Djokovic", SSN="222-22-2222"  },
                    new Employee() { EmployeeId = 3, FirstName = "Rafael", LastName ="Nadal", SSN="333-33-3333"  },
                    new Employee() { EmployeeId = 4, FirstName = "Andy", LastName ="Murray", SSN="444-44-4444"  }
                };
            }
            else
            {
                return new List<Employee>()
                {
                    new Employee() { EmployeeId = 10, FirstName = "Ned", LastName ="Stark", SSN="111-11-0000"  },
                    new Employee() { EmployeeId = 20, FirstName = "Tyrion", LastName ="Lannister", SSN="222-22-0000"  },
                    new Employee() { EmployeeId = 30, FirstName = "John", LastName ="Snow", SSN="333-33-0000"  },
                    new Employee() { EmployeeId = 40, FirstName = "Denerius", LastName ="Targerian", SSN="444-44-0000"  }

                };
            }
            
        }
    }
}
