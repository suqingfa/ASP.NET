using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Web.SessionState;

namespace Http处理程序
{
	public class SimpleHandler : IHttpHandler // 同步http处理程序  IHttpAsyncHandler 异步http处理程序
		, IRequiresSessionState // 访问Session状态 IReadOnlySessionState//只读Session
	{
		public bool IsReusable => false; // 是否复用http处理程序

		public void ProcessRequest(HttpContext context)
		{
			string htmlTemplate =
				@"
				<!DOCTYPE html>
				<html>
					<head>
						<meta charset='UTF-8'/>
						<title>{0}</title>
					</head>
					<body>
						<h1>Hello I'm : <span style='color: blue;'>{1}</span></h1>
					</body>
				</html>";

			string response = string.Format(htmlTemplate, "HTTP Handlers", context.User);
			context.Response.Write(response);
		}
	}
}