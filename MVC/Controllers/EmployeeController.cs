using MVC.Data_Access_Layer;
using MVC.Models;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
	[Authorize]
	public class EmployeeController : Controller
	{
		public string GetString()
		{
			return "Hello World is old now. Th's time for wassup bro";
		}

		public ActionResult EmployeeView()
		{
			EmployeeModel emp = new EmployeeModel { FirstName = "Sukesh", LastName = "Marla", Salary = 20000 }; ;
			return View("EmployeeView", new EmployeeViewModel(emp));
		}

		public ActionResult EmployeeListView()
		{
			EmployeeListViewModel list =
				new EmployeeListViewModel(User.Identity.Name, new SalesERPDAL().Employees.ToList());

			return View("EmployeeListView", list);
		}

		public ActionResult AddNew()
		{
			return View("CreateEmployee");
		}

		public ActionResult SaveEmployee(EmployeeModel e)
		{
			if (ModelState.IsValid)
			{
				new SalesERPDAL().SaveEmployee(e);
				return EmployeeListView();
			}
			else
				return AddNew();
		}
	}
}