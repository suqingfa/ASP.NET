using MVC.Filters;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
	[AdminFilter]
    public class BulkUploadController : Controller
    {
		public ActionResult Index()
        {
			return View();
		}

		public string Upload(HttpPostedFileBase FileUpload)
		{
			StreamReader reader = new StreamReader(FileUpload.InputStream);
			return reader.ReadToEnd();
		}
    }
}