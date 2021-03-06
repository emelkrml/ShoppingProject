using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Core.Utilities.Result.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(success: false, message)
        {
        }

        public ErrorResult() : base(success: false)
        {
        }
    }
}
