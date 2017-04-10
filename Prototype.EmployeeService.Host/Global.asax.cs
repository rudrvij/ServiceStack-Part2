using Funq;
using Prototype.EmployeeService.Implementation.Repository;
using Prototype.EmployeeService.Implementation.Validators;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.Logging;
using ServiceStack.Logging.NLogger;
using ServiceStack.MiniProfiler;
using ServiceStack.MiniProfiler.Data;
using ServiceStack.OrmLite;
using ServiceStack.Validation;
using System;
using System.Configuration;

namespace Prototype.EmployeeService.Host
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Employee Service", typeof(Prototype.EmployeeService.Implementation.EmployeeService).Assembly) { }

        public override void Configure(Container container)
        {

            Plugins.Add(new ValidationFeature());

            //Register the Validators
            container.RegisterValidators(typeof(AddEmployeeValidator).Assembly);
            container.RegisterAs<EmployeeRepository, IEmployeeRepository>().ReusedWithin(ReuseScope.Request);

            //ORMLite 
            container.Register<IDbConnectionFactory>(
                new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["MyLocalDB"].ConnectionString, SqlServer2012Dialect.Provider)
                {
                    ConnectionFilter = x => new ProfiledDbConnection(x, Profiler.Current)
                }
                );
            //Logging
            container.Register<ILog>(
                ctx => LogManager.LogFactory.GetLogger(typeof(IService))
                );
        }
    }
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            LogManager.LogFactory = new NLogFactory();
            new AppHost().Init();
        }
    }
}