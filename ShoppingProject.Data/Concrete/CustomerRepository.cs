using ShoppingProject.Core.Data;
using ShoppingProject.Data.Abstract;
using ShoppingProject.Data.Context;
using ShoppingProject.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Data.Concrete
{
    public class CustomerRepository : EntityRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ShoppingContext context) : base(context) { }
    }
}
