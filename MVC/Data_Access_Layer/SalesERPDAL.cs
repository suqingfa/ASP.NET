using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVC.Models;

namespace MVC.Data_Access_Layer
{
	public class SalesERPDAL: DbContext
	{
		public DbSet<EmployeeModel> Employees { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<EmployeeModel>().ToTable("TblEmployee");
			base.OnModelCreating(modelBuilder);
		}

		public EmployeeModel SaveEmployee(EmployeeModel e)
		{
			Employees.Add(e);
			SaveChanges();
			return e;
		}
	}
}