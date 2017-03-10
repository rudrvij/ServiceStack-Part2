using Prototype.EmployeeService.Contracts;
using Prototype.UI.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prototype.UI.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult List()
        {
            EmployeeListViewModel viewModel = new EmployeeListViewModel();

            JsonServiceClient client = new JsonServiceClient(GetEmployeeServiceUrl());
            var response = client.Get<GetEmployeesResponse>("employees/ATP");
            if (response != null)
            {
                viewModel.Employees = response.Employees;
            }
            return View(viewModel);
        }

        private string GetEmployeeServiceUrl()
        {
            return ConfigurationManager.AppSettings["EmployeeServiceUrl"].ToString();
        }
    }
}