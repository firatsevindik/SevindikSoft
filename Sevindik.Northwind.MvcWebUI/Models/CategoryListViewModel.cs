using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}
