using System;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hooshyar.IocConfig
{
	public class StructureMapControllerFactory : DefaultControllerFactory
	{
		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			if (controllerType == null)
				throw new InvalidOperationException(
					$"Page not found: {requestContext.HttpContext.Request.Url.AbsoluteUri.ToString(CultureInfo.InvariantCulture)}");
			return SmObjectFactory.Container.GetInstance(controllerType) as Controller;
		}
	}
}
