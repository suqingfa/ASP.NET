using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
	public class EmployeeModel
	{
		[Key]
		public int EmployeeId { get; set; }

		[Required(ErrorMessage = "Enter First Name")]
		public string FirstName { get; set; }

		[StringLength(5, ErrorMessage ="Last Name length should nor be greater than {1}")]
		public string LastName { get; set; }


		public int Salary { get; set; }
	}
}