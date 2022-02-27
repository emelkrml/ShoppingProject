using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Core.Utilities.Result.Abstract
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
