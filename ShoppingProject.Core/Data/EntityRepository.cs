using Microsoft.EntityFrameworkCore;
using ShoppingProject.Core.Entity;
using ShoppingProject.Core.Utilities.Constants;
using ShoppingProject.Core.Utilities.Result.Abstract;
using ShoppingProject.Core.Utilities.Result.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Core.Data
{
    public class EntityRepository<T> : IEntityRepository<T>
        where T : class, IEntity, new()
    {
        protected readonly DbContext context;

        public EntityRepository(DbContext _context)
            => context = _context;

      
        public IDataResult<T> Get(Expression<Func<T, bool>> filter)
        {
            try
            {
                return new SuccessDataResult<T>(context.Set<T>().FirstOrDefault(filter));
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<T>("Exception: " + ex);
            }
            
        }
            

        public IDataResult<IQueryable<T>> GetAll()
        {
            try
            {
                return new SuccessDataResult<IQueryable<T>>(context.Set<T>());
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IQueryable<T>>("Exception: " + ex);
            }
            
        }


        public IDataResult<T> GetByID(int ID)
        {
            try
            {
                return new SuccessDataResult<T>(context.Set<T>().Find(ID));
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<T>("Exception: " + ex);
            }
            
        }


        IDataResult<IQueryable<T>> IEntityRepository<T>.GetList(Expression<Func<T, bool>> filter)
        {
            try
            {
                return new SuccessDataResult<IQueryable<T>>(context.Set<T>().Where(filter));
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IQueryable<T>>(Messages.NotSaveChange + " HATA : " + ex);
            }
        }


        IResult IEntityRepository<T>.SaveChanges()
        {
            try
            {
                context.SaveChanges();
                return new SuccessResult(Messages.SaveChange);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.NotSaveChange + " HATA : " + ex);
            }
        }


        IResult IEntityRepository<T>.Add(T entity)
        {
            try
            {
                context.Set<T>().Add(entity);
                return new SuccessResult(Messages.ProductAdded);
            }
            catch (Exception ex)
            {
                return new SuccessResult(Messages.ProductNotAdded + " HATA : " + ex);
            }

        }


        IResult IEntityRepository<T>.Update(T entity)
        {
            try
            {
                context.Set<T>().Update(entity);
                return new SuccessResult(Messages.ProductUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ProductNotUpdated + " HATA : " + ex);
            }
        }


        IResult IEntityRepository<T>.Delete(T entity)
        {
            try
            {
                context.Set<T>().Remove(entity);
                return new SuccessResult(Messages.ProductDeleted);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ProductNotDeleted + " HATA : " + ex);
            }
        }
    }
}
