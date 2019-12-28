using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hooshyar.Model;

namespace Hooshyar.Service.Interface
{
	public interface ICountTypeService
	{
		List<CountType> GetTypes();
	}
}
