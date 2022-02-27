using ShoppingProject.Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Business.Abstract
{
    public interface ILogBusinesss
    {
        IGeneralLogRepository GeneralLog { get; }
        IExceptionLogRepository ExceptionLog { get; }
    }
}
