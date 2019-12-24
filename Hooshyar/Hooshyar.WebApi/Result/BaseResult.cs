using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hooshyar.WebApi.Result
{
	public class BaseResult
	{
		public string ResultCode { get; set; }
		public string Message { get; set; }
	}
}