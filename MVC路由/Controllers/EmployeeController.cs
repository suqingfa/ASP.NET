using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC路由.Controllers
{
    public class EmployeeController : Controller
    {
        public void Index(string id)
        {
			foreach (var item in RouteData.Values)
			{
				Response.Write(string.Format("{0} : {1} <br/>", item.Key, item.Value));
			}
        }
    }
}