using ShoppingProject.Core.Data;
using ShoppingProject.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Data.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
    }
}
