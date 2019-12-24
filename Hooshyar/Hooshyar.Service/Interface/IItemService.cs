using System.Collections.Generic;
using Hooshyar.Model;

namespace Hooshyar.Service.Interface
{
	public interface IItemService
	{
		void AddItem(Item item);
		Item Find(int id);
		void Update(Item item);
		void Delete(Item item);
		IList<Item> GetAll();
	}
}
