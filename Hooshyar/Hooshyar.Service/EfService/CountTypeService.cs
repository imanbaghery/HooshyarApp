using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hooshyar.Data;
using Hooshyar.Model;
using Hooshyar.Service.Interface;

namespace Hooshyar.Service.EfService
{
	public class CountTypeService:ICountTypeService
	{
		private IUnitOfWork _unitOfWork;
		private DbSet<CountType> _countTypes;

		public CountTypeService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			_countTypes = _unitOfWork.Set<CountType>();
		}


		public List<CountType> GetTypes()
		{
			return _countTypes.ToList();
		}
	}
}
