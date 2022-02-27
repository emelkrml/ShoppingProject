using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Core.Utilities.Result.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(success: true, message)
        {

        }

        public SuccessResult() : base(success: true)
        {

        }
    }
}
