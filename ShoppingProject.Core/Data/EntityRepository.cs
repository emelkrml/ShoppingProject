using Microsoft.EntityFrameworkCore;
using ShoppingProject.Core.Entity;
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

        public void Add(T entity)
            => context.Set<T>().Add(entity);

        public void Delete(T entity)
            => context.Set<T>().Remove(entity);

        public T Get(Expression<Func<T, bool>> filter)
            => context.Set<T>().FirstOrDefault(filter);

        public IQueryable<T> GetAll()
            => context.Set<T>();

        public T GetByID(int ID)
            => context.Set<T>().Find(ID);

        public IQueryable<T> GetList(Expression<Func<T, bool>> filter)
            => context.Set<T>().Where(filter);

        public void SaveChanges()
            => context.SaveChanges();

        public void Update(T entity)
            => context.Set<T>().Update(entity);
    }
}
