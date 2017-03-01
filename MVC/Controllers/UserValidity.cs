using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Controllers
{
	public class UserValidity
	{
		public UserStatus GetUserValidity(UserDetails u)
		{
			if (u.UserName == "Admin" && u.Password == "Admin")
				return UserStatus.AuthenticatedAdmin;
			else if (u.UserName == "su" && u.Password == "su")
				return UserStatus.AuthentucatedUser;
			return UserStatus.NonAuthenticatedUser;
		}
	}
}