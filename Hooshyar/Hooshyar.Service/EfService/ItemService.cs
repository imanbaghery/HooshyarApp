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
	public class ItemService: IItemService
	{
		private IUnitOfWork _unitOfWork;
		private DbSet<Item> _items;

		public ItemService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			_items = _unitOfWork.Set<Item>();
		}
		public void AddItem(Item item)
		{
			_items.Add(item);
		}

		public Item Find(int id)
		{
			return _items.Find(id);
			
		}

		public void Update(Item item)
		{
			var dbItem = _items.Single(a => a.Id == item.Id);
			dbItem.Name = item.Name;
			dbItem.CountType = item.CountType;
			dbItem.Count = item.Count;
		}

		public void Delete(Item item)
		{
			_items.Remove(item);
		}

		public IList<Item> GetAll()
		{
			return _items.ToList();
		}
	}
}
