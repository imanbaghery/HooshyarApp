using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooshyar.Data
{
	//Unit of work design pattern...
	public interface IUnitOfWork
	{
		DbSet<TEntity> Set<TEntity>() where TEntity : class;
		int SaveChanges();
		Task<int> SaveChangesAsync();
		void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class;
		void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class;
		IList<T> GetRows<T>(string sql, params object[] parameters) where T : class;
		void ForceDatabaseInitialize();
	}
}
