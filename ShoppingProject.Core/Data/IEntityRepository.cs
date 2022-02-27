using ShoppingProject.Core.Entity;
using ShoppingProject.Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Core.Data
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
		IDataResult<T> Get(Expression<Func<T, bool>> filter);

		IDataResult<T> GetByID(int ID);

		IDataResult<IQueryable<T>> GetAll();

		IDataResult<IQueryable<T>> GetList(Expression<Func<T, bool>> filter);

		IResult Add(T entity);

		IResult Update(T entity);

		IResult Delete(T entity);

		IResult SaveChanges();
	}
}
