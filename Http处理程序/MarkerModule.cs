using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Http处理程序
{
	public class MarkerModule : IHttpModule
	{
		public void Dispose()
		{
		}

		public void Init(HttpApplication context)
		{
			context.BeginRequest += OnBeginRequest;
		}

		private void OnBeginRequest(object sender, EventArgs e)
		{
			var app = sender as HttpApplication;
			var ctx = app.Context;
			ctx.Response.AppendHeader("Author", "DinoE");
		}
	}
}