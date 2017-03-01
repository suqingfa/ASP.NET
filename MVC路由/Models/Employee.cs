using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC路由.Models
{
	public class Employee
	{
		public string Id { get; set; }

		public string Name { get; set; }

		public string Gender { get; set; }

		public DateTime BrithDate { get; set; }

		public string Department { get; set; }

		public Employee(string id, string name, string gender, DateTime brithDate, string department)
		{
			Id = id;
			Name = name;
			Gender = gender;
			BrithDate = brithDate;
			Department = department;
		}
	}

	public class EmployeeRepository
	{
		private static IList<Employee> employees;
		static EmployeeRepository()
		{
			employees = new List<Employee>();
			employees.Add(new Employee(Guid.NewGuid().ToString(), "张三", "男", new DateTime(1981, 8, 24), "销售部"));
			employees.Add(new Employee(Guid.NewGuid().ToString(), "李四", "女", new DateTime(1982, 1, 24), "人事部"));
			employees.Add(new Employee(Guid.NewGuid().ToString(), "王二", "男", new DateTime(1981, 9, 14), "人事部"));
		}

		public IEnumerable<Employee> GetEmployees(string id = "")
		{
			return from e in employees where e.Id == id || string.IsNullOrEmpty(id) || id  == "*" select e;
		}
	}
}