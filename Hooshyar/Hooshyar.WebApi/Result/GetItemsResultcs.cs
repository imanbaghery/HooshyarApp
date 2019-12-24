using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hooshyar.Model;

namespace Hooshyar.WebApi.Result
{
	public class GetItemsResultcs:BaseResult
	{
		public IList<Item> Items { get; set; }
	}
}