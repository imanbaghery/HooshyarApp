using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hooshyar.Model;

namespace Hooshyar.Data
{
	//this is my costumize dbContext
	public class HooshyarDbContext:DbContext,IUnitOfWork
		
	{
		public HooshyarDbContext() : base("name=Hooshyar")
		{
			
		}
		public void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class
		{
			Entry(entity).State = EntityState.Modified;
		}

		public void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class
		{
			Entry(entity).State = EntityState.Deleted;
		}

		public IList<T> GetRows<T>(string sql, params object[] parameters) where T : class
		{
			return Database.SqlQuery<T>(sql, parameters).ToList();
		}

		public void ForceDatabaseInitialize()
		{
			this.Database.Initialize(force: true);
		}

		public DbSet<CountType> CountTypes { get; set; }
		public DbSet<Item> Items { get; set; }

	}
}

