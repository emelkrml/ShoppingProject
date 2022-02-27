using ShoppingProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Entity.Data
{
    public class Category : IEntity
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
