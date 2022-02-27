using ShoppingProject.Core.Logger;
using ShoppingProject.Entity.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Logger.Abstract
{
    public interface IGeneralLogRepository : ILogRepository<GeneralLog>
    {
    }
}
