using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
	public class UserDetails
	{
		[StringLength(7, MinimumLength = 2, ErrorMessage = "UserName length should be between 2 and 7")]
		public string UserName { get; set; }

		[StringLength(7, MinimumLength = 2, ErrorMessage = "Password length should be between 2 and 7")]
		public string Password { get; set; }
	}
}