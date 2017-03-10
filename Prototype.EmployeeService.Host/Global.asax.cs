using Funq;
using Prototype.EmployeeService.Implementation.Repository;
using ServiceStack;
using System;

namespace Prototype.EmployeeService.Host
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Employee Service", typeof(Prototype.EmployeeService.Implementation.EmployeeService).Assembly) { }

        public override void Configure(Container container)
        {
            container.RegisterAs<EmployeeRepository, IEmployeeRepository>().ReusedWithin(ReuseScope.Request);          
        }
    }
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            new AppHost().Init();
        }
    }
}