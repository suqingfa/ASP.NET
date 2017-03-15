using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web;

namespace WCF.svc
{
	[ServiceContract]
	public interface IAddService
	{
		[OperationContract]
		[WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		int Add(int a, int b);

		[OperationContract]
		[WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		User Get();
	}


	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class AddService : IAddService
	{
		public int Add(int a, int b)
		{
			return a + b;
		}

		public User Get()
		{
			return new User("su", 25);
		}
	}


	[DataContract]
	public class User
	{
		public User(string name, int age)
		{
			Name = name;
			Age = age;
		}

		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public int Age { get; set; }
	}
}