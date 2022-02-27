using ShoppingProject.Core.Logger;
using ShoppingProject.Entity.Logger;
using ShoppingProject.Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Logger.Concrete
{
    public class GeneralLogRepository : LogRepository<GeneralLog>, IGeneralLogRepository
    {
        public GeneralLogRepository() : base("generalLogs.json") { }
    }
}
