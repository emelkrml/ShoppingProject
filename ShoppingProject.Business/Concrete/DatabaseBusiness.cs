using ShoppingProject.Business.Abstract;
using ShoppingProject.Data.Abstract;
using ShoppingProject.Data.Concrete;
using ShoppingProject.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Business.Concrete
{
    public class DatabaseBusiness : IDatabaseBUsiness
    {
        private readonly ShoppingContext context;

        public DatabaseBusiness()
            => context = new ShoppingContext();

        private ICustomerRepository _customer;
        private ICategoryRepository _category;
        private IProductRepository _product;

        public ICustomerRepository Customer
            => _customer ?? (_customer = new CustomerRepository(context));

        public IProductRepository Product
            => _product ?? (_product = new ProductRepository(context));

        public ICategoryRepository Category
            => _category ?? (_category = new CategoryRepository(context));

        public void Dispose() 
            => context.Dispose();

        public int SaveChanges()
            => context.SaveChanges();
    }
}
