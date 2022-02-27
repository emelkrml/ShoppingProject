using ShoppingProject.Business.Abstract;
using ShoppingProject.Logger.Abstract;
using ShoppingProject.Logger.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Business.Concrete
{
    public class LogBusiness : ILogBusinesss
    {
        IGeneralLogRepository _generalLog;
        IExceptionLogRepository _exceptionLog;

        public IGeneralLogRepository GeneralLog
            => _generalLog ?? (_generalLog = new GeneralLogRepository());

        public IExceptionLogRepository ExceptionLog
            => _exceptionLog ?? (_exceptionLog = new ExceptionLogRepository());

    }
}
