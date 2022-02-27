using ShoppingProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Entity.Logger
{
    public class ExceptionLog : ILog
    {
        public ExceptionLog() => this.Date = DateTime.Now;
        public DateTime Date { get; set; }
        public string ExceptionInfo { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}
