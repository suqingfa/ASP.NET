using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC.Controllers
{
	public class AuthenticationController : Controller
	{
		public ActionResult Login()
		{
			return View("Login");
		}

		[HttpPost]
		public ActionResult DoLogin(UserDetails u)
		{
			if (ModelState.IsValid)
			{
				UserStatus status = new UserValidity().GetUserValidity(u);
				switch (status)
				{
					case UserStatus.AuthenticatedAdmin:
					case UserStatus.AuthentucatedUser:
						Session["IsAdmin"] =  status == UserStatus.AuthenticatedAdmin;
						FormsAuthentication.SetAuthCookie(u.UserName, false);
						return RedirectToAction("EmployeeListView", "Employee");
				}

				Session["IsAdmin"] = false;
				ModelState.AddModelError("CredentialError", "Invalid Username or Password");
			}

			return View("Login");
		}

		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Login");
		}
	}
}