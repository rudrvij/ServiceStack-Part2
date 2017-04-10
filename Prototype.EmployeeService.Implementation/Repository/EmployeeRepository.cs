using System.Collections.Generic;
using System.Linq;
using Prototype.EmployeeService.Contracts;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStack;

namespace Prototype.EmployeeService.Implementation.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IDbConnectionFactory DbFactory { get; set; }

        public int AddEmployee(Employee employee, string companyName)
        {
            int result = 0;
            int companyId = 0;

            using (var db = DbFactory.OpenDbConnection())
            {
                companyId = db.Select<Pocos.Company>(p => p.CompanyName == companyName).FirstNonDefault().Id;

                var v = new Pocos.Employee() { CompanyId = companyId, FirstName = employee.FirstName, LastName = employee.LastName, SSN = employee.SSN, EmailAddress = employee.EmailAddress, };
                db.Save(v);
                result = v.Id;
            }
            return result;
        }

        public List<Employee> GetEmployeesByCompany(string companyId)
        {
            List<Employee> employeeList = null;
            using (var db = DbFactory.OpenDbConnection())
            {
                var q = db.From<Pocos.Employee>()
                    .Join<Pocos.Company>()
                    .Where<Pocos.Company>(p => p.CompanyName == companyId);
                employeeList = db.Select<Pocos.Employee>(q).ToList().ConvertAll(x => x.ConvertTo<Employee>()).ToList();
            }
            return employeeList;            
        }
    }
}
