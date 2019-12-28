using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hooshyar.Data;
using Hooshyar.Service.EfService;
using Hooshyar.Service.Interface;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Web;

namespace Hooshyar.IocConfig
{
	//Structure map base config
	public static class SmObjectFactory
	{
		private static readonly Lazy<Container> _containerBuilder =
			new Lazy<Container>(defaultContainer, LazyThreadSafetyMode.ExecutionAndPublication);

		public static IContainer Container
		{
			get { return _containerBuilder.Value; }
		}

		private static Container defaultContainer()
		{
			var container = new Container(ioc =>
			{
				
				ioc.Scan(scan =>
				{
					scan.TheCallingAssembly();
					scan.WithDefaultConventions();
				});
				ioc.For<IUnitOfWork>().HybridHttpOrThreadLocalScoped().Use<HooshyarDbContext>();
				ioc.For<HooshyarDbContext>().HybridHttpOrThreadLocalScoped().Use(context => (HooshyarDbContext)context.GetInstance<IUnitOfWork>());
				ioc.For<DbContext>().HybridHttpOrThreadLocalScoped().Use(context => (HooshyarDbContext)context.GetInstance<IUnitOfWork>());

				ioc.For<IItemService>().Use<ItemService>();
				ioc.For<ICountTypeService>().Use<CountTypeService>();
				
			});
			return container;
		}
	}
}
