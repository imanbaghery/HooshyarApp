using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooshyar.WebApi.enums
{

	public enum Results
	{
		[Description("بروز خطا در انجام عملیات")]
		Exception = 0,

		[Description("عملیات با موفقیت انجام شد")]
		Success = 1,
		
	}
}
