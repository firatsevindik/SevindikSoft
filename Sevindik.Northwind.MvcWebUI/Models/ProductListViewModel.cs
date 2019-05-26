using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
