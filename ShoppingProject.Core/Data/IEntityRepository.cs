﻿using ShoppingProject.Core.Entity;
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
		T Get(Expression<Func<T, bool>> filter);

		T GetByID(int ID);

		IQueryable<T> GetAll();

		IQueryable<T> GetList(Expression<Func<T, bool>> filter);

		void Add(T entity);

		void Update(T entity);

		void Delete(T entity);

		void SaveChanges();
	}
}