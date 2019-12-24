using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Hooshyar.Data;
using Hooshyar.Model;
using Hooshyar.Service.Interface;
using Hooshyar.Utility;
using Hooshyar.WebApi.enums;
using Hooshyar.WebApi.Result;

namespace Hooshyar.WebApi.Controllers
{
	public class ItemServiceController : ApiController

	{
		private IUnitOfWork _unitOfWork;
		private IItemService _itemService;

		public ItemServiceController(IUnitOfWork unitOfWork, IItemService itemService)
		{
			_unitOfWork = unitOfWork;
			_itemService = itemService;
		}

		[Route("ItemService/AddItem")]
		[HttpPost]
		[HttpGet]
		[ResponseType(typeof(BaseResult))]
		public IHttpActionResult AddItem(string name, int count, int countType)
		{
			var result = new BaseResult();
			try
			{
				var item = new Item(name, count, countType);
				_itemService.AddItem(item);

				result.ResultCode = Results.Success.GetCode();
				result.Message = Results.Success.GetDescription();

			}
			catch (Exception e)
			{
				result.ResultCode = Results.Exception.GetCode();
				result.Message = Results.Exception.GetDescription();

			}
			return Ok(result);

		}

		[Route("BuyerService/Registration")]
		[HttpPost]
		[HttpGet]
		[ResponseType(typeof(BaseResult))]
		public IHttpActionResult GetItems()
		{
			var result = new GetItemsResultcs();
			try
			{
			
				var items= _itemService.GetAll();
				result.Items = items;
				result.ResultCode = Results.Success.GetCode();
				result.Message = Results.Success.GetDescription();

			}
			catch (Exception e)
			{
				result.ResultCode = Results.Exception.GetCode();
				result.Message = Results.Exception.GetDescription();

			}
			return Ok(result);

		}
	}
}
