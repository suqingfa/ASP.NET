using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
	public class EmployeeListViewModel
	{
		public List<EmployeeViewModel> Employees { get; set; }
		public string UserName { get; set; }

		public EmployeeListViewModel(string userName, List<EmployeeModel> list)
		{
			UserName = userName;
			Employees = new List<EmployeeViewModel>();
			foreach (var item in list)
			{
				Employees.Add(new EmployeeViewModel(item));
			}
		}
	}
}