using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
	public class EmployeeViewModel
	{
		public string EmployeeName { get; set; }
		public string Salary { get; set; }
		public string SalaryColor { get; set; }

		public EmployeeViewModel(EmployeeModel emp)
		{
			EmployeeName = emp.FirstName + " " + emp.LastName;
			Salary = emp.Salary.ToString("C");
			if (emp.Salary > 15000)
				SalaryColor = "yellow";
			else
				SalaryColor = "green";
		}
	}
}