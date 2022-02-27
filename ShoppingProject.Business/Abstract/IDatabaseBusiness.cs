using ShoppingProject.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Business.Abstract
{
    public interface IDatabaseBUsiness : IDisposable
    {
        ICustomerRepository Customer { get; }
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }

        int SaveChanges();
    }
}
