using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using StructureMap;

namespace Hooshyar.IocConfig
{
	//for use structure map in web api
	public class StructureMapHttpControllerActivator : IHttpControllerActivator
	{
		private readonly IContainer _container;
		public StructureMapHttpControllerActivator(IContainer container)
		{
			_container = container;
		}

		public IHttpController Create(
			HttpRequestMessage request,
			HttpControllerDescriptor controllerDescriptor,
			Type controllerType)
		{
			var nestedContainer = _container.GetNestedContainer();
			request.RegisterForDispose(nestedContainer);
			return (IHttpController)nestedContainer.GetInstance(controllerType);
		}
	}
}
